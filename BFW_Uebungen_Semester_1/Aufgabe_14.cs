using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_14
    {
        public static void Start()
        {

            //Usereingabe
            Console.WriteLine("Hallo! Geben Sie eine Zahl ein:");

            //Kovertierung in einen int
            int a = Convert.ToInt32(Console.ReadLine());

            //Prüfen ob die Zahl gerade ist mit modulo
            if ((a % 2) == 0)
            {
                Console.WriteLine("Die Zahl ist gerade!");
            }
            else
            {
                Console.WriteLine("Die Zahl ist ungerade!");
            }

            //Prüfen ob die Zahl größer als 100 ist
            if (a > 100)
            {
                Console.WriteLine("Die Zahl ist größer als 100!");
            }
            else
            {
                Console.WriteLine("Die Zahl ist nicht größer als 100!");
            }

            //Prüfen ob die Zahl durch 7 teilbar ist mit modulo
            if ((a % 7) == 0)
            {
                Console.WriteLine("Die Zahl ist durch 7 teilbar!");
            }
            else
            {
                Console.WriteLine("Die Zahl ist nicht durch 7 teilbar!");
            }

            //Prüfen ob die Zahl weniger 3, gleich 3 oder mehr als 3 Stellen hat
            if (a.ToString().Length > 3)
            {
                Console.WriteLine("Die Zahl hat mehr als 3 Stellen!");
            }
            else if (a.ToString().Length == 3)
            {
                Console.WriteLine("Die Zahl hat 3 Stellen!");
            }
            else
            {
                Console.WriteLine("Die Zahl hat weniger als 3 Stellen!");
            }
        }
    }
}
