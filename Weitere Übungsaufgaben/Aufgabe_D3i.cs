using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_D3i
    {
        public static void Start()
        {
            int[] array1 = new int[0];
            Console.Clear();

            do
            {
                Console.WriteLine("\nGeben Sie eine Zahl ein die in die Liste kommen soll oder geben Sie \"ende\" ein");
                string eingabe = Console.ReadLine().Trim().ToLower();
                if (eingabe == "ende")
                    break;
                if (!int.TryParse(eingabe, out int inteingabe))
                    continue;
                Array.Resize(ref array1, array1.Length + 1);

                array1[array1.Length - 1] = int.MaxValue;

                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] > inteingabe && array1[i] != int.MaxValue)
                    {
                        int temp1 = array1[i];
                        array1[i] = inteingabe;
                        inteingabe = temp1;
                    }
                    else if (array1[i] == int.MaxValue)
                        array1[i] = inteingabe;
                }

                foreach (int ausgabe in array1)
                    Console.Write(ausgabe + " ");

            } while (true);
        }
    }
}
