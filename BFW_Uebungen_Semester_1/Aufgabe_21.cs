using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_21
    {
        public static void Start()
        {
            int[] array = new int[0];
            bool loop = true, loop2;
            int summe = 0;

            while (loop)
            {
                loop2 = true;

                Console.WriteLine("Bitte geben Sie eine Zahl ein:");

                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    int[] tempArr = new int[array.Length + 1];
                    for (int i = 0; i < array.Length; i++)
                        tempArr[i] = array[i];
                    array = tempArr;
                    array[array.Length - 1] = input; 
                }

                Console.WriteLine("Soll noch eine Zahl eingegeben werden? (y/n)");

                while (loop2)
                {
                    switch (Console.ReadLine().Trim().ToLower())
                    {
                        case "n":
                            loop = false;
                            loop2 = false;
                            break;

                        case "y":
                            loop2 = false;
                            break;
                    }
                }
            }

            Console.WriteLine("\nIhr Ergebnis:");

            foreach (var zahl in array)
                Console.WriteLine(summe += zahl);
        }
    }
}
