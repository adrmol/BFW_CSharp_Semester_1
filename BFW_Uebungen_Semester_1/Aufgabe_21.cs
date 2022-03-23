using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_21
    {
        public static void Start()
        {
            int[] array = new int[0];
            bool userentscheidung = true;
            bool userinputrichtig;
            int summe = 0;

            //Solange nicht später "n" geantwortet wird, wird diese Schleife ausgeführt.
            while (userentscheidung)
            {
                userinputrichtig = false;

                //Usereingabe
                Console.WriteLine("Bitte geben Sie eine Zahl ein:");

                //falls eine Zahl korrekt eingegeben wurde, wird das Array um eins erweitert und die Eingabe an letzter Stelle gespeichert.
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    int[] tempArr = new int[array.Length + 1];
                    for (int i = 0; i < array.Length; i++)
                        tempArr[i] = array[i];
                    array = tempArr;
                    array[^1] = input;
                }

                //Schleife läuft solange bis "y" oder "n" eingegeben wurde.
                while (!userinputrichtig)
                {
                    userinputrichtig = true;
                    Console.WriteLine("Soll noch eine Zahl eingegeben werden? (y/n)");

                    switch (Console.ReadLine().Trim().ToLower())
                    {
                        //Wenn "n" dann gehen wir aus den beiden Schleifen raus.
                        case "n":
                            userentscheidung = false;
                            break;

                        //Wenn "y" dann gehen wir nur aus der y/n Schleife raus und gehen zurück zur Zahleingabe.
                        case "y":
                            break;

                        default:
                            userinputrichtig = false;
                            break;
                    }
                }

            }

            //Ausgabe aller Werte im Array (kumulativ).
            Console.WriteLine("\nIhr Ergebnis:");
            foreach (int k in array)
            {
                Console.WriteLine(summe += k);
            }

            //array inhalt ausgeben zum überprüfen.

            //console.writeline("\narray:");
            //foreach (int k in array)
            //{
            //    console.writeline(k);
            //}
        }

    }
}
