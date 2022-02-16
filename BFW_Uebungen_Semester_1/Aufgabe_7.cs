using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_7
    {
        public static void Start()
        {

            string str1 = "wie";
            string str2 = "dir";
            string str3 = "es";
            string str4 = "Danke";
            string str5 = "Hallo";
            string str6 = "geht";
            string str7 = "gut";
            string str8 = "mir";

            string res1 = string.Format("{0} {1} {2} {3} {4}?", str5, str1, str6, str3, str2);
            string res2 = string.Format("{0}, {1} {2} {3} {4}!", str4, str3, str6, str8, str7);

            Console.WriteLine(res1);
            Console.WriteLine(res2);
        }
    }
}
