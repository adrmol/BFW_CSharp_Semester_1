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
            array1[0] = Conv();
            Console.WriteLine("Bitte geben Sie die 2. Zahl ein");
            array1[1] = Conv();
            Console.WriteLine("Bitte geben Sie die 3. Zahl ein");
            array1[2] = Conv();
            Console.WriteLine("Bitte geben Sie die 4. Zahl ein");
            array1[3] = Conv();
            Console.WriteLine("Bitte geben Sie die 5. Zahl ein");
            array1[4] = Conv();

            int summe = 0;
            int kzahl = array1[0];
            int gzahl = array1[0];
            for (int i = 0; i < array1.Length; i++)
            {
                summe += array1[i]; //summe
                kzahl = kzahl > array1[i] ? array1[i] : kzahl; //kleinste Zahl
                gzahl = gzahl < array1[i] ? array1[i] : gzahl; //größte Zahl
            }

            double summeDouble = summe;

            Console.WriteLine("Die Summe der Zahlen ist " + summe);
            Console.WriteLine("Die kleinste Zahl ist " + kzahl);
            Console.WriteLine("Die größte Zahl ist " + gzahl);
            Console.WriteLine("Der Mittelwert ist " + summeDouble / array1.Length);
            
        }

        static int Conv()
        {
            string input1 = Console.ReadLine();
            int a = int.TryParse(input1, out int num) ? num : -1;
            return a;
        }
    }
}
