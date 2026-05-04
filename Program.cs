using System;
using System.Collections.Generic;

namespace DailyPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();

            while (true)
            {
                Console.WriteLine("=== Ежедневник ===");
                Console.WriteLine("1. Добавить задачу");
                Console.WriteLine("2. Показать задачи");
                Console.WriteLine("3. Удалить задачу");
                Console.WriteLine("4. Выйти");
                Console.WriteLine("Выберите действие: ");

                string input = Console.ReadLine();
                int choice = int.Parse(input);

                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Неверный выбор, попробуйте снова");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}