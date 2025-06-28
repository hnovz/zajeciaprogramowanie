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
                switch (choice)
                {
                    case '1':
                        //AddTask();
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
                        Console.WriteLine("Nieprawidłowy wybór, naciśnij dowolny klawisz.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}