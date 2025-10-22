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
    public partial class Task9 : Form
    {
        public Task9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int score = 0;
            if (checkBox1.Checked && checkBox2.Checked &&!checkBox3.Checked &&!checkBox4.Checked)
                score++;

            if (radioButton1.Checked)
                score++;

            if (comboBox1.Text == "Islamabad")
                score++;

            label4.Text = $"Your Score:{score}";
        }
    }
}
