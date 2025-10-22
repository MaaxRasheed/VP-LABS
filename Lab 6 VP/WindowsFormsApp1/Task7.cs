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
    public partial class Task7 : Form
    {
        public Task7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string gender=null,lang=null,country=null,age=null;

            if(radioButton1.Checked)gender=radioButton1.Text;
            if(radioButton2.Checked)gender=radioButton2.Text;

            foreach (string x in checkedListBox1.CheckedItems)
                lang += " " + x;

            country = comboBox1.Text;

            age = numericUpDown1.Text;

            MessageBox.Show($"Your Name: {name}\nYour gender: {gender}\nYour selected language/s: {lang}\nYour age: {age}\nYour country: {country}");
        }
    }
}
