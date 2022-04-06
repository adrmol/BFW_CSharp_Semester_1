using System;
using System.Collections.Generic;
using System.Text;

namespace Weitere_Übungsaufgaben
{
    class Aufgabe_X1
    {

        string[] todo = new string[0];
        string[] tododeleted = new string[0];

        public void AddToDo(string newtodo)
        {
            Array.Resize(ref todo, todo.Length + 1);
            todo[todo.Length - 1] = newtodo;
        }

        public void ShowToDo()
        {
            int j = 0;
            foreach (string i in todo)
                Console.WriteLine("{0}. {1}", j++, i);
        }

        public void ShowToDoDeleted()
        {
            int j = 0;
            foreach (string i in tododeleted)
                Console.WriteLine("{0}. {1}", j++, i);
        }

        public void SwapToDo(int firstpos, int secpos)
        {
            string i = todo[firstpos];
            string j = todo[secpos];
            todo[firstpos] = j;
            todo[secpos] = i;
        }

        public void DeleteToDo(int delpos)
        {

            Array.Resize(ref tododeleted, tododeleted.Length + 1);
            tododeleted[tododeleted.Length - 1] = todo[delpos];

            string[] tempArr = new string[todo.Length - 1];

            for (int j = 0; j < delpos; j++)
                tempArr[j] = todo[j];

            if (tempArr.Length == 0)
            {
                todo = tempArr;
                return;
            }

            for (int j = delpos; j < tempArr.Length; j++)
                tempArr[j] = todo[j + 1];
            todo = tempArr;
        }

        public void Start()
        {
            bool ende = true; 
            while (ende)
            {

                Console.WriteLine();
                Console.WriteLine("Was wollen Sie tun?");
                Console.WriteLine("Hinzufügen von neuer Erinnerung?\t[1]");
                Console.WriteLine("Anzeigen aller Erinnerungen?\t\t[2]");
                Console.WriteLine("Anzeigen aller gelöschten Erinnerungen?\t[3]");
                Console.WriteLine("Sortieren von Erinnerungen?\t\t[4]");
                Console.WriteLine("Löschen einer einzelnen Erinnerung?\t[5]");
                Console.WriteLine();

                switch (Console.ReadLine())
                {

                    case "1":
                        AddToDo(Console.ReadLine());
                        break;

                    case "2":
                        ShowToDo();
                        break;

                    case "3":
                        ShowToDoDeleted();
                        break;

                    case "4":
                        SwapToDo(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                        break;

                    case "5":
                        DeleteToDo(Convert.ToInt32(Console.ReadLine()));
                        break;

                    default:
                        ende = false;
                        break;

                }
            }
        }
    }
}
