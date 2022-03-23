using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;



namespace Weitere_Übungsaufgaben
{
    class Aufgabe_X3new
    {
        static long Reverse(int number)
        {
            long result = 0;
            while (number > 0)
            {
                result = (result * 10) + number % 10;
                number /= 10;
            }
            return result;
        }

        public static void Start()
        {
            long eingabeuser;

            do
                Console.WriteLine("Bitte geben Sie an, wie viele Mirpzahlen ausgegeben werden: (Max: 4809260)");
            while (!long.TryParse(Console.ReadLine(), out eingabeuser) || eingabeuser < 1);

            long primecount = Convert.ToInt64(eingabeuser * (Math.Log(eingabeuser) + Math.Log(Math.Log(eingabeuser))) * Math.Log(eingabeuser) * Math.Log(eingabeuser));

            bool[] notprime;

            if (eingabeuser < 5000)
                notprime = new bool[eingabeuser * 1000];
            else if (primecount > 4809260)
            {
                notprime = new bool[2147483000];
                primecount = 4809260;
                if (eingabeuser > 4809260)
                    eingabeuser = 4809260;
            }
            else
                notprime = new bool[primecount + 1];

            notprime[0] = true;
            notprime[1] = true;

            for (int p = 2; p * p <= notprime.Length-1; p++)
            {
                if (notprime[p] == false)
                {
                    for (long i = p * 2; i <= notprime.Length-1; i += p)
                        notprime[i] = true;
                }
            }

            int primenumber = 0;
            int anzahl = 1;

            foreach (bool i in notprime)
            { 
                if (i == false)
                {
                    long rev = Reverse(primenumber);
                    if (primenumber != rev && !notprime[rev])
                        Console.WriteLine("{0}. {1} ", anzahl++, primenumber);
                } 

                primenumber++;

                
                
                if (anzahl == eingabeuser + 1)
                  break;
            }
            /*
            double laenge = notprime.Length;
            double größtemirp = primenumber;

            Console.WriteLine("array länge: " + notprime.Length);
            Console.WriteLine("mirpprime schätzung: " + laenge / größtemirp);
            */
        }
    }
}

                



