using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Task10 : Form
    {
        public Task10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string x = null, y = null, z = null, s = null;

            x = dateTimePicker1.Text;

            foreach (string a in checkedListBox1.CheckedItems)
                s += " " + a;

            y = numericUpDown1.Text;

            z =comboBox1.Text;

            label6.Text=($"Your Name: {name}\nCheck-In Date: {x}\nNumber of guests: {y}\nRoom Type: {z}\nService Required: {s}");
        }
    }
}
