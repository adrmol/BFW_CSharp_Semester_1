using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_19
    {


        public static void Start()
        {
            //Array mit Größe 5.
            int[] array1 = new int[5];

            //if Kurzschreibweise.
            //Wenn "int.TryParse(Console.ReadLine())" true ist, d.h. die Eingabe lässt sich in eine Zahl umwandeln (int),
            //      dann wird die Eingabe in "num" gespeichert und gleichzeitig die Variable "num" in das Array eingespeichert 
            //      (nach dem Fragezeichen, dann steht quasi "array[0] = num;"
            //Wenn "int.TryParse(Console.ReadLine())" false ist, dann bleibt "num" leer und es wird -1 zurückgegeben.
            //      (nach dem Doppelpunkt, dann steht quasi "array[0] = -1;"

            Console.WriteLine("Bitte geben Sie die 1. Zahl ein");
            array1[0] = int.TryParse(Console.ReadLine(), out int num) ? num : -1;

            Console.WriteLine("Bitte geben Sie die 2. Zahl ein");
            array1[1] = int.TryParse(Console.ReadLine(), out num) ? num : -1;

            Console.WriteLine("Bitte geben Sie die 3. Zahl ein");
            array1[2] = int.TryParse(Console.ReadLine(), out num) ? num : -1;

            Console.WriteLine("Bitte geben Sie die 4. Zahl ein");
            array1[3] = int.TryParse(Console.ReadLine(), out num) ? num : -1;

            Console.WriteLine("Bitte geben Sie die 5. Zahl ein");
            array1[4] = int.TryParse(Console.ReadLine(), out num) ? num : -1;

            int summe = 0;

            //Der erste Wert mit den verglichen werden soll ist der erste Wert im Array (array1[0]).
            int kzahl = array1[0];
            int gzahl = array1[0];

            //Man geht schrittweise durch das Array durch und vergleicht die jeweilige Stelle mit der kleinsten Zahl (kzahl) und der größten Zahl (gzahl).
            //kzahl/gzahl sind immer die kleinste/größte Zahl die man geprüft hat.
            for (int i = 1; i < array1.Length; i++)
            {
                summe += array1[i]; //summe
                //if Kurzschreibweise.
                kzahl = kzahl > array1[i] ? array1[i] : kzahl; //kleinste Zahl
                gzahl = gzahl < array1[i] ? array1[i] : gzahl; //größte Zahl
            }


            //double für Mittelwert mit Nachkommastellen.
            double summeDouble = summe;

            Console.WriteLine("Die Summe der Zahlen ist " + summe);
            Console.WriteLine("Die kleinste Zahl ist " + kzahl);
            Console.WriteLine("Die größte Zahl ist " + gzahl);
            Console.WriteLine("Der Mittelwert ist " + summeDouble / array1.Length);
            
        }
    }
}
