using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_G1
    {
        public static void Start()
        {
            int i, j;
            do
            {
                Console.WriteLine("Bitte geben Sie eine Zahl ein");

                if (!int.TryParse(Console.ReadLine(), out i))
                {
                    Console.Clear();
                    continue;
                }

                i *= 3;

                if (i % 2 != 0)
                {
                    Console.WriteLine("Leider ist die Zahl unpassend!");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                break;

            } while (true);

            for (j = 0; j < i; j++)
                i /= 2;

            Console.WriteLine("Ihr Ergebnis ist: " + j);
        }
    }
}
