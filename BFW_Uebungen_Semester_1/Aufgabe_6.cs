using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_6
    {
        public static void Start()
        {

            int var1 = 160;
            int var2 = 20;
            int res;
            string a = "Hallo!";
            string b = "Hier kommt das Ergebnis:";

            res = (var1/var2/2*var2-var1+3*var2) % 27;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(res);
            Console.WriteLine();

            int var3 = 3600;
            int var4 = 360;
            int res2;

            res2 = (var3 / var4 / 2 * var4 - var3 + 3 * var4) % 27;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(res2);


        }
    }
}
