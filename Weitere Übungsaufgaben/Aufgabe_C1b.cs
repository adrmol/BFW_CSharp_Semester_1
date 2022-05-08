using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_C1b
    {
        public static void Start()
        {

            decimal zahl;
            decimal ergebnis = 0;
            int umrechnungrichtung;
            string einheit1 = "";
            string einheit2 = "";
            bool korrekteeingabe = true;

            do
                Console.WriteLine("Wie sol umgerechnet werden?:\nCelsius zu Kelvin\t[1]\tKelvin zu Celsius\t[2]\nPS in kW\t\t[3]\tkw in PS\t\t[4]\nKalorien in Joule\t[5]\tJoule in Kalorien\t[6]\nDollar in Euro\t\t[7]\tEuro in Dollar\t\t[8]\n");
            while (!int.TryParse(Console.ReadLine(), out umrechnungrichtung) || umrechnungrichtung < 1 || umrechnungrichtung > 8);

            do
            {
                Console.WriteLine("Welche Zahl soll umgerechnet werden?");
                if (decimal.TryParse(Console.ReadLine(), out zahl))
                {
                    switch (umrechnungrichtung)
                    {

                        case 1:
                            if (zahl < -273.15M)
                            {
                                Console.WriteLine("Ungültiger Wert! Es kann nicht kälter als 273,15°C sein!");
                                break;
                            }
                            ergebnis = zahl + 273.15M;
                            einheit1 = "Celsius";
                            einheit2 = "Kelvin";
                            korrekteeingabe = false;
                            break;

                        case 2:
                            if (zahl < 0)
                            {
                                Console.WriteLine("Ungültiger Wert! Kelvin kann nicht negativ sein!");
                                break;
                            }
                            ergebnis = zahl - 273.15M;
                            einheit1 = "Kelvin";
                            einheit2 = "Celsius";
                            korrekteeingabe = false;
                            break;

                        case 3:
                            ergebnis = zahl * 0.7355M;
                            einheit1 = "PS";
                            einheit2 = "kW";
                            korrekteeingabe = false;
                            break;

                        case 4:
                            ergebnis = zahl * 1.35962M;
                            einheit1 = "kW";
                            einheit2 = "PS";
                            korrekteeingabe = false;
                            break;

                        case 5:
                            ergebnis = zahl * 4.1867M;
                            einheit1 = "Kalorien";
                            einheit2 = "Joule";
                            korrekteeingabe = false;
                            break;

                        case 6:
                            ergebnis = zahl * 0.23885M;
                            einheit1 = "Joule";
                            einheit2 = "Kalorien";
                            korrekteeingabe = false;
                            break;

                        case 7:
                            if (zahl < 0)
                            {
                                Console.WriteLine("Ungültiger Wert! Dollar kann nicht negativ sein!");
                                break;
                            }
                            ergebnis = zahl * 0.89M;
                            einheit1 = "Dollar";
                            einheit2 = "Euro";
                            korrekteeingabe = false;
                            break;

                        case 8:
                            if (zahl < 0)
                            {
                                Console.WriteLine("Ungültiger Wert! Euro kann nicht negativ sein!");
                                break;
                            }
                            ergebnis = zahl * 1.13M;
                            einheit1 = "Euro";
                            einheit2 = "Dollar";
                            korrekteeingabe = false;
                            break;
                    }
                }
            } while (korrekteeingabe);

            Console.WriteLine("{0} {1} sind {2} {3}", zahl, einheit1, ergebnis, einheit2);

        }
    }
}
