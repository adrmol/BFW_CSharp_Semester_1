using System;

namespace Weitere_Übungsaufgaben
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welche Aufgabe soll ausgeführt werden?\nVerfügbare Aufgaben: [A1, A1x, A2, A3, B1, B2a, B2b, C1a, C1b, C2, D2, D3b, X1, X2, X2new, X3, X3i, X3new, Y1];\nProgramm schließen: exit");
                switch (Console.ReadLine().ToLower())
                {
                    case "a1":
                        Console.WriteLine("Aufgabe A1:\n");
                        Aufgabe_A1.Start();
                        break;

                    case "a1x":
                        Console.WriteLine("Aufgabe A1x:\n");
                        Aufgabe_A1x.Start();
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

                    case "b2b":
                        Console.WriteLine("Aufgabe B2b:\n");
                        Aufgabe_B2b.Start();
                        break;

                    case "c1a":
                        Console.WriteLine("Aufgabe C1a:\n");
                        Aufgabe_C1a.Start();
                        break;

                    case "c1b":
                        Console.WriteLine("Aufgabe C1b:\n");
                        Aufgabe_C1b.Start();
                        break;

                    case "c2":
                        Console.WriteLine("Aufgabe C2:\n");
                        Aufgabe_C2.Start();
                        break;

                    case "d2":
                        Console.WriteLine("Aufgabe D2:\n");
                        Aufgabe_D2.Start();
                        break;

                    case "d3b":
                        Console.WriteLine("Aufgabe D3b:\n");
                        Aufgabe_D3b.Start();
                        break;

                    case "d3i":
                        Console.WriteLine("Aufgabe D3i:\n");
                        Aufgabe_D3i.Start();
                        break;

                    case "y1":
                        Console.WriteLine("Aufgabe Y1:\n");
                        Aufgabe_Y1.Start();
                        break;

                    case "x1":
                        Console.WriteLine("Aufgabe X1:\n");
                        Aufgabe_X1 aufgabe_X1 = new Aufgabe_X1();
                        aufgabe_X1.Start();
                        break;

                    case "x2":
                        Console.WriteLine("Aufgabe X2:\n");
                        Aufgabe_X2.Start();
                        break;

                    case "x2new":
                        Console.WriteLine("Aufgabe X2new:\n");
                        Aufgabe_X2new.Start();
                        break;

                    case "x3":
                        Console.WriteLine("Aufgabe X3:\n");
                        Aufgabe_X3 aufgabe_X3 = new Aufgabe_X3();
                        aufgabe_X3.Start();
                        break;

                    case "x3i":
                        Console.WriteLine("Aufgabe X3i:\n");
                        Aufgabe_X3i.Start();
                        break;

                    case "x3new":
                        Console.WriteLine("Aufgabe X3new:\n");
                        Aufgabe_X3new.Start();
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
