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
            int inteingabe;
            int i = 0;

            Console.Clear();

            do
            {
                Console.WriteLine("Geben Sie eine Zahl ein die in die Liste kommen soll oder geben Sie \"ende\" ein");
                string eingabe = Console.ReadLine().Trim().ToLower();
                if (eingabe == "ende")
                    break;
                if (!int.TryParse(eingabe, out inteingabe))
                    continue;
                Array.Resize(ref array1, array1.Length + 1);
                for (i = 0; i < array1.Length; i++)
                {
                    if (array1[i] > inteingabe)
                    {
                        int temp1 = array1[i];
                        array1[i] = inteingabe;
                        array1[i + 1] = temp1;
                    }
                }
            } while (true);
        }
    }
}
