using System;
using System.Collections.Generic;


namespace Capstone2_TaskList
{
    public class Task
    {
        public string TaskName { get; set; }
        public bool TaskComplete { get; set; }



        public Task(string task)
        {
            TaskName = task;
            TaskComplete = false;
        }


    }
}
