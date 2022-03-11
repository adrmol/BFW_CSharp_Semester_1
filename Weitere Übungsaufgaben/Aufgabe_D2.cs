﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_D2
    {
        public static void NewSpielfeld(ref int[] feld)
        {

            feld = new int[20];

            var rand = new Random();
            int fregatte = rand.Next(0, 18);
            feld[fregatte] = 1;
            feld[fregatte + 1] = 1;
            feld[fregatte + 2] = 1;

            do
            {
                int schnellboot = rand.Next(0, 19);
                if (feld[schnellboot] != 1 && feld[schnellboot + 1] != 1 && !(schnellboot != 0 && !(feld[schnellboot - 1] != 1)) && !(schnellboot != 18 && !(feld[schnellboot + 2] != 1)))
                {
                    feld[schnellboot] = 1;
                    feld[schnellboot + 1] = 1;
                    break;
                }
            } while (true);

            do
            {
                int segelboot = rand.Next(0, 20);
                if (feld[segelboot] != 1 && !(segelboot != 0 && !(feld[segelboot - 1] != 1)) && !(segelboot != 19 && !(feld[segelboot + 1] != 1)))
                {
                    feld[segelboot] = 1;
                    break;
                }
            } while (true);

        }
        public static void Start()
        {
            
            int[] spieler = new int[0];
            int spielerschuss;
            int anzahlschuesse = 0;
            int trefferanzahl = 0;
            bool a;

            NewSpielfeld(ref spieler);

            /*
            Console.Clear();
            for (int i = 1; i < spieler.Length / 2; i++)
                Console.Write(" {0}  ", i);
            for (int i = 10; i <= spieler.Length; i++)
                Console.Write(" {0} ", i);
            Console.WriteLine();
            for (int i = 0; i < spieler.Length; i++)
            {
                if (spieler[i] == 0)
                    Console.Write(" O  ");
                else if (spieler[i] == 1)
                    Console.Write(" X  ");
            }
            */

            do
            {

                Console.Clear();
                for (int i = 1; i < spieler.Length / 2; i++)
                    Console.Write(" {0}  ", i);
                for (int i = 10; i <= spieler.Length; i++)
                    Console.Write(" {0} ", i);
                Console.WriteLine();
                for (int i = 0; i < spieler.Length; i++)
                {
                    if (spieler[i] == 0 || spieler[i] == 1)
                        Console.Write(" O  ");
                    else if (spieler[i] == 2)
                        Console.Write(" X  ");
                    else if (spieler[i] == 3)
                        Console.Write(" $  ");

                }


                do
                {
                    Console.WriteLine("\nBitte geben Sie an welches Feld beschossen werden soll!");
                    a = int.TryParse(Console.ReadLine(), out spielerschuss);
                    a = !(spielerschuss >= 1 && spielerschuss <= 20);
                    if (a == true)
                        Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 20 an:");
                }
                while (a);

                anzahlschuesse++;
                spielerschuss--;

                if (spieler[spielerschuss] == 1)
                {
                    Console.WriteLine("Treffer!");
                    spieler[spielerschuss] = 2;
                    trefferanzahl++;
                }
                else if (spieler[spielerschuss] == 0)
                {
                    Console.WriteLine("Fehlschuss!");
                    spieler[spielerschuss] = 3;
                }


            } while (trefferanzahl < 6);

            Console.Clear();
            for (int i = 1; i < spieler.Length / 2; i++)
                Console.Write(" {0}  ", i);
            for (int i = 10; i <= spieler.Length; i++)
                Console.Write(" {0} ", i);
            Console.WriteLine();
            for (int i = 0; i < spieler.Length; i++)
            {
                if (spieler[i] == 0 || spieler[i] == 1)
                    Console.Write(" O  ");
                else if (spieler[i] == 2)
                    Console.Write(" X  ");
                else if (spieler[i] == 3)
                    Console.Write(" $  ");
            }
            Console.WriteLine("\nTreffer!");
            Console.WriteLine("Sieg! Anzahl der abgegebenen Schüsse: " + (anzahlschuesse));
        }
    }
}
