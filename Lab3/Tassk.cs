using System;
using System.Collections.Generic;

namespace Lab3
{
    public delegate void StateChangedEventHandler(object sender, TaskEventArgs e);
    public class Tassk
    {
        public string Name { get; set; }
        private bool isCompleted;

        // Property để quản lý trạng thái công việc và kích hoạt sự kiện khi trạng thái thay đổi
        public bool IsCompleted
        {
            get { return isCompleted; }
            set
            {
                if (isCompleted != value)
                {
                    isCompleted = value;
                    OnStateChanged(new TaskEventArgs(this));
                }
            }
        }

        // Sự kiện thay đổi trạng thái công việc
        public event StateChangedEventHandler StateChanged;

        protected virtual void OnStateChanged(TaskEventArgs e)
        {
            StateChanged?.Invoke(this, e);
        }
    }
}
