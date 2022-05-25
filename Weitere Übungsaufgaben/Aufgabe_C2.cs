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
            double[] rezept = new double[6] { 50, 25, 0.2, 15, 0.4, 0.2 };
            int i = 0, a = 0;

            do
            {
                Console.Write("Wie viel Gramm Mehl ist vorhanden? Mehl in g: ");
            } while (!double.TryParse(Console.ReadLine(), out vorhandeneZutaten[i]));
            i++;

            do
            {
                Console.Write("Wie viel Gramm Butter ist vorhanden? Butter in g: ");
            } while (!double.TryParse(Console.ReadLine(), out vorhandeneZutaten[i]));
            i++;

            do
            {
                Console.Write("Wie viele Eier sind vorhanden? Anzahl Eier: ");
            } while (!double.TryParse(Console.ReadLine(), out vorhandeneZutaten[i]));
            i++;

            do
            {
                Console.Write("Wie viel Gramm Zucker ist vorhanden? Zucker in g: ");
            } while (!double.TryParse(Console.ReadLine(), out vorhandeneZutaten[i]));
            i++;

            do
            {
                Console.Write("Wie viel Packungen Vanillazucker ist vorhanden? Anzahl Vaniallazuckerpackungen: ");
            } while (!double.TryParse(Console.ReadLine(), out vorhandeneZutaten[i]));
            i++;

            do
            {
                Console.Write("Wie viel Prisen Salz (1g) sind vorhanden? Salz in g: ");
            } while (!double.TryParse(Console.ReadLine(), out vorhandeneZutaten[i]));

            foreach (int j in vorhandeneZutaten)
                vorhandeneZutaten[a] /= rezept[a++];

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
