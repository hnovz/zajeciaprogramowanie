using System;
using System.Collections.Generic;

namespace TodoApp
{
    class Program
    {
        static List<string> tasks = new List<string>();
        static List<bool> completed = new List<bool>();
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("/n==== MENU ====");
                Console.WriteLine("1. Dodaj nowe zadanie");
                Console.WriteLine("2. Wyświetl listę zadań");
                Console.WriteLine("3. Oznacz zadanie jako ukończone");
                Console.WriteLine("4. Usuń zadanie");
                Console.WriteLine("5. Zakończ program");
                Console.Write("Wybierz opcję (1-5):");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        //AddTask();
                        break;
                    case "2":
                        //ListTasks();
                        break;
                    case "3":
                        //CompleteTask();
                        break;
                    case "4":
                        //RemoveTask();
                        break;
                    case "5":
                        Console.WriteLine("Koniec działania programu.");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór, spróbuj ponownie.");
                        break;
                }
            }
        }
    }
}