using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    internal class Aufgabe_15
    {
        public static void Start()
        {
            Console.WriteLine("Warte auf Input...\n");
            string input1 = Console.ReadLine();
            Console.Clear();
            if (long.TryParse(input1, out long num))
            {
                if (num % 2 == 0)
                {

                    Console.WriteLine("Der eingegebene Wert " + "\u0022" + num + "\u0022" + " ist eine Zahl und die Hälfte ist " + num / 2 + ".");
                
                } else {

                    Console.WriteLine("Der eingegebene Wert " + "\u0022" + num + "\u0022" + " ist eine Zahl und die Hälfte ist " + num / 2 + " mit dem Rest " + num % 2 + ".");
                
                }
            
            } else {

                if (input1.Length % 2 == 0)
                {

                    Console.WriteLine("Der eingegebene Wert " + "\u0022" + input1 + "\u0022" + " ist ein String und die Hälfte ist " + "\u0022" + input1.Substring(0, input1.Length / 2) + "\u0022" + " und " + "\u0022" + input1.Substring(input1.Length / 2, input1.Length / 2) + "\u0022" + ".");

                } else {

                    Console.WriteLine("Der eingegebene Wert " + "\u0022" + input1 + "\u0022" + " ist ein String und die Hälfte ist " + "\u0022" + input1.Substring(0, input1.Length / 2) + "\u0022" + " und " + "\u0022" + input1.Substring(input1.Length / 2 + 1, input1.Length / 2) + "\u0022" + " mit dem mittleren Buchstaben " + "\u0022" + input1.Substring(input1.Length / 2, 1) + "\u0022" + ".");

                }
                

            } 
        }
    }
}
