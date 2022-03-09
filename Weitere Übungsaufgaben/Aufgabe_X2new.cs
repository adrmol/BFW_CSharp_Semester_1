using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    internal class Aufgabe_X2new
    {

        public static void Start()
        {
            int eingabeuser;

            do
                Console.WriteLine("Bitte geben Sie an, bis zu welcher Zahl alle Primzahlen ausgegeben werden sollen:");
            while (!int.TryParse(Console.ReadLine(), out eingabeuser) || eingabeuser < 1);

            bool[] notprime = new bool[eingabeuser + 1];

            notprime[0] = true;
            notprime[1] = true;

            for (int p = 2; p * p <= notprime.Length - 1; p++)
            {
                if (notprime[p] == false)
                {
                    for (int i = p * 2; i <= notprime.Length - 1; i += p)
                        notprime[i] = true;
                }
            }

            int anzahl = 1;
            int primenumber = 0;

            foreach (bool i in notprime)
            {
                if (i == false)
                        Console.WriteLine("{0}. {1}", anzahl++, primenumber++);
                else
                    primenumber++;
            }
        }
    }
}
