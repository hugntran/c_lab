using System;
using System.Collections.Generic;
using Lab3;

class Program
{
    static void Main()
    {
        TaskManager taskManager = new TaskManager();

        Tassk task1 = new Tassk { Name = "JOB1" };
        Tassk task2 = new Tassk { Name = "JOB2" };

        taskManager.AddTask(task1);
        taskManager.AddTask(task2);

        task1.IsCompleted = true; // Thay đổi trạng thái của công việc và hiển thị thông báo

        taskManager.DisplayTasks(false); // Hiển thị danh sách công việc chưa hoàn thành

        Console.ReadLine();
    }
}