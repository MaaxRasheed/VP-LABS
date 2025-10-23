using System;

namespace ToDoLibrary
{
    public class TaskItem
    {
       
        private int taskId;
        private string title;
        private string description;
        private DateTime dueDate;
        private bool isCompleted;

        
        public int TaskId
        {
            get { return taskId; }
            set { taskId = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        public bool IsCompleted
        {
            get { return isCompleted; }
            set { isCompleted = value; }
        }
      
        public TaskItem(int id, string title, string description, DateTime dueDate)
        {
            TaskId = id;
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = false;
        }

        public override string ToString()
        {
            return $"{TaskId}: {Title} - {(IsCompleted ? "Completed" : "Pending")}";
        }
    }
}
