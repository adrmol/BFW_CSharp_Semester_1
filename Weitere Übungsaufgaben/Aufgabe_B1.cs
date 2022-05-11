using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_B1
    {
        public static void Start()
        {
            bool loop;
            decimal einkaufsPreis, vermietsPreis;

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Durchnittlichen Einkaufspreis eingeben: ");

            do
            {
                if (loop = !decimal.TryParse(Console.ReadLine(), out einkaufsPreis))
                    Console.WriteLine("Falsche Eingabe, bitte nochmal versuchen:");
            } while (loop);

            Console.WriteLine("Durchnittlichen Vermietspreis eingeben:");

            do
            {
                if (loop = !decimal.TryParse(Console.ReadLine(), out vermietsPreis))
                    Console.WriteLine("Falsche Eingabe, bitte nochmal versuchen:");
            } while (loop);

            Console.WriteLine("\nKosten wieder eingenommen nach {0} Monaten ({1} Jahr/e {2} Monat/e)", Math.Ceiling(einkaufsPreis / vermietsPreis) , Math.Floor(einkaufsPreis / vermietsPreis / 12), Math.Ceiling(einkaufsPreis / vermietsPreis % 12));
            
            for (int i = 5; i <= 20; i += 5)
                Console.WriteLine("Nach {0} Jahren: {1:N2}", i, Math.Round((vermietsPreis * i * 12 - einkaufsPreis), 2, MidpointRounding.AwayFromZero), i);
        }
    }
}
