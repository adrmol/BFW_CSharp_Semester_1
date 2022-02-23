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

            //Eingabe.
            string input1 = Console.ReadLine();

            //Leerzeichen weg mit "Trim(), umwandeln in Kleinbuchstaben (ToLower()) damit es egal ist ob der Benutzer Groß- oder Kleinbuchstaben verwendet.
            string input2 = input1.Trim().ToLower();

            //Drei Begrüßungen bekannt: hi, hey, hallo.
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
