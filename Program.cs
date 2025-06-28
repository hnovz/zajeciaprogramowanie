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
                Console.Clear();
                Console.Write(
                    "==== MENU ====\n" +
                    "1. Dodaj nowe zadanie\n" +
                    "2. Wyświetl listę zadań\n" +
                    "3. Oznacz zadanie jako ukończone\n" +
                    "4. Usuń zadanie\n" +
                    "5. Zakończ program\n" +
                    "Wybierz opcję (1-5):");

                var choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (choice)
                {
                    case '1':
                        AddTask();
                        break;
                    case '2':
                        //ListTasks();
                        break;
                    case '3':
                        //CompleteTask();
                        break;
                    case '4':
                        //RemoveTask();
                        break;
                    case '5':
                        Console.WriteLine("Koniec działania programu.");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowe wywołanie.");
                        WaitForInput();
                        break;
                }
            }
        }

        static void WaitForInput()
        {
            Console.WriteLine("Naciśnij dowolny klawisz.");
            Console.ReadKey();
        }

        static void AddTask()
        {
            Console.Write("Podaj opis nowego zadania: ");
            string? newTask = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newTask))
            {
                Console.WriteLine("Opis zadania nie może być pusty. Przerwano dodawanie.");
                WaitForInput();
                return;
            }
            tasks.Add(newTask);
            completed.Add(false);
            Console.WriteLine($"Dodano zadanie: \"{newTask}\"");
            WaitForInput();
        }
    }
}