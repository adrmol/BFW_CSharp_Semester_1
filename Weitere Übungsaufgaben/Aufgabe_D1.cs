using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_D1
    {
        public static void Start()
        {
            string todo;
            string strhoehe;
            string strlaenge;

            do
            {
                Console.WriteLine("Von was soll der Flächeninhalt berechnet werden?\n[1]\tRechteck\n[2]\tDreieck\n[3]\tKreis");
                todo = Console.ReadLine();
            } while (!(todo == "1" || todo == "2" || todo == "3"));

            switch (todo)
            {
                case "1":
                    double rehoehe;
                    double relaenge;
                    do
                    {
                        Console.Write("Höhe: ");
                        strhoehe = Console.ReadLine();
                    } while (!double.TryParse(strhoehe, out rehoehe) || rehoehe <= 0);

                    do
                    {
                        Console.Write("Länge: ");
                        strlaenge = Console.ReadLine();
                    } while (!double.TryParse(strlaenge, out relaenge) || relaenge <= 0);

                    Console.WriteLine("Flächeninhalt: " + rehoehe * relaenge);
                    break;

                case "2":
                    double radius;
                    
                    do
                    {
                        Console.Write("Höhe: ");
                        strhoehe = Console.ReadLine();
                    } while (!double.TryParse(strhoehe, out radius) || radius <= 0);
                    Console.WriteLine("Flächeninhalt: " + radius * radius * Math.PI);
                    break;

                case "3":
                    double drhoehe;
                    double drlaenge;
                    do
                    {
                        Console.Write("Höhe: ");
                        strhoehe = Console.ReadLine();
                    } while (!double.TryParse(strhoehe, out drhoehe) || drhoehe <= 0);

                    do
                    {
                        Console.Write("Länge: ");
                        strlaenge = Console.ReadLine();
                    } while (!double.TryParse(strlaenge, out drlaenge) || drlaenge <= 0);

                    Console.WriteLine("Flächeninhalt: " + drhoehe * drlaenge / 2);
                    break;

            }
        }
    }
}
