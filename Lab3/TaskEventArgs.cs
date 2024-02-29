using System;
using System.Collections.Generic;

namespace Lab3
{
    public class TaskEventArgs : EventArgs
    {
        public Tassk Task { get; }

        public TaskEventArgs(Tassk task)
        {
            Task = task;
        }
    }
}
