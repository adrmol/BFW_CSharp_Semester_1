using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_18
    {

        public static void Start()
        {

            Console.WriteLine("Bitte geben Sie eine Begrüßung ein:");
            string input1 = Console.ReadLine();
            string input2 = input1.Trim().ToLower();

            switch(input2)
            {
                case "hi":
                    Console.WriteLine("Hey!\nDie Begrüßung \u0022" + input1 + "\u0022 kenne ich! :D");
                    break;

                case "hey":
                    Console.WriteLine("Hallo!\nDie Begrüßung \u0022" + input1 + "\u0022 kenne ich! :D");
                    break;

                case "hallo":
                    Console.WriteLine("Hi!\nDie Begrüßung \u0022" + input1 + "\u0022 kenne ich! :D");
                    break;

                default:
                    Console.WriteLine("Hi!\nLeider kenne ich die Begrüßung nicht! :(");
                    break;

            }
        }
    }
}
