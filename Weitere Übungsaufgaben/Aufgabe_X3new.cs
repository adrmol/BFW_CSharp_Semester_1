using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Weitere_Übungsaufgaben
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using PrimeT = System.UInt32;
    class PrimesPgd : IEnumerable<PrimeT>
    {
        private const int PGSZ = 1 << 14; // L1 CPU cache size in bytes
        private const int BFBTS = PGSZ * 8; // in bits
        private const int BFRNG = BFBTS * 2;
        public IEnumerator<PrimeT> nmrtr()
        {
            IEnumerator<PrimeT> bps = null;
            List<uint> bpa = new List<uint>();
            uint[] cbuf = new uint[PGSZ / 4]; // 4 byte words
            yield return 2;
            for (var lowi = (PrimeT)0; ; lowi += BFBTS)
            {
                for (var bi = 0; ; ++bi)
                {
                    if (bi < 1)
                    {
                        if (bi < 0) { bi = 0; yield return 2; }
                        PrimeT nxt = 3 + lowi + lowi + BFRNG;
                        if (lowi <= 0)
                        { // cull very first page
                            for (int i = 0, p = 3, sqr = 9; sqr < nxt; i++, p += 2, sqr = p * p)
                                if ((cbuf[i >> 5] & (1 << (i & 31))) == 0)
                                    for (int j = (sqr - 3) >> 1; j < BFBTS; j += p)
                                        cbuf[j >> 5] |= 1u << j;
                        }
                        else
                        { // cull for the rest of the pages
                            Array.Clear(cbuf, 0, cbuf.Length);
                            if (bpa.Count == 0)
                            { // inite secondar base primes stream
                                bps = nmrtr(); bps.MoveNext(); bps.MoveNext();
                                bpa.Add((uint)bps.Current); bps.MoveNext();
                            } // add 3 to base primes array
                              // make sure bpa contains enough base primes...
                            for (PrimeT p = bpa[bpa.Count - 1], sqr = p * p; sqr < nxt;)
                            {
                                p = bps.Current; bps.MoveNext(); sqr = p * p; bpa.Add((uint)p);
                            }
                            for (int i = 0, lmt = bpa.Count - 1; i < lmt; i++)
                            {
                                var p = (PrimeT)bpa[i]; var s = (p * p - 3) >> 1;
                                // adjust start index based on page lower limit...
                                if (s >= lowi) s -= lowi;
                                else
                                {
                                    var r = (lowi - s) % p;
                                    s = (r != 0) ? p - r : 0;
                                }
                                for (var j = (uint)s; j < BFBTS; j += p)
                                    cbuf[j >> 5] |= 1u << ((int)j);
                            }
                        }
                    }
                    while (bi < BFBTS && (cbuf[bi >> 5] & (1 << (bi & 31))) != 0) ++bi;
                    if (bi < BFBTS) yield return 3 + (((PrimeT)bi + lowi) << 1);
                    else break; // outer loop for next page segment...
                }
            }
        }
        public IEnumerator<PrimeT> GetEnumerator() { return nmrtr(); }
        IEnumerator IEnumerable.GetEnumerator() { return (IEnumerator)GetEnumerator(); }
    }
    class Aufgabe_X3new
    {
        static int Reverse(int number)
        {
            int result = 0;
            while (number > 0)
            {
                result = (result * 10) + number % 10;
                number /= 10;
            }
            return result;
        }
        public static void Start()
        {
            //PrimesPgd a = new PrimesPgd();
            //Console.WriteLine(a.Take(int.MaxValue/100).Delimit());
            //return;
            int eingabeuser;
            const int partition = 1000;

            do
                Console.WriteLine("Bitte geben Sie an, wie viele Mirpzahlen ausgegeben werden: (Max: 4809260) ");
            while (!(int.TryParse(Console.ReadLine(), out eingabeuser) && eingabeuser >= 0 && eingabeuser <= 4809260));

            long size = (long) Math.Pow(10, (int) (1.3 * Math.Log(eingabeuser, 15) + 2.6) );
            //if (eingabeuser > 617236)
            //    size = 1_000_000_000;
            //else if (eingabeuser > 81658)
            //    size = 100_000_000;
            //else if (eingabeuser > 11184)
            //    size = 10_000_000;
            //else if (eingabeuser > 1646)
            //    size = 1_000_000;
            //else if (eingabeuser > 240)
            //    size = 100_000;
            //else if (eingabeuser > 36)
            //    size = 10_000;
            //else if (eingabeuser > 8)
            //    size = 1_000;
            //else
            //    size = 100;

            bool[] notPrime = new bool[(int) size];
            ConcurrentBag<int> emirpBag = new ConcurrentBag<int>();
            notPrime[0] = true;
            notPrime[1] = true;
            int lenght = notPrime.Length;
            Parallel.For(2, (int) Math.Sqrt(lenght), p =>
            {
                if (notPrime[p] == false)
                    for (int i = p * 2; i < lenght; i += p)
                        notPrime[i] = true;
            });
            Parallel.For(0, lenght / partition, p =>
            {
                for (int i = p * partition; i < p * partition + partition; i++)
                    if (notPrime[i] == false)
                    {
                        int rev = Reverse(i);
                        if (i != rev && !notPrime[rev])
                            emirpBag.Add(i);
                    }
            });
            for (int i = lenght - lenght % partition; i < lenght; i++)
                if (notPrime[i] == false)
                {
                    int rev = Reverse(i);
                    if (i != rev && !notPrime[rev])
                        emirpBag.Add(i);
                }
            var list = emirpBag.ToList();
            list.Sort();
            list.RemoveRange(eingabeuser, list.Count() - eingabeuser);
            var list2 = new List<string>(new string[list.Count() / partition + 1]);
            
            Parallel.For(0, list.Count() / partition, p =>
            {
                for (int i = p * partition; i < p * partition + partition; i++)
                    list2[p] += i + 1 + " " + list[i] + "\n";
            });

            for (int i = list.Count() - list.Count() % partition; i < list.Count(); i++)
                list2[list2.Count() - 1] += i + 1 + " " + list[i] + "\n";

            //Parallel.ForEach(list, i => Console.WriteLine(i));

            //using (var sw = new System.IO.StreamWriter(@"C:\Users\admin\Desktop\text\text.txt"))
            //{
            //    foreach (var i in list2)
            //        sw.Write(i);
            //}
            //using (FileStream fs = new FileStream(@"C:\Users\admin\Desktop\text\text.txt", FileMode.Open))
            //{
            //    fs.SetLength(fs.Length - 1);
            //}
            foreach (var i in list2)
                Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}

                



