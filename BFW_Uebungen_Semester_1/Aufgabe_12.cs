using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_12 //und Aufgabe 13
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
            //Array.Resize(ref intarray1, 6); - nicht im Skript.
            //Arrays erweitern: Skript Seite 145
            int[] tempArr = new int[intarray1.Length + 2]; //Die "2" gibt an dass die neue Länge um 2 größer ist.
            for (int i = 0; i < intarray1.Length; i++)
                tempArr[i] = intarray1[i];
            intarray1 = tempArr;

            //Werte werden an der 5. und 6. Stelle eingesetzt
            intarray1[4] = 200;
            intarray1[5] = 500;

            //foreach Schleife um alle Elemente mal 2 zu nehmen
            foreach (int i in intarray1)
            {
                intarray1[b] *= 2;
                b++;
            }

            //Ausgabe
            Console.WriteLine("Erstes Element: " + intarray1[0]);
            Console.WriteLine("Zweites Element: " + intarray1[1]);
            Console.WriteLine("Drittes Element: " + intarray1[2]);
            Console.WriteLine("Viertes Element: " + intarray1[3]);
            Console.WriteLine("Fünftes Element: " + intarray1[4]);
            Console.WriteLine("Sechstes Element: " + intarray1[5]);
        }
    }
}
