using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_22
    {
        public static void Start()
        {
            Console.WriteLine("Bitte Zahlen eingeben und mit Enter bestätigen:");

            int summe = 0;
            int anzahl = 0;

            do
            {
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    summe += num;
                    anzahl++;
                }
            } while (summe <= 100);

            Console.WriteLine("\nDie Summe der Eingaben: " + summe);
            Console.WriteLine("Die Anzahl der Eingaben, bis die 100 überschritten wurde: " + anzahl);
        }
    }
}
