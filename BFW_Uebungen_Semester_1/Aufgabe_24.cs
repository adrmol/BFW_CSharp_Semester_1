using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_24
    {
        public static void Speichern(ref int[] array, int input)
        {
            int[] tempArr = new int[array.Length + 1];
            for (int j = 0; j < array.Length; j++)
                tempArr[j] = array[j];
            array = tempArr;
            array[array.Length-1] = input;
        }

        public static void Einfuegen(ref int[] array, int input, int platz)
        {
            if (platz < array.Length && platz > 0)
            {
                int[] tempArr = new int[array.Length + 1];

                for (int j = 0; j < platz - 1; j++)
                    tempArr[j] = array[j];

                tempArr[platz - 1] = input;

                for (int j = platz; j < tempArr.Length; j++)
                    tempArr[j] = array[j - 1];
                array = tempArr;
            }
            else
                Console.WriteLine("\nPlatz nicht vorhanden!\n");
        }

        public static void Loeschen(ref int[] array, int platz)
        {
            if (platz < array.Length && platz > 0)
            {
                int[] tempArr = new int[array.Length - 1];

                for (int j = 0; j < platz; j++)
                    tempArr[j] = array[j];

                for (int j = platz - 1; j < tempArr.Length; j++)
                    tempArr[j] = array[j + 1];
                array = tempArr;
            }
            else
                Console.WriteLine("\nPlatz nicht vorhanden!\n");
        }

        public static void Verdoppeln(ref int[] array, int platz)
        {
            if (platz < array.Length && platz > 0)
                array[platz - 1] *= 2;
            else
                Console.WriteLine("\nPlatz nicht vorhanden!\n");
        }

        public static void Halbieren(ref int[] array, int platz)
        {
            if (platz < array.Length && platz > 0)
                array[platz - 1] /= 2;
            else
                Console.WriteLine("\nPlatz nicht vorhanden!\n");
        }

        public static void Anzeigen(ref int[] array)
        {
            int arrayplatzausgabe = 0;
            Console.WriteLine();
            foreach (int i in array)
                Console.WriteLine("Array[{0}]: {1}", arrayplatzausgabe++, i);
            Console.WriteLine();
        }


        public static void Start()
        {
            int [] array1 = new int [5] {0, 1, 2, 3, 4};
            int input;
            int platz;

            while (true)
            {
                
                Console.Write("Was wollen Sie mit dem Array tun?\nSpeichern\t[1]\nEinfügen\t[2]\nLöschen\t\t[3]\nVerdoppeln\t[4]\nHalbieren\t[5]\nAnzeigen\t[6]\n\nEingabe: ");
                switch (Console.ReadLine())
                {
                    
                    case "1":
                        Console.WriteLine("\nSpeichern:\nWelche Zahl soll gespeichert werden?");
                        if (int.TryParse(Console.ReadLine(), out input))
                            Speichern(ref array1, input);
                        break;

                    case "2":
                        Console.WriteLine("\nEinfügen:\nWelche Zahl soll eingefügt werden?");
                        if (int.TryParse(Console.ReadLine(), out input))
                        {
                            Console.WriteLine("An welcher Stelle?");
                            if (int.TryParse(Console.ReadLine(), out platz))
                                Einfuegen(ref array1, input, platz);
                        }
                        break;

                    case "3":
                        Console.WriteLine("\nLoeschen:\nWelche Stelle soll gelöscht werden?");
                        if (int.TryParse(Console.ReadLine(), out platz))
                            Loeschen(ref array1, platz);
                        break;

                    case "4":
                        Console.WriteLine("\nVerdoppeln:\nWelche Stelle soll verdoppelt werden?");
                        if (int.TryParse(Console.ReadLine(), out platz))
                            Verdoppeln(ref array1, platz);
                        break;

                    case "5":
                        Console.WriteLine("\nLoeschen:\nWelche Stelle soll halbiert werden?");
                        if (int.TryParse(Console.ReadLine(), out platz))
                            Halbieren(ref array1, platz);
                        break;

                    case "6":
                            Anzeigen(ref array1);
                        break;

                    default:
                        break;

                }


            }
        }

    }
}
