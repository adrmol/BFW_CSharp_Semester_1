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
                    double rechteck_hoehe;
                    double rechteck_laenge;

                    do
                    {
                        Console.Write("Höhe: ");
                        strhoehe = Console.ReadLine();
                    } while (!double.TryParse(strhoehe, out rechteck_hoehe) || rechteck_hoehe <= 0);

                    do
                    {
                        Console.Write("Länge: ");
                        strlaenge = Console.ReadLine();
                    } while (!double.TryParse(strlaenge, out rechteck_laenge) || rechteck_laenge <= 0);

                    Console.WriteLine("Flächeninhalt: " + rechteck_hoehe * rechteck_laenge);
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
                    double dreieck_laenge;
                    double dreieck_hoehe;

                    do
                    {
                        Console.Write("Höhe: ");
                        strhoehe = Console.ReadLine();
                    } while (!double.TryParse(strhoehe, out dreieck_hoehe) || dreieck_hoehe <= 0);

                    do
                    {
                        Console.Write("Länge: ");
                        strlaenge = Console.ReadLine();
                    } while (!double.TryParse(strlaenge, out dreieck_laenge) || dreieck_laenge <= 0);

                    Console.WriteLine("Flächeninhalt: " + dreieck_hoehe * dreieck_laenge / 2);
                    break;

            }
        }
    }
}
