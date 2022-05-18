using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    internal class Aufgabe_B2bv2
    {
        public static void Start()
        {
            string entscheidung, eingabe, ausgabe = "";
            int anzahl_Chars;

            Console.WriteLine("Komprimieren(1) oder Ausschreiben(2)?");
            entscheidung = Console.ReadLine();

            Console.WriteLine("Eingabe:");
            eingabe = Console.ReadLine();

            switch (entscheidung)
            {
                case "1":
                    //eingabe = "WWWWW%%%%DDDDD\\\\\\\\\\\\SSSSSS11";
                    eingabe += '\0';
                    anzahl_Chars = 1;
                    for (int i = 0; i < eingabe.Length - 1; i++)
                    {
                        if (eingabe[i] == eingabe[i + 1])
                            anzahl_Chars++;
                        else
                        {
                            if (eingabe[i] == '%' || eingabe[i] == '\\')
                                ausgabe += "%" + anzahl_Chars + "%\\" + eingabe[i];
                            else
                                ausgabe += "%" + anzahl_Chars + "%" + eingabe[i];
                            anzahl_Chars = 1;
                        }
                    }

                    Console.WriteLine("Komprimierte Form: " + ausgabe);
                    break;

                case "2":
                    //eingabe = "%5%W%4%\\%%5%D%6%\\\\%6%S%2%1";
                    bool zahl = true;
                    anzahl_Chars = 0;
                    for (int i = 1; i < eingabe.Length; i++)
                    {
                        if (zahl)
                        {
                            if (eingabe[i] == '%')
                                zahl = false;
                            else
                            {
                                anzahl_Chars *= 10;
                                anzahl_Chars += eingabe[i] - '0';
                            }
                        }
                        else
                        {
                            if (eingabe[i] == '\\' && eingabe[i - 1] != '\\')
                                i++;
                            for (int j = 0; j < anzahl_Chars; j++)
                                ausgabe += eingabe[i];
                            zahl = true;
                            anzahl_Chars = 0;
                            i++;
                        }
                    }

                    Console.WriteLine("Ausgeschriebene Form: " + ausgabe);
                    break;
            }
        }
    }
}
