using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    internal class Aufgabe_Y1
    {
        public static void Start()
        {
            Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            bool richtigezahl = true;
            long x = 0;

            while (richtigezahl)
            {
                if (!long.TryParse(Console.ReadLine(), out x))
                    Console.WriteLine("Bitte nochmal!");
                else
                    richtigezahl = false;
                Console.Clear();
            }
            while (true)
            {
                Console.Clear();
                Console.Write(x *= 2);
                Console.ReadKey();
            }
        }
    }
}
