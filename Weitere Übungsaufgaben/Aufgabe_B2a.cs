using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_B2a
    {

        public static void Start()
        {

            Console.WriteLine("Eingabe:");
            string eingabe = Console.ReadLine();
            string verkuerzteeingabe = "";
            int anzahl = 0;
            int i;

            for (i = 1; i < eingabe.Length; i++)
            {

                if (eingabe.Substring(i - 1, 1) == eingabe.Substring(i, 1))
                    anzahl++;

                else
                {

                    anzahl++;
                    verkuerzteeingabe += "%" + anzahl + "%" + eingabe.Substring(i - 1, 1);
                    anzahl = 0;

                }

            }

            anzahl++;
            if (eingabe.Length > 0) 
                verkuerzteeingabe += "%" + anzahl + "%" + eingabe.Substring(i - 1, 1) + "%";
            else
                Console.WriteLine("Keine Angabe! Schade!");

            Console.WriteLine("Verkürzte Form: " + verkuerzteeingabe);
            Console.WriteLine("\nSoll die verkürzte Form wieder ausgeführt werden? Wenn ja, drücken Sie die 1.");
            if (Console.ReadLine() == "1")
            {
                string ausgabe = "";
                bool zahl = true;
                string tempAnzahl = "";
                int tempAnzahlZahl = 0;

                for (int j = 1; j < verkuerzteeingabe.Length; j++)
                {
                    if (verkuerzteeingabe.Substring(j, 1) == "%")
                    {

                        zahl = !zahl;
                        tempAnzahlZahl = Convert.ToInt32(tempAnzahl);
                        if (zahl == true)
                            tempAnzahl = "";

                    }
                    else if (zahl)
                    {

                        tempAnzahl += verkuerzteeingabe.Substring(j, 1);

                    }
                    else
                    {
                        for (int k = 0; k < tempAnzahlZahl; k++)
                            ausgabe += verkuerzteeingabe.Substring(j, 1);

                    }

                }
                Console.WriteLine(ausgabe);
            }
            else
                Console.WriteLine("Tschüss!");
        }
    }
}
