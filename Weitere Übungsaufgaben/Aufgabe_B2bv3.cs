using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Weitere_Übungsaufgaben
{
    internal class Aufgabe_B2bv3
    {
        public static void Start()
        {
            char seperator;

            Console.WriteLine("Komprimieren(1) oder Ausschreiben(2)?");
            string entscheidung = Console.ReadLine();

            Console.WriteLine("Eingabe:");
            string eingabe = Console.ReadLine();

            switch (entscheidung)
            {
                case "1":
                    //eingabe = "WWWWW%%%%DDDDD\\\\\\\\\\\\SSSSSS11";
                    Console.WriteLine("Seperator:");
                    seperator = Console.ReadLine()[0];
                    var regex1 = new Regex(@"(.)\1*");
                    string output1 = String.Join("", regex1.Matches(eingabe).Select(x => String.Format("{0}{1}{0}{2}", seperator, x.Value.Length, x.Value.First())));
                    Console.WriteLine("Komprimierte Form: " + output1.Replace("\\", "\\\\").Replace(String.Format("{0}{0}{0}", seperator), String.Format("{0}\\{0}{0}", seperator)));
                    break;

                case "2":
                    //eingabe = "%55%W%4%\\%%5%D%6%\\\\%6%S%2%1";
                    //var regex2 = new Regex(@"[%][0-9]+[%][\\]?.");
                    seperator = eingabe[0];
                    var regex2 = new Regex(seperator + @"[0-9]+" + seperator + @"[\\]?.");
                    var regex3 = new Regex(@"[0-9]+");
                    string output2 = String.Join("", regex2.Matches(eingabe).Select(x => new string(x.Value.ElementAt(x.Length - 1), Convert.ToInt32(String.Join("", regex3.Matches(x.Value.Substring(1, x.Length - 3)).Select(y => y.Value))))));
                    Console.WriteLine("Ausgeschriebene Form: " + output2);
                    break;
            }
        }
    }
}