﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    internal class Aufgabe_15
    {
        public static void Start()
        {
            //Eingabe von Nutzer.
            Console.WriteLine("Warte auf Eingabe...\n");
            string input1 = Console.ReadLine();
            Console.Clear();

            //Wenn die Eingabe eine Zahl ist.
            if (long.TryParse(input1, out long num))
            {
                //if: die Zahl ist gerade; else: Zahl ist ungerade
                if (num % 2 == 0)
                {

                    Console.WriteLine("Der eingegebene Wert \u0022{0}\u0022 ist eine Zahl und die Hälfte ist {1}.", num, num / 2);
                
                } else {

                    Console.WriteLine("Der eingegebene Wert \u0022{0}\u0022 ist eine Zahl und die Hälfte ist {1} mit dem Rest {2}.", num, num / 2, num % 2);
                
                }

            }
            //Wenn die Eingabe keine Zahl ist, d.h. ein String.
            else
            {
                //if: die Länge ist gerade; else: Länge ist ungerade
                if (input1.Length % 2 == 0)
                {

                    Console.WriteLine("Der eingegebene Wert \u0022{0}\u0022 ist ein String und die Hälfte ist \u0022{1}\u0022 und \u0022{2}\u0022.", input1, input1.Substring(0, input1.Length / 2), input1.Substring(input1.Length / 2, input1.Length / 2));

                } else {

                    Console.WriteLine("Der eingegebene Wert \u0022{0}\u0022 ist ein String und die Hälfte ist \u0022{1}\u0022 und \u0022{2}\u0022 mit dem mittleren Buchstaben \u0022{3}\u0022.",input1, input1.Substring(0, input1.Length / 2), input1.Substring(input1.Length / 2 + 1, input1.Length / 2), input1.Substring(input1.Length / 2, 1));

                }
                

            } 
        }
    }
}
