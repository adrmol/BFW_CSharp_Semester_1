using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    internal class Aufgabe_B2bv2
    {
        public static void Start()
        {
            string entscheidung, eingabe, anzahl_Chars_String = "", ausgabe = "";
            int anzahl_Chars = 1;
            bool zahl = true;

            Console.WriteLine("Komprimieren(1) oder Ausschreiben(2)?");
            entscheidung = Console.ReadLine();

            Console.WriteLine("Eingabe:");
            //eingabe = Console.ReadLine();

            switch (entscheidung)
            {
                case "1":
                    eingabe = "WWWWW%%%%DDDDD\\\\\\\\\\\\SSSSSS11";
                    for (int i = 1; i < eingabe.Length; i++)
                    {
                        if (i == eingabe.Length - 1)
                            anzahl_Chars++;
                        if (eingabe[i] == eingabe[i - 1] && i != eingabe.Length - 1)
                            anzahl_Chars++;
                        else
                        {
                            if (eingabe[i - 1] == '%' || eingabe[i - 1] == '\\')
                                ausgabe += "%" + anzahl_Chars + "%\\" + eingabe[i - 1];
                            else
                                ausgabe += "%" + anzahl_Chars + "%" + eingabe[i - 1];
                            anzahl_Chars = 1;
                        }
                    }

                    Console.WriteLine("Komprimierte Form: " + ausgabe);
                    break;

                case "2":
                    eingabe = "%5%W%4%\\%%5%D%6%\\\\%6%S%2%1";
                    for (int i = 1; i < eingabe.Length; i++)
                    {
                        if (zahl)
                        {
                            if (eingabe[i] == '%')
                            {
                                zahl = false;
                                continue;
                            }
                            anzahl_Chars_String += eingabe[i];
                        }
                        else
                        {
                            if (eingabe[i] == '\\')
                                i++;
                            anzahl_Chars = Convert.ToInt32(anzahl_Chars_String);
                            for (int j = 0; j < anzahl_Chars; j++)
                                ausgabe += eingabe[i];
                            zahl = true;
                            anzahl_Chars_String = "";
                            i++;
                        }
                    }

                    Console.WriteLine("Ausgeschriebene Form: " + ausgabe);
                    break;
            }
        }
    }
}
