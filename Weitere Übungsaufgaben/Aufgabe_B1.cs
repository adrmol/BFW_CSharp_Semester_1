using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_B1
    {
        public static void Start()
        {
            bool eingabe;
            decimal einkaufsPreis, vermietsPreis;

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

            if (einkaufsPreis % vermietsPreis == 0)
                Console.WriteLine("\nKosten wieder eingenommen nach {0} Monaten ({1} Jahr/e {2} Monat/e)", Decimal.ToInt32(einkaufsPreis / vermietsPreis) , Decimal.ToInt32(einkaufsPreis / vermietsPreis) /  12, Decimal.ToInt32(einkaufsPreis / vermietsPreis) % 12);
            else
                Console.WriteLine("\nKosten wieder eingenommen nach {0} Monaten ({1} Jahr/e {2} Monat/e)", Decimal.ToInt32(einkaufsPreis / vermietsPreis) + 1, Decimal.ToInt32(einkaufsPreis / vermietsPreis) / 12 + 1, Decimal.ToInt32(einkaufsPreis / vermietsPreis) % 12 + 1);

            Console.WriteLine("Nach 5 Jahren: " + (vermietsPreis * 5 * 12 - einkaufsPreis));
            Console.WriteLine("Nach 10 Jahren: " + (vermietsPreis * 10 * 12 - einkaufsPreis));
            Console.WriteLine("Nach 15 Jahren: " + (vermietsPreis * 15 * 12 - einkaufsPreis));
            Console.WriteLine("Nach 20 Jahren: " + (vermietsPreis * 20 * 12 - einkaufsPreis));

        }
    }
}
