using System;
using System.Collections.Generic;

namespace Lab3
{
    public class TaskManager
    {
        private List<Tassk> tasks = new List<Tassk>();

        // Phương thức thêm công việc mới vào danh sách
        public void AddTask(Tassk task)
        {
            task.StateChanged += Task_StateChanged;
            tasks.Add(task);
        }

        // Phương thức hiển thị danh sách công việc cùng trạng thái
        public void DisplayTasks(bool completed)
        {
            Console.WriteLine($"Danh sách công việc {(completed ? "đã hoàn thành" : "chưa hoàn thành")}:");
            foreach (var task in tasks)
            {
                if (task.IsCompleted == completed)
                {
                    Console.WriteLine($"{task.Name} - {(task.IsCompleted ? "Đã hoàn thành" : "Chưa hoàn thành")}");
                }
            }
            Console.WriteLine();
        }

        // Xử lý sự kiện thay đổi trạng thái công việc
        private void Task_StateChanged(object sender, ToDoListEvent e)
        {
            Console.WriteLine($"Trạng thái của công việc {e.Task.Name} đã thay đổi thành {(e.Task.IsCompleted ? "Đã hoàn thành" : "Chưa hoàn thành")}");
        }
    }
}
