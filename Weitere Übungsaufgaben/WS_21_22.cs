using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    internal class WS_21_22
    {
        public static void Start()
        {
            Console.WriteLine("Wie viele Zahlen sollen addiert werden?");

            int.TryParse(Console.ReadLine(), out int anzahl);

            var array = new int[anzahl];
            int summe = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Geben Sie nun Zahl Nr.{0} ein:", i + 1);
                int.TryParse(Console.ReadLine(), out int eingabe);
                array[i] = eingabe;
                summe += eingabe;
            }

            Console.Clear();
            Console.WriteLine(summe);

            if(summe % 2 == 0)
                Console.WriteLine("Zahl ist gerade!");
            else
                Console.WriteLine("Zahl ist ungerade!");
        }
    }
}
