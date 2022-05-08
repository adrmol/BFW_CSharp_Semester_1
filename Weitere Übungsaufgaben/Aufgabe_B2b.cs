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
            string verkuerzteeingabe = "";
            int anzahl = 0;
            int i;

            try
            {
                if (eingabe.Length > 0 && !(eingabe[0] == '%' && int.TryParse(eingabe.Substring(1, 1), out int useless)))
                {
                    for (i = 1; i < eingabe.Length; i++)
                        if (eingabe.Substring(i - 1, 1) == eingabe.Substring(i, 1))
                            anzahl++;
                        else
                        {
                            anzahl++;
                            if (eingabe[i - 1] == '%' || eingabe[i - 1] == '\\')
                                verkuerzteeingabe += "%" + anzahl + "%\\" + eingabe.Substring(i - 1, 1);
                            else
                                verkuerzteeingabe += "%" + anzahl + "%" + eingabe.Substring(i - 1, 1);
                            anzahl = 0;
                        }

                    anzahl++;
                    verkuerzteeingabe += "%" + anzahl + "%" + eingabe.Substring(i - 1, 1) + "%";
                    Console.WriteLine("Verkürzte Form: " + verkuerzteeingabe);
                }
                else if (eingabe.Length > 0 && (eingabe[0] == '%' && int.TryParse(eingabe.Substring(1, 1), out useless)))
                {
                    string ausgabe = "";
                    bool zahl = true;
                    string tempAnzahl = "";
                    int tempAnzahlZahl = 0;

                    for (int j = 1; j < eingabe.Length; j++)
                        if (eingabe.Substring(j, 1) == "%")
                        {
                            zahl = !zahl;
                            tempAnzahlZahl = Convert.ToInt32(tempAnzahl);
                            if (zahl == true)
                                tempAnzahl = "";
                        }
                        else if (zahl)
                            tempAnzahl += eingabe.Substring(j, 1);
                        else
                            if (eingabe.Substring(j, 1) == "\\")
                            {
                                for (int k = 0; k < tempAnzahlZahl; k++)
                                    ausgabe += eingabe.Substring(j + 1, 1);
                                j++;
                            }
                            else
                                for (int k = 0; k < tempAnzahlZahl; k++)
                                    ausgabe += eingabe.Substring(j, 1);
                        
                    Console.WriteLine("Verlängerte Form: " + ausgabe);
                }
                else
                    Console.WriteLine("Keine Eingabe!");

                Console.WriteLine("Tschüss!");
            }
            catch
            {
                Console.WriteLine("Ungültige Angabe! Bitte halten Sie die Regeln für die verkürzte oder verlängerte Form ein!");
            }

        }
    }
}
