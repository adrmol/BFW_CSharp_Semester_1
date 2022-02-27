using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_X3
    {
        public static void Start()
        {
            int a = 2;
            int i = 0;
            int z = 0;
            int y = 0;
            int l;
            int x;

            do
                Console.WriteLine("Bitte geben Sie eine positive Zahl ein:");
            while (!int.TryParse(Console.ReadLine(), out x) || x < 1);


            int[] zahlenfolge = new int[0];
            int[] primzahlen = new int[0];
            int[] primzahlenrueckwaerts = new int[1];
            int[] mirpprimzahlen = new int[0];

            while (primzahlenrueckwaerts.Length < x)
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
                primzahlenrueckwaerts[primzahlenrueckwaerts.Length - 1] = l;

            }

            /*foreach (int y in zahlenfolge)
                Console.Write(y + " ");

            Console.WriteLine();*/

            Console.WriteLine("\nBerechnete Primzahlen rückwärts:");

            if (primzahlen.Length == 0)
                Console.WriteLine("Schade, keine Primzahlen gefunden!");

            foreach (int ende in primzahlenrueckwaerts)
                Console.Write(ende + " ");

        }
    }
}
