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
            decimal einkaufsPreis, vermietsPreis, monate;

            Console.WriteLine("Durchnittlichen Einkaufspreis eingeben: ");

            do
                if (loop = !decimal.TryParse(Console.ReadLine(), out einkaufsPreis))
                    Console.WriteLine("Falsche Eingabe, bitte nochmal versuchen:");
            while (loop);

            Console.WriteLine("Durchnittlichen Vermietspreis eingeben:");

            do
                if (loop = !decimal.TryParse(Console.ReadLine(), out vermietsPreis))
                    Console.WriteLine("Falsche Eingabe, bitte nochmal versuchen:");
            while (loop);

            monate = einkaufsPreis / vermietsPreis;
            Console.WriteLine("\nKosten wieder eingenommen nach {0} Monat/en ({1} Jahr/e {2} Monat/e)", Math.Ceiling(monate), Math.Floor(monate / 12), Math.Ceiling(monate % 12));

            for (int i = 5; i <= 20; i += 5)
                Console.WriteLine("Nach {0} Jahren: {1:N2}", i, Math.Round(vermietsPreis * i * 12 - einkaufsPreis, 2, MidpointRounding.AwayFromZero), i);
        }
    }
}
