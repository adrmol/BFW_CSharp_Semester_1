using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_Y3
    {
        public static void Start()
        {
            Console.WriteLine("Geben Sie das Startkapital ein:");
            decimal kapital = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Geben Sie den Zinssatz pro Jahr in Prozent ein:");
            decimal zinsProJahr = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Geben Sie an, für wie viele Jahre das Geld angelegt wird:");
            int jahre = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < jahre; i++)
                kapital = (kapital / 100 * (zinsProJahr + 100));

            Console.WriteLine("Endkapital: " + Decimal.Round(kapital, 2));
        }
    }
}
