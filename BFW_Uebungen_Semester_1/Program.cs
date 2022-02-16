﻿using System;
using System.Threading;

namespace BFW_Uebungen_Semester_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Welche Aufgabe soll ausgeführt werden?\nVerfügbare Aufgaben: [3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 14, 15, 15b, 18];\nProgramm schließen: exit");
                switch (Console.ReadLine())
                {

                    case "3":
                        Console.WriteLine("Aufgabe 3:\n");
                        Aufgabe_3.Start();
                        break;

                    case "4":
                        Console.WriteLine("Aufgabe 4:\n");
                        Aufgabe_4.Start();
                        break;

                    case "5":
                        Console.WriteLine("Aufgabe 5:\n");
                        Aufgabe_5.Start();
                        break;

                    case "6":
                        Console.WriteLine("Aufgabe 6:\n");
                        Aufgabe_6.Start();
                        break;

                    case "7":
                        Console.WriteLine("Aufgabe 7:\n");
                        Aufgabe_7.Start();
                        break;

                    case "8":
                        Console.WriteLine("Aufgabe 8:\n");
                        Aufgabe_8.Start();
                        break;

                    case "10":
                        Console.WriteLine("Aufgabe 10:\n");
                        Aufgabe_10.Start();
                        break;

                    case "11":
                        Console.WriteLine("Aufgabe 11:\n");
                        Aufgabe_11.Start();
                        break;

                    case "12":
                        Console.WriteLine("Aufgabe 12:\n");
                        Aufgabe_12.Start();
                        break;

                    case "14":
                        Console.WriteLine("Aufgabe 14:\n");
                        Aufgabe_14.Start();
                        break;

                    case "15":
                        Console.WriteLine("Aufgabe 15:\n");
                        Aufgabe_15.Start();
                        break;

                    case "15b":
                        Console.WriteLine("Aufgabe 15b:\n");
                        Aufgabe_15b.Start();
                        break;
                    case "18":
                        Console.WriteLine("Aufgabe 18:\n");
                        Aufgabe_18.Start();
                        break;

                    case "19":
                        Console.WriteLine("Aufgabe 19:\n");
                        Aufgabe_19.Start();
                        break;

                    case "exit":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Aufgabe nicht gefunden!\n");
                        break;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
