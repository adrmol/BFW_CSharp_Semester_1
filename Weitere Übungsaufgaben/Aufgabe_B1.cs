using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_B1
    {
        public static void Start()
        {
            bool eingabe = false;
            decimal einkaufsPreis = 0;
            decimal vermietsPreis = 0;

            Console.WriteLine("Durchnittlichen Einkaufspreis eingeben:");

            do
            {
                if (eingabe = !decimal.TryParse(Console.ReadLine(), out einkaufsPreis))
                    Console.WriteLine("Falsche Eingabe, bitte nochmal versuchen:");
            } while (eingabe);

            Console.WriteLine("Durchnittlichen Vermietspreis eingeben:");

            do
            {
                if (eingabe = !decimal.TryParse(Console.ReadLine(), out vermietsPreis))
                    Console.WriteLine("Falsche Eingabe, bitte nochmal versuchen:");
            } while (eingabe);

            //rundet quasi auf den Monat auf
            Console.WriteLine("test:" + (Convert.ToInt32(einkaufsPreis / vermietsPreis)) / 12);
            if (einkaufsPreis % vermietsPreis == 0)
                Console.WriteLine("\nKosten wieder eingenommen nach {0} Monaten ({1} Jahr/e {2} Monat/e)", einkaufsPreis / vermietsPreis, einkaufsPreis / vermietsPreis / 12);
            else
                Console.WriteLine("\nKosten wieder eingenommen nach {0} Monaten ({1} Jahr/e {2} Monat/e)", Convert.ToInt32(einkaufsPreis / vermietsPreis) + 1, (Convert.ToInt32(einkaufsPreis / vermietsPreis) + 1) /  12, (Convert.ToInt32(einkaufsPreis / vermietsPreis) + 1) % 12);

            Console.WriteLine("Nach 5 Jahren: " + (vermietsPreis * 5 * 12 - einkaufsPreis));
            Console.WriteLine("Nach 10 Jahren: " + (vermietsPreis * 10 * 12 - einkaufsPreis));
            Console.WriteLine("Nach 15 Jahren: " + (vermietsPreis * 15 * 12 - einkaufsPreis));
            Console.WriteLine("Nach 20 Jahren: " + (vermietsPreis * 20 * 12 - einkaufsPreis));

        }
    }
}
