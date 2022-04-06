using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_19b
    {
        public static void Start()
        {
            int[] array = new int[4] { 70, 30, 89, 13 };
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("Möchten Sie ein Element hinzufügen (1), die Liste ausgeben (2) oder die Liste leeren (3)?");

                switch (Console.ReadLine())
                {

                    case "1":
                        Console.WriteLine("Bitte Element zum Hinzufügen eingeben:");

                        if (int.TryParse(Console.ReadLine(), out int input))
                        {
                            int[] tempArr = new int[array.Length + 1];
                            for (int i = 0; i < array.Length; i++)
                                tempArr[i] = array[i];
                            tempArr[array.Length] = input;
                            array = tempArr;
                        }
                        break;

                    case "2":
                        Console.WriteLine("Array:");

                        if (array.Length == 0)
                        {
                            Console.WriteLine("leer");
                        }
                        else
                        {
                            for (int i = 0; i < array.Length; i++)
                                Console.WriteLine(array[i]);
                        }
                        break;

                    case "3":
                        array = new int[0];
                        break;

                    default:
                        loop = false;
                        break;
                }
            }
        }
    }
}
