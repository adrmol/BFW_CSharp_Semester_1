using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_B2b
    {

        public static void Start()
        {

            Console.WriteLine("Eingabe:");
            string eingabe = Console.ReadLine().Trim();

            if (!(eingabe[0] == '%' && int.TryParse(eingabe.Substring(1, 1), out _)))
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

                    if (eingabe.Substring(i, 1) != eingabe.Substring(i + 1, 1))
                    {
                        if (eingabe[i] == '%' || eingabe[i + 1] == '\\')
                            verkuerzteEingabe += "%" + anzahl + "%\\" + eingabe.Substring(i, 1);
                        else
                            verkuerzteEingabe += "%" + anzahl + "%" + eingabe.Substring(i, 1);
                        anzahl = 0;
                    }
                }
            }
            else if (eingabe[0] == '%' && int.TryParse(eingabe.Substring(1, 1), out _))
            {
                string ausgabe = "";
                bool zahl = true;
                string tempAnzahlString = "";
                int tempAnzahl = 0;

                for (int i = 1; i < eingabe.Length; i++)
                {
                    if (eingabe.Substring(i, 1) == "%")
                    {
                        zahl = !zahl;
                        tempAnzahl = Convert.ToInt32(tempAnzahlString);
                        if (zahl)
                            tempAnzahlString = "";
                    }
                    else if (zahl)
                        tempAnzahlString += eingabe.Substring(i, 1);
                    else
                        if (eingabe.Substring(i, 1) == "\\")
                    {
                        for (int k = 0; k < tempAnzahl; k++)
                            ausgabe += eingabe.Substring(i + 1, 1);
                        i++;
                    }
                    else
                        for (int k = 0; k < tempAnzahl; k++)
                            ausgabe += eingabe.Substring(i, 1);
                }
                Console.WriteLine("Verlängerte Form: " + ausgabe);
            }
            Console.WriteLine("Tschüss!");
        }
    }
}
