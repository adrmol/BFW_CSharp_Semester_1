using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_C3b
    {
        public static void Start()
        {
            int eingabeuser;
            int eingabeuser2;

            do
                Console.WriteLine("Wie viele Kaninchen gibt es?");
            while (!int.TryParse(Console.ReadLine(), out eingabeuser) || eingabeuser < 1);

            do
                Console.WriteLine("Wie viele Kaninchen soll es geben?");
            while (!int.TryParse(Console.ReadLine(), out eingabeuser2) || eingabeuser2 < 1 || eingabeuser2 < eingabeuser);

            int fib1 = 0;
            int fib2 = eingabeuser;
            int tempfib;
            int anzahl = 0;

            do
            {
                tempfib = fib2;
                fib2 += fib1;
                fib1 = tempfib;
                anzahl++;
            } while (fib2 < eingabeuser2);

            Console.WriteLine();
            Console.WriteLine("Schritte: " + anzahl);
        }
    }
}
