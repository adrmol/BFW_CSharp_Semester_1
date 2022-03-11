using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_15b
    {
        public static void Start()
        {
            Console.WriteLine("Warte auf Input...\n");
            Console.WriteLine(long.TryParse(Console.ReadLine(), out long num) ? num % 2 == 0 ? "Der eingegebene Wert \"" + num + "\" ist eine Zahl und die Hälfte ist " + num / 2 + "." : "Der eingegebene Wert \"" + num + "\" ist eine Zahl und die Hälfte ist " + num / 2 + " mit dem Rest " + num % 2 + "." : input1.Length % 2 == 0 ? "Der eingegebene Wert \"" + input1 + "\" ist ein String und die Hälfte ist \"" + input1.Substring(0, input1.Length / 2) + "\" und \"" + input1.Substring(input1.Length / 2, input1.Length / 2) + "\"." : "Der eingegebene Wert \"" + input1 + "\" ist ein String und die Hälfte ist \"" + input1.Substring(0, input1.Length / 2) + "\" und \"" + input1.Substring(input1.Length / 2 + 1, input1.Length / 2) + "\" mit dem mittleren Buchstaben \"" + input1.Substring(input1.Length / 2, 1) + "\".");
        }
    }
}
