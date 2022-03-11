using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    internal class Aufgabe_A1x
    {

        public static void Start()
        {

            bool farbefalsch;
            string farbe1;
            string farbe2;

            Console.WriteLine("Bitte geben Sie zwei Grundfarben (blau, gelb, rot) an:\nErster Farbe:");


            //Eingabe wird solange wiederholt bis eine richtige Grundfarbe eingegeben wurde.
            do
            {

                farbe1 = Console.ReadLine().Trim().ToLower();                                   //Farbe wird in Kleinbuchstaben gespeichert. Führende und folgende Leerzeichen werden entfernt.
                farbefalsch = (farbe1 != "blau" && farbe1 != "gelb" && farbe1 != "rot");          //Test ob die Eingabe einer Grundfarbe enspricht.
                if (farbefalsch == true)
                    Console.WriteLine("Bitte geben Sie eine korrekte Grundfarbe an:");          //Falls keine korrekte Farbe eingeben wurde, wird nochmal gefragt.

            }
            while (farbefalsch);

            Console.WriteLine("Zweite Farbe:");


            //Eingabe wird solange wiederholt bis eine richtige zweite Grundfarbe eingegeben wurde.
            do
            {

                farbe2 = Console.ReadLine().Trim().ToLower();                                    //Farbe wird in Kleinbuchstaben gespeichert. Führende und folgende Leerzeichen werden entfernt.
                farbefalsch = (farbe2 != "blau" && farbe2 != "gelb" && farbe2 != "rot");           //Test ob die Eingabe einer Grundfarbe enspricht.
                if (farbefalsch == true)
                    Console.WriteLine("Bitte geben Sie eine korrekte zweite Grundfarbe an:");    //Falls keine korrekte Farbe eingeben wurde, wird nochmal gefragt.

            }
            while (farbefalsch);



            if (farbe1 == farbe2)                                                   //Wenn beide Farben gleich sind ist die Mischfarbe einfach die gleiche die eingegeben wurde.
                Console.WriteLine("{0} + {1} = {2}", farbe1, farbe2, farbe1);
            else                                                                    //Es wird auf die Kombination getestet und die jeweils richtige Mischfarbe ausgeben.
            {
                if (farbe1 == "blau" | farbe2 == "blau")                            //Wenn eine der Farben blau ist, dann kann es nur noch lila oder grün sein.
                {
                    if (farbe1 == "gelb" | farbe2 == "gelb")                        //Wenn die zweite Farbe gelb ist, dann kommt grün raus.
                        Console.WriteLine("{0} + {1} = grün", farbe1, farbe2);      
                    else                                                            //Wenn die zweite Farbe nicht gelb ist, dann kommt lila raus.
                        Console.WriteLine("{0} + {1} = lila", farbe1, farbe2);      
                }
                else                                                                //Wenn keine der eingegebenen Farben blau ist, dann muss orange rauskommen.
                {
                    Console.WriteLine("{0} + {1} = orange", farbe1, farbe2);
                }
            }
        }
    }
}