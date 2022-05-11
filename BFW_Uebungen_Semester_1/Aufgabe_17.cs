using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_17
    {
        public static void Start()
        {
            //Eingabe Zahl oder String.
            Console.WriteLine("Hallo! Geben Sie einen String oder eine Zahl ein: ");
            string input1 = Console.ReadLine();
            int ergebnis1, ergebnis2;

            if (!int.TryParse(input1 , out int n))
            {
                ergebnis1 = input1.Length * 2 % 10;     //Wenn Zahl.
            } else
            {
                ergebnis1 = n % 10;                     //Wenn String.
            }

            ergebnis1 += 1;
            Console.WriteLine("Hallo! Geben Sie einen zweiten String oder eine zweite Zahl ein: ");
            string input2 = Console.ReadLine();

            if (!int.TryParse(input2, out int m))
            {
                ergebnis2 = input2.Length * 5 % 100;    //Wenn Zahl.
            }
            else
            {
                ergebnis2 = m * 3;                      //Wenn String.
            }

            //Ausgabe.
            Console.Clear();
            Console.WriteLine("Das Ergebnis ist: {0} / {1} = {2}", ergebnis2, ergebnis1, ergebnis2 / ergebnis1);
        }
    }
}
