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

            if (eingabe[0] != '%')  //verkürzen
            {
                string verkuerzteEingabe = "";
                int anzahl = 0;

                for (int i = 0; i < eingabe.Length; i++)
                {
                    anzahl++;

                    if (i == eingabe.Length - 1)    //für das letzte Element (sonst läuft i außerhalb des strings)
                    {
                        verkuerzteEingabe += "%" + anzahl + "%" + eingabe.Substring(i, 1) + "%";
                        Console.WriteLine("Verkürzte Form: " + verkuerzteEingabe);
                        break;
                    }

                    if (eingabe.Substring(i, 1) != eingabe.Substring(i + 1, 1)) //für alle anderen Elemente
                    {
                        verkuerzteEingabe += "%" + anzahl + "%" + eingabe.Substring(i, 1);
                        anzahl = 0;
                    }
                }
            }
            else if (eingabe[0] == '%') //ausschreiben
            {
                string ausgabe = "";
                bool zahl = true;
                int tempAnzahl;
                string tempAnzahlString = "";

                for (int i = 1; i < eingabe.Length; i++)
                    if (eingabe.Substring(i, 1) == "%")
                        zahl = !zahl;
                    else if (zahl)
                        tempAnzahlString += eingabe.Substring(i, 1);
                    else
                    {
                        tempAnzahl = Convert.ToInt32(tempAnzahlString);
                        for (int k = 0; k < tempAnzahl; k++)
                            ausgabe += eingabe.Substring(i, 1);
                    }

                Console.WriteLine("Verlängerte Form: " + ausgabe);
            }

            Console.WriteLine("Tschüss!");
        }
    }
}
