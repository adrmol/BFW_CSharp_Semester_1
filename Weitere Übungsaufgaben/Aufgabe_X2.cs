using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_X2
    {
        public static void Start()
        {
            int a = 2;
            int x;

            do
                Console.WriteLine("Bitte geben Sie eine positive Zahl ein:");
            while (!int.TryParse(Console.ReadLine(), out x) || x < 1);


            int[] zahlenfolge = new int[x - 1];
            int[] primzahlen = new int[0];

            for (int i = 0; i < x - 1; i++)
            {
                zahlenfolge[i] = a++;
            }

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
                    int[] tempArr = new int[primzahlen.Length + 1];
                    for (int j = 0; j < primzahlen.Length; j++)
                        tempArr[j] = primzahlen[j];
                    primzahlen = tempArr;
                    primzahlen[primzahlen.Length - 1] = i;
                }

            }

            /*foreach (int y in zahlenfolge)
                Console.Write(y + " ");

            Console.WriteLine();*/

            Console.WriteLine("\nBerechnete Primzahlen:");

            if (primzahlen.Length == 0)
                Console.WriteLine("Schade, keine Primzahlen gefunden!");

            foreach (int z in primzahlen)
                Console.Write(z + " ");

        }
    }
}
