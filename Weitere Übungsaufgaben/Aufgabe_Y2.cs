using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_Y2
    {

        public static void Start()
        {
            int[] array1 = new int[0];

            Console.WriteLine("Geben Sie ein Wort ein:");

            string eingabeWort = Console.ReadLine();

            Console.WriteLine("Geben Sie eine oder mehrere Zahl ein:");

            do
            {
                if (int.TryParse(Console.ReadLine(), out int i) && eingabeWort.Length >= i)
                {
                    Array.Resize(ref array1, array1.Length + 1);
                    array1[^1] = i - 1;
                } else
                {
                    break;
                }

            } while (true);

            for (int i = 0; i < array1.Length; i++)
            {
                string tempWort = "";
                for (int j = 0; j < eingabeWort.Length; j++)
                {
                    if (array1[i] == j)
                    {
                        if (Char.IsUpper(eingabeWort[j]))
                            tempWort += eingabeWort[j].ToString().ToLower();
                        else
                            tempWort += eingabeWort[j].ToString().ToUpper();
                    }
                    else
                        tempWort += eingabeWort[j].ToString();

                }
                eingabeWort = tempWort;
            }

            Console.WriteLine(eingabeWort);
        }

    }
}
