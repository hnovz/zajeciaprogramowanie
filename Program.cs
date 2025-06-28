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
                        ListTasks();
                        break;
                    case '3':
                        CompleteTask();
                        break;
                    case '4':
                        RemoveTask();
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

        static void ListTasks()
        {
            if (tasks.Count != 0)
            {
                Console.WriteLine("Lista zadań:");
                for (int i = 0; i < tasks.Count; ++i)
                {
                    string status = completed[i] ? "[x]" : "[ ]";
                    Console.WriteLine($"{i + 1}. {status} {tasks[i]}");
                }
            }
            else
            {
                Console.WriteLine("Brak tasków.");
            }
            WaitForInput();
        }

        static void CompleteTask()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Brak zadań na liście. Nie ma czego oznaczać jako ukończone.");
                WaitForInput();
                return;
            }

            // Wyświetlamy listę zadań, aby użytkownik widział numerację
            Console.WriteLine("Które zadanie oznaczyć jako ukończone? Wybierz numer:");
            for (int i = 0; i < tasks.Count; i++)
            {
                string status = completed[i] ? "[X]" : "[ ]";
                Console.WriteLine($"{i + 1}. {status} {tasks[i]}");
            }

            // Pobieramy numer od użytkownika
            Console.Write("Numer zadania: ");
            string? input = Console.ReadLine();
            if (!int.TryParse(input, out int taskNumber))
            {
                Console.WriteLine("Wprowadzono nieprawidłowy numer.");
                WaitForInput();
                return;
            }

            // Konwertujemy numer (1-based) na indeks (0-based)
            int index = taskNumber - 1;
            if (index < 0 || index >= tasks.Count)
            {
                Console.WriteLine("Zadanie o podanym numerze nie istnieje.");
                WaitForInput();
                return;
            }

            if (completed[index])
            {
                Console.WriteLine($"Zadanie \"{tasks[index]}\" było już oznaczone jako ukończone.");
            }
            else
            {
                completed[index] = true;
                Console.WriteLine($"Zadanie \"{tasks[index]}\" oznaczono jako ukończone!");
            }
            WaitForInput();

        }

        static void RemoveTask()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Brak zadań do usunięcia.");
                WaitForInput();
                return;
            }

            Console.WriteLine("Które zadanie chcesz usunąć? Wybierz numer:");
            for (int i = 0; i < tasks.Count; i++)
            {
                string status = completed[i] ? "[x]" : "[ ]";
                Console.WriteLine($"{i + 1}. {status} {tasks[i]}");
            }

            Console.Write("Numer zadania do usunięcia: ");
            string? input = Console.ReadLine();
            if (!int.TryParse(input, out int taskNumber))
            {
                Console.WriteLine("Wprowadzono nieprawidłowy numer.");
                WaitForInput();
                return;
            }

            int index = taskNumber - 1;
            if (index < 0 || index >= tasks.Count)
            {
                Console.WriteLine("Zadanie o podanym numerze nie istnieje.");
                WaitForInput();
                return;
            }

            Console.WriteLine($"Usunięto zadanie: \"{tasks[index]}\"");
            tasks.RemoveAt(index);
            completed.RemoveAt(index);
            WaitForInput();
        }
    }
}