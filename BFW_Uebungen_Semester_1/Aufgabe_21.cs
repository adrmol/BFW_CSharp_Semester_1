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
            int summe = 0;

            //Solange nicht später "n" geantwortet wird, wird diese Schleife ausgeführt.
            while (userentscheidung == true)

            {
                bool userinputrichtig = false;

                //Usereingabe
                Console.WriteLine("Bitte geben Sie eine Zahl ein:");

                //falls eine Zahl korrekt eingegeben wurde, wird das Array um eins erweitert und die Eingabe an letzter Stelle gespeichert.
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    int i = 0;
                    int[] tempArr = new int[array.Length + 1];
                    for (int j = 0; j < array.Length; j++)
                        tempArr[j] = array[j];
                    array = tempArr;
                    array[i] = input;
                    i++;

                }

                //Schleife läuft solange bis "y" oder "n" eingegeben wurde.
                while (!userinputrichtig)
                {
                    Console.WriteLine("Soll noch eine Zahl eingegeben werden? (y/n)");

                    switch (Console.ReadLine())
                    {
                        //Wenn "n" dann gehen wir aus den beiden Schleifen raus.
                        case "n":
                            userentscheidung = false;
                            userinputrichtig = true;
                            break;

                        //Wenn "y" dann gehen wir nur aus der y/n Schleife raus und gehen zurück zur Zahleingabe.
                        case "y":
                            userinputrichtig = true;
                            break;

                        //Falls weder "y" oder "n" eingegeben wurde, wird immer wieder nach "y" und "n" gefragt.
                        default:
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

            //Array Inhalt ausgeben zum überprüfen.

            //Console.WriteLine("\nArray:");
            //foreach (int k in array)
            //{
            //    Console.WriteLine(k);
            //}
        }

    }
}
