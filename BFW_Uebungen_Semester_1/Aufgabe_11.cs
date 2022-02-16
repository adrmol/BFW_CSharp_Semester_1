using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_11
    {
        public static void Start()
        {

            //Usereingabe
            Console.WriteLine("Bitte geben Sie eine Zahl ein: ");

            //Kovertierung in einen int
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            //Ausgabe
            Console.WriteLine("Ihre eingegebene Zahl: " + a);
            Console.WriteLine("Das ist das Doppelte: " + a*2);
            Console.WriteLine("Das ist die Hälfte: " + a/2);
            Console.WriteLine("Das ist der Rest bei der Teilung durch 7: " + a%7);


        }
    }
}
