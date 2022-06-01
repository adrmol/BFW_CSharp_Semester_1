﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_C3a
    {
        public static void Start()
        {
            int fib1 = 0;
            int fib2 = 1;
            int eingabeuser;
            int tempfib;
            string todo;

            do
            {
                Console.WriteLine("Gib Fibonacci-Zahlen aus bis\t\t\t[1]\nTeste ob die Zahl eine Fibonacci-Zahl ist\t[2]");
                todo = Console.ReadLine();
            } while (!(todo == "1" || todo == "2"));

            switch (todo)
            {
                case "1":
                    do
                        Console.WriteLine("Bitte geben Sie an, bis zu welcher Zahl die Fibonacci-Zahlen ausgegeben werden:");
                    while (!int.TryParse(Console.ReadLine(), out eingabeuser) || eingabeuser < 1);
                    
                    Console.WriteLine();

                    do
                    {
                        Console.WriteLine(fib2);
                        tempfib = fib2;
                        fib2 += fib1;
                        fib1 = tempfib;
                    } while (fib2 <= eingabeuser);

                    if (fib2 < eingabeuser)
                        Console.WriteLine(fib2);
                    break;

                case "2":
                    do
                        Console.WriteLine("Bitte geben Sie an, welche Zahl getestet werden soll, ob sie eine Fibonacci-Zahl ist:");
                    while (!int.TryParse(Console.ReadLine(), out eingabeuser) || eingabeuser < 1);

                    do
                    {
                        tempfib = fib2;
                        fib2 += fib1;
                        fib1 = tempfib;
                    } while (fib2 <= eingabeuser);
                    
                    if (fib1 == eingabeuser || fib2 == eingabeuser)
                        Console.WriteLine("{0} ist eine Fibonacci-Zahl!", eingabeuser);
                    else
                        Console.WriteLine("{0} ist keine Fibonacci-Zahl!", eingabeuser);
                    break;
            }
        }
    }
}
