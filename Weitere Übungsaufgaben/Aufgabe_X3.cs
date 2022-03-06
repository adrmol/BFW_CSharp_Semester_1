using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_X3
    {

        int[] primzahlen = new int[1] {2};
        int[] zahlenfolge = new int[0];
        int[] primzahlenrueckwaerts = new int[0];
        //int[] mirprimzahlen = new int[0];

        int zahlenfolgegroeße = 2;
        int primzahlengroeße = 1;
        int primzahlaufzaehlung = 1;
        int primzahlenrueckwaertsaufzaehlung = 0;
        int mirpirmzahlenaufzaehlung = 0;
        //int stellemirpzahl = 1;


        public void ArrayExpand(ref int[] array)
        {
            /*
             * int[] tempArr = new int[array.Length + 1];
             * for (int i = 0; i < array.Length; i++)
             *   tempArr[i] = array[i];
             * array = tempArr;
             */
            Array.Resize(ref array, array.Length + 1);
        }

        public void PrimzahlenExpandZuZahl(int bisZahl)
        {
            do
            {
                ZahlenfolgeExpand();
                if (TestaufPrimzahl(zahlenfolge[zahlenfolgegroeße-3]))
                {
                    ArrayExpand(ref primzahlen);
                    primzahlen[primzahlengroeße] = zahlenfolge[zahlenfolgegroeße - 3];
                    primzahlengroeße++;
                }
            } while (primzahlen.Length == 0 || primzahlen[primzahlen.Length - 1] < bisZahl);
        }

        public void PrimzahlenExpandUm1()
        {
            while (true)
            {
                ZahlenfolgeExpand();
                if (TestaufPrimzahl(zahlenfolge[zahlenfolgegroeße - 3]))
                {
                    ArrayExpand(ref primzahlen);
                    primzahlen[primzahlengroeße] = zahlenfolge[zahlenfolgegroeße - 3];
                    primzahlengroeße++;
                    break;
                }
            }
        }

        public bool TestaufPrimzahl(int zahl)
        {
            foreach (int i in primzahlen)
            {
                if (i * i <= zahl)
                {
                    if (zahl % i == 0)
                        return false;
                } 
            }
            return true;
        }

        public bool IstZahlInPrimzahlVorhanden (int zahl)
        {
            foreach (int i in primzahlen)
            {
                if (zahl == i)
                {
                    return true;
                }
            }
            return false;
        }

        public void ZahlenfolgeExpand()
        {
            ArrayExpand(ref zahlenfolge);
            zahlenfolge[zahlenfolgegroeße - 2] = zahlenfolgegroeße;
            ++zahlenfolgegroeße;
        }

        public int ReverseZahl(int primzahl)
        {
            string tempk = primzahl.ToString();
            string tempk2 = "";
            for (int j = 1; j <= tempk.Length; j++)
                tempk2 += tempk.Substring(tempk.Length - j, 1);
            int tempkINT = Convert.ToInt32(tempk2);
            return tempkINT;
        }

        public void Start()
        {
            int eingabeuser;

            do
                Console.WriteLine("Bitte geben Sie an, wie viele Mirpzahlen ausgegeben werden:");
            while (!int.TryParse(Console.ReadLine(), out eingabeuser) || eingabeuser < 1);

            do
            {

                if (primzahlen.Length <= primzahlaufzaehlung)
                    PrimzahlenExpandUm1();


                /* 
                 * Wenn die umgedrehte Primzahl nicht die gleiche ist, wird sie in die Liste primzahlenrueckwaerts eingetragen
                 * und sie wird auf eine Mirpzahl geprüft
                 */
                if ((ReverseZahl(primzahlen[primzahlaufzaehlung])) != primzahlen[primzahlaufzaehlung])
                {
                    ArrayExpand(ref primzahlenrueckwaerts);
                    primzahlenrueckwaerts[primzahlenrueckwaertsaufzaehlung] = ReverseZahl(primzahlen[primzahlaufzaehlung]);
                    primzahlenrueckwaertsaufzaehlung++;


                    //Dieser Teil wird erst ausgeführt wenn wir mindesten eine PrimzahlRueckwaerts haben
                    if (primzahlenrueckwaerts.Length > 0)
                    {
                        /*
                         * Um Rechenzeit zu sparen wird nicht geschaut ob die PrimzahlRueckwaerts durch alle kleineren Primzahlen teilbar ist,
                         * sondern es wird die vorhandene Primzahl Liste erweitert bis der letzte Wert größer gleich der PrimzahlRueckwaerts ist
                         * und dann wird geschaut ob PrimzahlRueckwaerts teil der Primzahl Liste ist
                         */

                        PrimzahlenExpandZuZahl(primzahlenrueckwaerts[primzahlenrueckwaertsaufzaehlung - 1]);

                        // Wenn er teil der Primzahl Liste ist, handelt es sich um eine Mirpzahl und diese wird in der Mirpzahl Liste gespeichert

                        if (IstZahlInPrimzahlVorhanden(primzahlenrueckwaerts[primzahlenrueckwaertsaufzaehlung - 1]))
                        {
                            //ArrayExpand(ref mirprimzahlen);
                            Console.WriteLine("{0}. {1}", mirpirmzahlenaufzaehlung, ReverseZahl(primzahlenrueckwaerts[primzahlenrueckwaertsaufzaehlung - 1]));
                            mirpirmzahlenaufzaehlung++;
                        }

                        // Wenn er nicht Teil ist, dann geht die Schleife von vorne los und die nächste PrimzahlRueckwaerts wird generiert und geprüft

                    }

                    primzahlaufzaehlung++;

                } else
                {
                    primzahlaufzaehlung++;
                }

                
            } while (mirpirmzahlenaufzaehlung < eingabeuser);

            //Console.WriteLine("\n{0} Mirpzahlen:", eingabeuser);

            //Ausgabe aller Mirpzahlen

            //foreach (int i in mirprimzahlen)
            //   Console.WriteLine("{0}. {1}", stellemirpzahl++ ,i);
        }
    }
}

                



