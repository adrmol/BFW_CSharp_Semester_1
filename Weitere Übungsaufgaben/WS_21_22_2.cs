using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    internal class WS_21_22_2
    {
        public static decimal GeldEinwurf(decimal g)
        {
            return g += Convert.ToDecimal(Console.ReadLine()[..^1]);
        }
        public static void Start()
        {
            Console.OutputEncoding = Encoding.Default;

            var snacks = new int[16];

            for (int i = 0; i < snacks.Length; i++)
                snacks[i] = 5;

            decimal preis = 1.5M;
            decimal geld = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Geld im Automaten: {0}\tVerfügbare Snack Sorten: {1}\n", geld.ToString("C",
                  CultureInfo.CreateSpecificCulture("jp-JP")), snacks.Length);
                Console.WriteLine("Geld einwerfen: [0]\nSnack kaufen: [1]");
                int decision = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (decision)
                {
                    case 0:
                        Console.WriteLine("Bitte werfen Sie Geld ein:");
                        geld = GeldEinwurf(geld);
                        break;

                    case 1:
                        Console.WriteLine("Wählen Sie einen Snack aus (1 - {0})", snacks.Length);
                        int eingabeSnack = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Sie haben Snack {0} gewählt!", eingabeSnack);
                        if (snacks[eingabeSnack - 1] == 0)
                        {
                            Console.WriteLine("Snack {0} leider ausgegangen!", eingabeSnack);
                            Console.ReadLine();
                            break;
                        }
                        while (geld < preis)
                        {
                            Console.WriteLine("Bitte werfen Sie noch {0:C} in den Automaten.", preis - geld);
                            geld = GeldEinwurf(geld);
                        }
                        Console.WriteLine("Ihr Rückgeld: {0:C}\nIhr Snack {1}:", geld -= preis, eingabeSnack);
                        Console.WriteLine(" _____________,-.___     _\n" +
                                          "| ____        { {]_]_]   [_]\n" +
                                          "|___ `-" + eingabeSnack + "---.__\\ \\_]_]_    . `\n" +
                                          "|   `-----.____} }]_]_]_   ,\n" +
                                          "|_____________/ {_]_]_]_] , `\n" +
                                          "              `-'");
                        snacks[eingabeSnack - 1]--;
                        geld = 0;
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
