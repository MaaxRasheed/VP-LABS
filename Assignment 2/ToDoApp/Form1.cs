using System;
using System.Linq;
using System.Windows.Forms;
using ToDoLibrary;

namespace ToDoApp
{
    public partial class Form1 : Form
    {
        TaskManager manager = new TaskManager();
        int selectedTaskId = -1;

        public Form1()
        {
            InitializeComponent();
            cmbFilter.Items.AddRange(new string[] { "All", "Completed", "Pending" });
            cmbFilter.SelectedIndex = 0;
            RefreshList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = manager.GetAllTasks().Count + 1;
            var task = new TaskItem(id, txtTitle.Text, txtDescription.Text, dtpDueDate.Value);
            manager.AddTask(task);
            RefreshList();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedTaskId != -1)
            {
                var updated = new TaskItem(selectedTaskId, txtTitle.Text, txtDescription.Text, dtpDueDate.Value);
                manager.UpdateTask(selectedTaskId, updated);
                RefreshList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedTaskId != -1)
            {
                manager.DeleteTask(selectedTaskId);
                RefreshList();
                ClearInputs();
            }
        }

        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            if (selectedTaskId != -1)
            {
                manager.MarkAsCompleted(selectedTaskId);
                RefreshList();
            }
        }

        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
            {
                // Extract task from ListBox
                TaskItem task = lstTasks.SelectedItem as TaskItem;
                selectedTaskId = task.TaskId;
                txtTitle.Text = task.Title;
                txtDescription.Text = task.Description;
                dtpDueDate.Value = task.DueDate;
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            lstTasks.Items.Clear();
            string status = cmbFilter.SelectedItem.ToString();
            var filteredTasks = manager.GetTasksByStatus(status);

            foreach (var task in filteredTasks)
            {
                lstTasks.Items.Add(task);
            }

            // This ensures the TaskItem’s ToString() is used
            lstTasks.DisplayMember = nameof(TaskItem.Title);
        }

        private void ClearInputs()
        {
            txtTitle.Clear();
            txtDescription.Clear();
            selectedTaskId = -1;
        }
    }
}
