using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_20
    {
        public static void Start()
        {
            int[] arr = new int[9] { 34, 5, 83, 28, 44, 99, 30, 72, 28 };
            foreach (int i in arr)
            {
                Console.WriteLine("Die Zahl: " + i );
                Console.WriteLine("Die Hälfte: " + i / 2);
                Console.WriteLine("Das Doppelte: " + i * 2);
                Console.WriteLine();
            }
        }
    }
}
