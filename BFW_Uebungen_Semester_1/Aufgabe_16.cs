using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_16
    {
        public static void Start()
        {
            int i, j;
            Console.WriteLine("Hallo! Bitte Eingabe tätigen:");
            string eingabe = Console.ReadLine();
            if (int.TryParse(eingabe, out i))
                i %= 10;
            else
                i = eingabe.Length * 2 % 10;

            i++;

            Console.WriteLine("Bitte weitere Eingabe tätigen:");
            string eingabe2 = Console.ReadLine();

            if (int.TryParse(eingabe2, out j))
                j *= 3;
            else
                j = eingabe2.Length * 5 % 100;

            Console.Clear();
            Console.WriteLine("Das Ergebnis ist: {0} / {1} = {2}", j, i, j / i);
        }
    }
}
