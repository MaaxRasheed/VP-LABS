using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }

        private void Main_form_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void task1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 task1= new Form1();
            task1.ShowDialog();
        }

        private void task2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task2 task2= new Task2();
            task2.ShowDialog();
        }

        private void task3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task3 task3= new Task3();
            task3 .ShowDialog();
        }

        private void task4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task4 task4 = new Task4();
            task4.ShowDialog(); 
        }

        private void task5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task5 task5 = new Task5();
            task5.ShowDialog();
        }

        private void task6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task_6 task6=new Task_6();
            task6.ShowDialog();
        }
    }
}
