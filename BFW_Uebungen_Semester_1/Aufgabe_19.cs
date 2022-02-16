using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_19
    {


        public static void Start()
        {

            int[] array1 = new int[5];
            Console.WriteLine("Bitte geben Sie die 1. Zahl ein");
            array1[0] = conv();
            Console.WriteLine("Bitte geben Sie die 2. Zahl ein");
            array1[1] = conv();
            Console.WriteLine("Bitte geben Sie die 3. Zahl ein");
            array1[2] = conv();
            Console.WriteLine("Bitte geben Sie die 4. Zahl ein");
            array1[3] = conv();
            Console.WriteLine("Bitte geben Sie die 5. Zahl ein");
            array1[4] = conv();

            int summe = 0;
            int kzahl = array1[0];
            for (int i = 0; i < 5; i++)
            {
                summe += array1[i]; //summe
                kzahl = kzahl > array1[i] ? kzahl = array1[i] : kzahl; //kleinste Zahl

            }

            Console.WriteLine("Die Summe der Zahlen ist " + summe);
            Console.WriteLine("Die kleinste Zahl ist " + kzahl);

        }

        static int conv()
        {
            string input1 = Console.ReadLine();
            int a = int.TryParse(input1, out int num) ? num : -1;
            return a;
        }
    }
}
