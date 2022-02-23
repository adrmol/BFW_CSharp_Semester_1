using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_A3
    {

        public static void Start()
        {

            int richtig = 0;
            int falsch = 0;

            Console.WriteLine("Wie viel ist 1 + 1?");
            Console.WriteLine("a) 1\tb) 2\nc) 3\td) 4\n");

            if (Console.ReadLine() == "b")
            {
                Console.WriteLine("\nRichtig!\n");
                richtig++;
            }
            else
            {
                Console.WriteLine("\nFalsch! Richtige Antwort ist b\n");
                falsch++;
            }

            Console.WriteLine("Wie viel ist 2 + 2?");
            Console.WriteLine("a) 1\tb) 4\nc) 3\td) 2\n");

            if (Console.ReadLine() == "b")
            {
                Console.WriteLine("\nRichtig!\n");
                richtig++;
            }
            else
            {
                Console.WriteLine("\nFalsch! Richtige Antwort ist b\n");
                falsch++;
            }

            Console.WriteLine("Wie viel ist 3 + 3?");
            Console.WriteLine("a) 1\tb) 6\nc) 3\td) 4\n");

            if (Console.ReadLine() == "b")
            {
                Console.WriteLine("\nRichtig!\n");
                richtig++;
            }
            else
            {
                Console.WriteLine("\nFalsch! Richtige Antwort ist b\n");
                falsch++;
            }

            Console.WriteLine("Wie viel ist 4 + 4?");
            Console.WriteLine("a) 1\tb) 8\nc) 3\td) 4\n");

            if (Console.ReadLine() == "b")
            {
                Console.WriteLine("\nRichtig!\n");
                richtig++;
            }
            else
            {
                Console.WriteLine("\nFalsch! Richtige Antwort ist b\n");
                falsch++;
            }

            Console.WriteLine("Wie viel ist 5 + 5?");
            Console.WriteLine("a) 1\tb) 10\nc) 3\td) 4\n");

            if (Console.ReadLine() == "b")
            {
                Console.WriteLine("\nRichtig!\n");
                richtig++;
            }
            else
            {
                Console.WriteLine("\nFalsch! Richtige Antwort ist b\n");
                falsch++;
            }

            Console.WriteLine("Anzahl der richtigen Antworten: " + richtig);
            Console.WriteLine("Anzahl der falschen Antworten: " + falsch);
        }
    }
}
