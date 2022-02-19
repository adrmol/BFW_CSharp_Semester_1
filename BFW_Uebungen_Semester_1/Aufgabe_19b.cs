using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_19b
    {
        public static void Hinzufuegen(ref int[] array)
        {
            if (int.TryParse(Console.ReadLine(), out int input))
            {
                int[] tempArr = new int[array.Length + 1];
                for (int i = 0; i < array.Length; i++)
                    tempArr[i] = array[i];
                tempArr[array.Length] = input;
                array = tempArr;
            }
        }

        public static void Leeren(ref int[] array)
        {
            int[] tempArr = new int[array.Length];
            array = tempArr;

        }

        public static void Ausgeben(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }

        public static void Start()
        {
            int[] array = new int[4] { 70, 30, 89, 13 };
            while (true)
            {
                Console.WriteLine("Möchten Sie ein Element hinzufügen (1), die Liste ausgeben (2) oder die Liste leeren (3)?");
                switch (Console.ReadLine())
                {

                    case "1":
                        Console.WriteLine("Bitte Element zum hinzufügen angeben:");
                        Hinzufuegen(ref array);
                        break;

                    case "2":
                        Console.WriteLine("Array:");
                        Ausgeben(array);
                        break;

                    case "3":
                        Leeren(ref array);
                        break;

                    default:
                        break;
                }
            }
        }

    }
}
