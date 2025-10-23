using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoLibrary
{
    public class TaskManager
    {
        private List<TaskItem> tasks = new List<TaskItem>();

      
        public void AddTask(TaskItem task)
        {
            tasks.Add(task);
        }

       
        public bool UpdateTask(int id, TaskItem updatedTask)
        {
            var existing = tasks.FirstOrDefault(t => t.TaskId == id);
            if (existing != null)
            {
                existing.Title = updatedTask.Title;
                existing.Description = updatedTask.Description;
                existing.DueDate = updatedTask.DueDate;
                return true;
            }
            return false;
        }

       
        public bool DeleteTask(int id)
        {
            var task = tasks.FirstOrDefault(t => t.TaskId == id);
            if (task != null)
            {
                tasks.Remove(task);
                return true;
            }
            return false;
        }

       
        public List<TaskItem> GetAllTasks()
        {
            return tasks;
        }

        
        public bool MarkAsCompleted(int id)
        {
            var task = tasks.FirstOrDefault(t => t.TaskId == id);
            if (task != null)
            {
                task.IsCompleted = true;
                return true;
            }
            return false;
        }

        public List<TaskItem> GetTasksByStatus(string status)
        {
            if (status == "Completed")
                return tasks.Where(t => t.IsCompleted).ToList();
            else if (status == "Pending")
                return tasks.Where(t => !t.IsCompleted).ToList();
            else
                return tasks;
        }
    }
}

