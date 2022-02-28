using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_X3
    {

        public static void ArrayExpand(ref int[] array)
        {
            int[] tempArr = new int[array.Length + 1];
                    for (int i = 0; i < array.Length; i++)
                        tempArr[i] = array[i];
                    array = tempArr;
        }


        public static void Start()
        {
            int eingabe;
            int zahlenfolgeaufzaehlung = 0;
            int aufzaehlunginreversed = 0;
            int aufzahlunginmirpprimzahlen = 0;
            int temppppp = 0;

            do
                Console.WriteLine("Bitte geben Sie eine positive Zahl ein:");
            while (!int.TryParse(Console.ReadLine(), out eingabe) || eingabe < 1);

            int[] zahlenfolge = new int[0];
            int[] primzahlen = new int[0];
            int[] primzahlenreversed = new int[0];
            int[] tempmirprimzahlen = new int[0];
            

            do
            {
                do
                {

                    ArrayExpand(ref zahlenfolge);
                    zahlenfolge[zahlenfolgeaufzaehlung] = ++zahlenfolgeaufzaehlung + 1;

                    foreach (int i in zahlenfolge)
                    {

                        bool nichtprimzahl = false;

                        foreach (int j in primzahlen)
                        {
                            if (i % j == 0)
                            {
                                nichtprimzahl = true;
                                break;
                            }
                        }

                        if (!nichtprimzahl)
                        {
                            ArrayExpand(ref primzahlen);
                            primzahlen[primzahlen.Length - 1] = i;

                            
                            string tempk = primzahlen[primzahlen.Length - 1].ToString();
                            string tempk2 = "";
                            for (int j = 1; j <= tempk.Length; j++)
                                tempk2 += tempk.Substring(tempk.Length - j, 1);
                            int tempkINT = Convert.ToInt32(tempk2);
                            if (i != tempkINT)
                            {
                                ArrayExpand(ref primzahlenreversed);
                                primzahlenreversed[primzahlenreversed.Length - 1] = tempkINT;
                            }
                        }
                    }
                } while (primzahlenreversed.Length < 1 || primzahlenreversed[aufzaehlunginreversed] > primzahlen[primzahlen.Length - 1]);

                ++aufzaehlunginreversed;
                
                foreach (int i in primzahlenreversed)
                {
                    
                    foreach (int j in primzahlen)
                    {
                        if (i == j)
                        {
                            ArrayExpand(ref tempmirprimzahlen);
                            tempmirprimzahlen[temppppp] = j;
                            temppppp++;
                        }
                    }
                }

            } while(tempmirprimzahlen.Length <= eingabe);

            int[] mirprimzahlen = new int[eingabe];

            Array.Sort(tempmirprimzahlen);
            Console.WriteLine(tempmirprimzahlen[0]);
            int endcount = 0;
            int mirparraycount = 0;
            do
            {

  
                if (endcount > 0 && endcount < tempmirprimzahlen.Length -1 && (tempmirprimzahlen[endcount]) != tempmirprimzahlen[endcount - 1])
                {

                    mirprimzahlen[mirparraycount] = tempmirprimzahlen[endcount];
                    Console.WriteLine(tempmirprimzahlen[mirparraycount]);
                    mirparraycount++;
                   
                }
                endcount++;
            } while (mirprimzahlen[eingabe - 1] == 0);

                





            /*int a = 2;
            int i = 0;
            int z = 0;
            int y = 0;
            int vergleich1 = 0;
            int vergleich2 = 0;
            int l;
            int x;

            do
                Console.WriteLine("Bitte geben Sie eine positive Zahl ein:");
            while (!int.TryParse(Console.ReadLine(), out x) || x < 1);


            int[] zahlenfolge = new int[0];
            int[] primzahlen = new int[0];
            int[] primzahlenrueckwaerts = new int[1];
            int[] mirpprimzahlen = new int[0];

            do //(primzahlenrueckwaerts.Length < x)
            {
                do
                {
                    int[] tempArr3 = new int[zahlenfolge.Length + 1];
                    for (int m = 0; m < zahlenfolge.Length; m++)
                        tempArr3[m] = zahlenfolge[m];
                    zahlenfolge = tempArr3;

                    zahlenfolge[i] = a++;
                    i++;

                    foreach (int k in zahlenfolge)
                    {

                        bool nichtprimzahl = false;

                        foreach (int j in primzahlen)
                        {
                            if (k % j == 0)
                            {
                                nichtprimzahl = true;
                                break;
                            }
                        }

                        if (!nichtprimzahl)
                        {
                            int[] tempArr = new int[primzahlen.Length + 1];
                            for (int j = 0; j < primzahlen.Length; j++)
                                tempArr[j] = primzahlen[j];
                            primzahlen = tempArr;
                            primzahlen[primzahlen.Length - 1] = k;

                        }

                        y = k;

                    }
                } while (primzahlenrueckwaerts[z] > primzahlen[primzahlen.Length - 1]);

                int[] tempArr2 = new int[primzahlenrueckwaerts.Length + 1];
                for (int j = 0; j < primzahlenrueckwaerts.Length; j++)
                    tempArr2[j] = primzahlenrueckwaerts[j];
                primzahlenrueckwaerts = tempArr2;

                string tempk = y.ToString();
                string tempk2 = "";
                for (int j = 1; j <= tempk.Length; j++)
                    tempk2 += tempk.Substring(tempk.Length - j, 1);
                l = Convert.ToInt32(tempk2);
                if (k != l)
                    primzahlenrueckwaerts[primzahlenrueckwaerts.Length - 1] = l;

            } while (primzahlenrueckwaerts[vergleich1] > primzahlen[primzahlen.Length - 1]);

            /*foreach (int y in zahlenfolge)
                Console.Write(y + " ");

            Console.WriteLine();

            Console.WriteLine("\nBerechnete Primzahlen rückwärts:");

            if (primzahlen.Length == 0)
                Console.WriteLine("Schade, keine Primzahlen gefunden!");

            foreach (int ende in primzahlenrueckwaerts)
                Console.Write(ende + " ");
            */
        }
    }
}
