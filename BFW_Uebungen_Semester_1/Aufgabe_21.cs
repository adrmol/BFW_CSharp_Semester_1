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
            bool userentscheidung = true;
            int i = 0;
            int summe = 0;

            while (userentscheidung == true)

            {
                string userinput = "0";
                Console.WriteLine("Bitte geben Sie eine Zahl ein:");

                if (int.TryParse(Console.ReadLine(), out int input))
                {

                    int[] tempArr = new int[array.Length + 1];
                    for (int j = 0; j < array.Length; j++)
                        tempArr[j] = array[j];
                    array = tempArr;
                    array[i] = input;
                    i++;

                }
                while (userinput.Equals("0"))
                {
                    Console.WriteLine("Soll noch eine Zahl eingegeben werden? (y/n)");

                    switch (Console.ReadLine())
                    {

                        case "n":
                            userentscheidung = false;
                            userinput = "1";
                            break;

                        case "y":
                            userinput = "1";
                            break;

                        default:
                            break;
                    }
                }

            }

            Console.WriteLine("\nIhr Ergebnis:");
            foreach (int k in array)
            {
                Console.WriteLine(summe += k);
            }

            Console.WriteLine("\nArray:");
            foreach (int k in array)
            {
                Console.WriteLine(k);
            }
        }

    }
}
