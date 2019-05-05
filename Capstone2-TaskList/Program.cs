using System;
using System.Collections.Generic;

namespace Capstone2_TaskList
{
    class Program1
    {
        // create Task list object
        public static List<Task> tasks = new List<Task>();

        // Main program
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Task Manager!");
            Console.WriteLine();

            ToDo();

            Console.WriteLine();
            Console.WriteLine("Goodbye.");
        }



        public static void Menu()
        {
            Console.WriteLine($"You currently have {tasks.Count} task{(tasks.Count == 1 ? "" : "s")} in your tasks list.");
            Console.WriteLine();
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
                Menu();

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
                else if (input == "4" || input == "mark" || input == "complete")
                {
                    CompleteTask();
                }
                else if (input == "5" || input == "quit")
                {
                    run = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Oops. I didn't understand that. Try again.");
                    Console.WriteLine();
                    Console.WriteLine("- + - + - + - + - + - + - + - +");
                    Console.WriteLine();
                }

            }

        }



        public static void ListTasks()
        {
            Console.Clear();

            if (tasks.Count == 0)
            {
                Console.WriteLine("You haven't added any tasks yet.");
                Console.WriteLine();
                Console.WriteLine("- + - + - + - + - + - + - + - +");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Here is your tasks list:");
                Console.WriteLine();

                foreach (Task item in tasks)
                {
                    Console.WriteLine($"  {item.TaskName} - {(item.TaskCompleted ? "Done " : "To do")}");
                }
                Console.WriteLine();
                Console.WriteLine("- + - + - + - + - + - + - + - + -");
                Console.WriteLine();
            }
        
        }



        public static void AddTask()
        {
            Console.WriteLine();
            Console.Write("What is your task? ");

            Task t = new Task(Console.ReadLine());
            tasks.Add(t);

            Console.Clear();
            Console.WriteLine("Task added.");
            Console.WriteLine();
            Console.WriteLine("- + - + - + - + - + - + - + - +");
            Console.WriteLine();
        }



        public static void DeleteTask()
        {
            int taskNumber = 0;
            Console.Clear();

            if (tasks.Count == 0)
            {
                Console.WriteLine("You have no tasks to delete.");
                Console.WriteLine();
                Console.WriteLine("- + - + - + - + - + - + - + - + -");
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("Here is your tasks list:");
                Console.WriteLine();

                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"  {i + 1}) {tasks[i].TaskName} - {(tasks[i].TaskCompleted ? "Done " : "To do")}");
                }
                Console.WriteLine($"  {tasks.Count + 1}) Return to main menu");
                Console.WriteLine();


                bool run = true;
                while (run)
                {
                    Console.Write("Which task would you like to delete? ");
                    Console.WriteLine();

                    string input = Console.ReadLine();
                    try
                    {
                        taskNumber = Convert.ToInt32(input);
                        if (taskNumber < 1 || taskNumber > tasks.Count + 1)
                        {
                            throw new Exception();
                        }
                        else if (taskNumber == tasks.Count + 1)
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            run = false;
                            tasks.RemoveAt(taskNumber - 1);
                            Console.WriteLine();
                            Console.WriteLine("- + - + - + - + - + - + - + - + -");
                            Console.WriteLine();

                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine();
                        Console.WriteLine("That wasn't a valid task. Try again.");
                    }

                }

            }

        }



        public static void CompleteTask()
        {
            int taskNumber = 0;
            Console.Clear();

            if (tasks.Count == 0)
            {
                Console.WriteLine("You haven't added any tasks yet.");
                Console.WriteLine();
                Console.WriteLine("- + - + - + - + - + - + - + - + -");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Here is your tasks list:");
                Console.WriteLine();

                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"  {i + 1}) {tasks[i].TaskName} - {(tasks[i].TaskCompleted ? "COMPLETED" : "To Do")}");
                }
                Console.WriteLine($"  {tasks.Count + 1}) Return to main menu");

                bool run = true;
                while (run)
                {
                    Console.WriteLine();
                    Console.Write("Which task would you like to mark as complete? ");

                    string input = Console.ReadLine();
                    try
                    {
                        taskNumber = Convert.ToInt32(input);
                        if (taskNumber < 1 || taskNumber > tasks.Count + 1)
                        {
                            throw new Exception();
                        }
                        else if (taskNumber == tasks.Count + 1)
                        {
                            Console.Clear();
                            break;
                        }
                        else if (tasks[taskNumber - 1].TaskCompleted == true)
                        {
                            throw new Exception();
                        }
                        else
                        {
                            run = false;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine();
                        Console.WriteLine("That not a valid task. Try again.");
                        Console.WriteLine();
                    }

                    Console.Clear();
                    Console.WriteLine("Task marked as completed.");
                    Console.WriteLine();
                    Console.WriteLine("- + - + - + - + - + - + - + - + -");
                    Console.WriteLine();

                    tasks[taskNumber - 1].TaskCompleted = true;
                }
            
            }
        
        }
    
    }

}
