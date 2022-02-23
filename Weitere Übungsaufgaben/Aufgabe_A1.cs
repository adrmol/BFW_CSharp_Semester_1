using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    internal class Aufgabe_A1
    {

        public static void Start()
        {

            bool farbefalsch = false;
            string farbe1;
            string farbe2;
            Console.WriteLine("Bitte geben Sie zwei Grundfarben (blau, gelb, rot) an:\nErster Farbe:");

            //Eingabe wird solange wiederholt bis eine richtige Grundfarbe eingegeben wurde.
            do
            {
                
                farbe1 = Console.ReadLine().ToLower();  //Farbe wird in kleinbuchstaben gespeichert.
                farbefalsch = !(farbe1 == "blau" | farbe1 == "gelb" | farbe1 == "rot"); //Test ob die Eingabe einer Grundfarbe enspricht.
                if (farbefalsch == true)
                    Console.WriteLine("Bitte geben Sie eine korrekte Grundfarbe an:");  //Falls keine korrekte Farbe eingeben wurde, wird nochmal gefragt.

            }
            while (farbefalsch);

            Console.WriteLine("Zweite Farbe:");

            //Eingabe wird solange wiederholt bis eine richtige zweite Grundfarbe eingegeben wurde.
            do
            {

                farbe2 = Console.ReadLine().ToLower();  //Farbe wird in kleinbuchstaben gespeichert.
                farbefalsch = !(farbe2 == "blau" | farbe2 == "gelb" | farbe2 == "rot" & farbe2 != farbe1); //Test ob die Eingabe einer Grundfarbe enspricht und nicht die erste Farbe ist.
                if (farbefalsch == true)
                    Console.WriteLine("Bitte geben Sie eine korrekte zweite oder andere zweite Grundfarbe an:");    //Falls keine korrekte Farbe eingeben wurde, wird nochmal gefragt.

            }
            while (farbefalsch);


            //Es wird auf die Kombination getestet und die jeweils richtige Mischfarbe ausgeben.
            if (farbe1 == "blau" | farbe2 == "blau")
            {
                if (farbe1 == "gelb" | farbe2 == "gelb")
                {
                    Console.WriteLine("{0} + {1} = grün", farbe1, farbe2);
                }
                else
                {
                    Console.WriteLine("{0} + {1} = lila", farbe1, farbe2);
                }
            }
            else
            {
                Console.WriteLine("{0} + {1} = orange", farbe1, farbe2);
            }

        }

    }
}
