using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_A2
    {

        public static void Start()
        {

            Console.WriteLine("Geben Sie eine Fallhöhe in m ein:");
            double fallhoehe;
            double anzahl = 0;

            while (!double.TryParse(Console.ReadLine(), out fallhoehe)) 
            { }

            while (fallhoehe > 0.01)
            {

                fallhoehe /= 2;
                anzahl++;

            }

            Console.WriteLine("\nDie Anzahl der Sprünge: " + anzahl);

        }
    }
}
