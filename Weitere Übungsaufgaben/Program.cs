using System;

namespace Weitere_Übungsaufgaben
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welche Aufgabe soll ausgeführt werden?\nVerfügbare Aufgaben: [A1, A2, A3, B1, B2a, Y1];\nProgramm schließen: exit");
                switch (Console.ReadLine().ToLower())
                {

                    case "a1":
                        Console.WriteLine("Aufgabe A1:\n");
                        Aufgabe_A1.Start();
                        break;

                    case "a2":
                        Console.WriteLine("Aufgabe A2:\n");
                        Aufgabe_A2.Start();
                        break;

                    case "a3":
                        Console.WriteLine("Aufgabe A3:\n");
                        Aufgabe_A3.Start();
                        break;

                    case "b1":
                        Console.WriteLine("Aufgabe B1:\n");
                        Aufgabe_B1.Start();
                        break;

                    case "b2a":
                        Console.WriteLine("Aufgabe B2a:\n");
                        Aufgabe_B2a.Start();
                        break;

                    case "y1":
                        Console.WriteLine("Aufgabe Y1:\n");
                        Aufgabe_Y1.Start();
                        break;

                    case "exit":
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
