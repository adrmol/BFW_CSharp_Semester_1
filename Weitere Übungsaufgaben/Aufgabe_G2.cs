using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_G2
    {
        public static void Start()
        {
            int zahl1, zahl2;
            double ergebnis1, ergebnis2;
            int result = 0;

            do
            {
                Console.WriteLine("Bitte geben Sie eine Zahl mit mindestens drei Stellen ein:");
                if (!int.TryParse(Console.ReadLine(), out zahl1) || zahl1 < 100)
                {
                    Console.WriteLine("Leider entspricht Ihre Zahl nicht den Vorgaben");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                break;
            } while (true);

            zahl2 = zahl1;

            while (zahl2 > 0)
            {
                result = (result * 10) + zahl2 % 10;
                zahl2 /= 10;
            }

            zahl2 = result;
            Console.Clear();

            Console.WriteLine("Hier ist die erste Zahl: " + zahl1);
            Console.WriteLine("Hier ist die zweite Zahl: " + zahl2);

            Convert.ToDouble(zahl1);
            Convert.ToDouble(zahl2);

            ergebnis1 = zahl2 / zahl1;
            Math.Round(ergebnis1, 2);

            ergebnis2 = zahl1 / zahl2;
            Math.Round(ergebnis2, 2);

            if (ergebnis1 > ergebnis2)
            {
                Console.WriteLine("Hier ist das größere Ergebnis: " + ergebnis1);
                Console.WriteLine("Hier ist das kleinere Ergebnis: " + ergebnis2);
            } 
            else
            {
                Console.WriteLine("Hier ist das größere Ergebnis: " + ergebnis2);
                Console.WriteLine("Hier ist das kleinere Ergebnis: " + ergebnis1);
            }
        }
    }
}
