using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_8
    {
        public static void Start()
        {
            string inputString = " werPolizeidjsue ";

            //Leerzeichen entfernen
            inputString = inputString.Trim();
            Console.WriteLine(inputString);

            //Länge ausgeben
            int a = inputString.Length;
            Console.WriteLine("Anzahl: " + a);

            //Nur "Polizei" ausgeben
            inputString = inputString.Substring(3, 7);
            Console.WriteLine(inputString);

            //Polizei in Großbuchstaben ausgeben
            inputString = inputString.ToUpper();
            Console.WriteLine(inputString);
        }
    }
}
