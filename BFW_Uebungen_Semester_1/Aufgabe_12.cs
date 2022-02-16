using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_12
    {
        public static void Start()
        {

            int[] intarray1 = new int[4] { 70, 30, 89, 13 };
            int a = 0;
            int b = 0;

            //Wert an 3.Stelle wird ersetz
            intarray1[2] = 110;

            //Zu dem letzten Element wird 17 addiert
            intarray1[intarray1.Length - 1] = intarray1[intarray1.Length - 1] + 17;

            //foreach Schleife um alle Elemente durch 5 zu teilen
            foreach (int i in intarray1)
            {
                intarray1[a] /= 5;
                a++;
            }

            //Array wird auf 6 erweitert
            Array.Resize(ref intarray1, 6);

            //Werte werden an 5. und 6. Stelle eingesetzt
            intarray1[4] = 200;
            intarray1[5] = 500;

            //foreach Schleife um alle Elemente mal 2 zu nehmen
            foreach (int i in intarray1)
            {
                intarray1[b] *= 2;
                b++;
            }

            //Ausgabe
            Console.WriteLine("Erstes Element: " + intarray1[0].ToString());
            Console.WriteLine("Zweites Element: " + intarray1[1].ToString());
            Console.WriteLine("Drittes Element: " + intarray1[2].ToString());
            Console.WriteLine("Viertes Element: " + intarray1[3].ToString());
            Console.WriteLine("Fünftes Element: " + intarray1[4].ToString());
            Console.WriteLine("Sechstes Element: " + intarray1[5].ToString());
        }
    }
}
