using System;
using System.Collections.Generic;
using System.Text;

namespace BFW_Uebungen_Semester_1
{
    class Aufgabe_23
    {

        public static void Start()
        {

            Console.WriteLine("Bitte geben Sie Strings ein:");
            string output1 = "";
            
            do
            {
                string input1 = Console.ReadLine();
                if (input1 == "")
                    break;
                else if (input1.Length < 6)
                    output1 += " und " + input1;
                else
                {
                    string tempinput1 = "";
                    for (int i = 0; i < input1.Length; i++)
                    {
                        if (input1.Substring(i, 1) != "a" &&
                            input1.Substring(i, 1) != "e" &&
                            input1.Substring(i, 1) != "i" &&
                            input1.Substring(i, 1) != "o" &&
                            input1.Substring(i, 1) != "u" &&
                            input1.Substring(i, 1) != "A" &&
                            input1.Substring(i, 1) != "E" &&
                            input1.Substring(i, 1) != "I" &&
                            input1.Substring(i, 1) != "O" &&
                            input1.Substring(i, 1) != "U")
                        {
                            tempinput1 += input1.Substring(i, 1);
                        }
                    }
                    input1 = tempinput1;

                    if (input1.Length > 5)
                    {
                        tempinput1 = "";
                        for (int i = 0; i < input1.Length; i++)
                        {
                            if (input1.Substring(i, 1) != "s" &&
                                input1.Substring(i, 1) != "t" &&
                                input1.Substring(i, 1) != "S" &&
                                input1.Substring(i, 1) != "T")
                            {
                                tempinput1 += input1.Substring(i, 1);
                            }
                        }
                        input1 = tempinput1;
                    }
                    output1 += " und " + input1;
                }

            } while (true);

            if (output1.Length < 6)
                Console.WriteLine(output1);
            else
                Console.WriteLine(output1.Substring(5));
        }

    }
}
