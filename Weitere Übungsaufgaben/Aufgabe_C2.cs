using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_C2
    {

        public static void Start()
        {

            double[] vorhandeneZutaten = new double[6];
            double[] rezept = new double[] { 50, 25, 0.2, 15, 0.4, 0.2 };
            int indexEingaben = 0;

            do
            {
                Console.Write("Wie viel Gramm Mehl ist vorhanden? Mehl in g: ");
            } while (!double.TryParse(Console.ReadLine(), out vorhandeneZutaten[indexEingaben]));
            indexEingaben++;

            do
            {
                Console.Write("Wie viel Gramm Butter ist vorhanden? Butter in g: ");
            } while (!double.TryParse(Console.ReadLine(), out vorhandeneZutaten[indexEingaben]));
            indexEingaben++;

            do
            {
                Console.Write("Wie viele Eier sind vorhanden? Anzahl Eier: ");
            } while (!double.TryParse(Console.ReadLine(), out vorhandeneZutaten[indexEingaben]));
            indexEingaben++;

            do
            {
                Console.Write("Wie viel Gramm Zucker ist vorhanden? Zucker in g: ");
            } while (!double.TryParse(Console.ReadLine(), out vorhandeneZutaten[indexEingaben]));
            indexEingaben++;

            do
            {
                Console.Write("Wie viel Packungen Vanillazucker ist vorhanden? Anzahl Vaniallazuckerpackungen: ");
            } while (!double.TryParse(Console.ReadLine(), out vorhandeneZutaten[indexEingaben]));
            indexEingaben++;

            do
            {
                Console.Write("Wie viel Prisen Salz (1g) sind vorhanden? Salz in g: ");
            } while (!double.TryParse(Console.ReadLine(), out vorhandeneZutaten[indexEingaben]));

            for (int i = 0; i < vorhandeneZutaten.Length; i++)
                vorhandeneZutaten[i] /= rezept[i];

            double kzahl = vorhandeneZutaten[0];

            foreach (int k in vorhandeneZutaten)
                if (kzahl > k)
                    kzahl = k;

            switch (kzahl)
            {
                case 0:
                    Console.WriteLine("Es können keine Kekse gebacken werden!");
                    break;

                case 1:
                    Console.WriteLine("Es kann ein Keks gebacken werden!");
                    break;

                default:
                    Console.WriteLine("Es können {0} Kekse gebacken werden!", kzahl);
                    break;
            }
        }
    }
}
