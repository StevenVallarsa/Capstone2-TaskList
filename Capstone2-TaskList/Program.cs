using System;
using System.Collections.Generic;

namespace Capstone2_TaskList
{
    class Program
    {

        public static List<Task> tasks = new List<Task>();

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Task Manager!");

            while (true)
            {
                Menu();

                ToDo();
            }
                //Console.Write("Enter a task: ");



                //Console.Write("Another Task? ");
                //if (Console.ReadLine() == "n")
                //{
                //    break;
                //}


            //}
            //foreach (Task t in tasks)
            //{
            //    Console.WriteLine(t.TaskName);
            //}


        }

        public static void Menu()
        {
            Console.WriteLine("  1) List tasks");
            Console.WriteLine("  2) Add task");
            Console.WriteLine("  3) Delete task");
            Console.WriteLine("  4) Mark task complete");
            Console.WriteLine("  5) Quit");
            Console.WriteLine();

        }

        public static void ToDo()
        {
            bool run = true;
            while (run)
            {

                Console.Write("What would you like to do? ");
                string input = Console.ReadLine().ToLower();

                if (input == "1" || input == "list")
                {
                    ListTasks();
                }
                else if (input == "2" || input == "add")
                {
                    AddTask();
                }
                else if (input == "3" || input == "delete")
                {
                    DeleteTask();
                }

            }

        }

        public static void ListTasks()
        {
            foreach (Task item in tasks)
            {
                Console.WriteLine($"{item.TaskName} -- Completed? {item.TaskComplete}");
            }
        }

        public static void AddTask()
        {
            Console.Write("What is your task? ");
            Task t = new Task(Console.ReadLine());
            //Console.WriteLine($"The task {t.TaskName} is complete? {t.TaskComplete}.");
            tasks.Add(t);
        }

        public static void DeleteTask()
        {
            Console.WriteLine("Which task would you like to delete?");

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($" {i + 1} {tasks[i].TaskName}");
            }
        }


    }
}
