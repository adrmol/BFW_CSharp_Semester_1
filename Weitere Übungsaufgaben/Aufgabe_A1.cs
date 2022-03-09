using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    internal class Aufgabe_A1
    {
        public static void Start()
        {

            Console.WriteLine("Bitte geben Sie zwei Grundfarben (blau, gelb, rot) an:");

            string farbe1 = Console.ReadLine().Trim().ToLower();
            string farbe2 = Console.ReadLine().Trim().ToLower();

            if (farbe1 == farbe2 && (farbe1 == "blau" || farbe1 == "gelb" || farbe1 == "rot"))
                Console.WriteLine("{0} + {1} = {2}", farbe1, farbe2, farbe1);

            else if ((farbe1 == "blau" || farbe2 == "blau") && (farbe1 == "gelb" || farbe2 == "gelb"))
                Console.WriteLine("{0} + {1} = grün", farbe1, farbe2);

            else if ((farbe1 == "blau" || farbe2 == "blau") && (farbe1 == "rot" || farbe2 == "rot"))
                Console.WriteLine("{0} + {1} = lila", farbe1, farbe2);
            
            else if ((farbe1 == "gelb" || farbe2 == "gelb") && (farbe1 == "rot" || farbe2 == "rot"))
                Console.WriteLine("{0} + {1} = orange", farbe1, farbe2);

            else
                Console.WriteLine("Ungültige Eingabe!");

        }
    }
}
