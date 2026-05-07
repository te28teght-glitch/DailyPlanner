using System;
using System.Collections.Generic;

namespace DailyPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();

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
                        Console.WriteLine("Введите название задачи:");
                        string title = Console.ReadLine();

                        Console.WriteLine("Введите время начала (чч:мм):");
                        string startInput = Console.ReadLine();
                        DateTime startTime = DateTime.Parse(startInput);

                        Console.WriteLine("Введите время конца (чч:мм):");
                        string endInput = Console.ReadLine();
                        DateTime endTime = DateTime.Parse(endInput);

                        Task newTask = new Task();
                        newTask.Title = title;
                        newTask.StartTime = startTime;
                        newTask.EndTime = endTime;
                        newTask.IsCompleted = false;

                        taskManager.AddTask(newTask);
                        Console.WriteLine("Успешно!");
                        break;


                    case 2:
                        Console.WriteLine("Все задачи:");
                        var allTasks = taskManager.GetAllTasks();
                        
                        if (allTasks.Count == 0){
                            Console.WriteLine("Задач нет!");
                        }
                        else
                        {
                            for (int i = 0; i < allTasks.Count; i++)
                            {
                                string status = allTasks[i].IsCompleted ? "Выполнено" : "Не выполнено";
                                Console.WriteLine($"{i + 1}. {allTasks[i].GetDescription()} - {status}");
                            }
                        } 
                        break;
                    case 3:

                        Console.WriteLine("Все задачи:");
                        var allTasks1 = taskManager.GetAllTasks();
                        
                        if (allTasks1.Count == 0){
                            Console.WriteLine("Задач нет!");
                        }
                        else
                        {
                            for (int i = 0; i < allTasks1.Count; i++)
                            {
                                string status = allTasks1[i].IsCompleted ? "Выполнено" : "Не выполнено";
                                Console.WriteLine($"{i + 1}. {allTasks1[i].GetDescription()} - {status}");
                            }
                        } 
                        Console.WriteLine("Введите номер задачи для удаления:");
                        string numberstr = Console.ReadLine();
                        int number = int.Parse(numberstr);
                        int index = number - 1;
                        bool succes = taskManager.RemoveTask(index);
                        if (succes == true)
                        {
                            Console.WriteLine($"Удалена задача: {index + 1}");
                        }
                        else
                        {
                            Console.WriteLine("Не удалось удалить");
                        }
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