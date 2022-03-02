using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_10
    {
        public static void Start()
        {

            //Usereingabe.
            Console.WriteLine("Bitte geben Sie einen String ein:");
            string str1 = Console.ReadLine();

            //Leerzeichen entfernen.
            str1 = str1.Trim();

            //Länge ausgeben.
            int a = str1.Length;
            Console.WriteLine("Länge: " + a);

            //Ersten Buchstaben in Groß ausgeben.
            string str2 = str1.ToUpper();
            Console.WriteLine("Erster Buchstabe: " + str2[0]);

            //Letzten Buchstaben in Groß ausgeben.
            Console.WriteLine("Letzter Buchstabe: " + str2[a-1]);

        }
    }
}
