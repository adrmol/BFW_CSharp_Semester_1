using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_C1a
    {
        public static void Start()
        {
            double zahl;
            string umrechnungrichtung;
            string einheit = "";

            do
            {

                Console.WriteLine("Soll von Kalorien in Joule [1]\noder von Joule in Kalorien [2]\numgerechnet werden?");
                umrechnungrichtung = Console.ReadLine();

            } while (umrechnungrichtung != "1" && umrechnungrichtung != "2");

            do
                Console.WriteLine("Welche Zahl soll umgerechnet werden?");
            while (!double.TryParse(Console.ReadLine(), out zahl));

            switch (umrechnungrichtung)
            {

                case "1":
                    zahl *= 4.1867;
                    einheit = "Joule";
                    break;

                case "2":
                    zahl *= 0.23885;
                    einheit = "Kalorien";
                    break;

            }

            Console.WriteLine("Ihr Ergebnis {0} {1}.", zahl, einheit);

        }
    }
}
