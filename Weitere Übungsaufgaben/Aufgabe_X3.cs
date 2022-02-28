using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_X3
    {

        int[] primzahlen = new int[0];
        int[] zahlenfolge = new int[0];
        int zahlenfolgegroeße = 2;


        private static void ArrayExpand(ref int[] array)
        {
            int[] tempArr = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
                tempArr[i] = array[i];
            array = tempArr;
        }

        public bool TestaufPrimzahl(int zahl)
        {
            foreach (int i in primzahlen)
            {
                if (i == zahl)
                    return true;
            } 
            return false;
        }

        public void ZahlenfolgeExpand()
        {
            ArrayExpand(ref zahlenfolge);
            zahlenfolge[zahlenfolgegroeße - 2] = zahlenfolgegroeße;
            ++zahlenfolgegroeße;
        }

        public static void Start()
        {

        }
    }
}

                



