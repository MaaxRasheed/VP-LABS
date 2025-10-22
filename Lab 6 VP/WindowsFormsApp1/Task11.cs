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
    public partial class Task11 : Form
    {
        public Task11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(numericUpDown1.Text);
            int y = Convert.ToInt32(numericUpDown2.Text);

            int Result = x + y;
            label4.Text = $"Result: {Result}";
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(numericUpDown1.Text);
            int y = Convert.ToInt32(numericUpDown2.Text);
            int Result = x - y;
            label4.Text = $"Result: {Result}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(numericUpDown1.Text);
            int y = Convert.ToInt32(numericUpDown2.Text);
            int Result = x * y;
            label4.Text = $"Result: {Result}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(numericUpDown1.Text);
            int y = Convert.ToInt32(numericUpDown2.Text);
            int Result = x / y;
            label4.Text = $"Result: {Result}";
        }
    }
}
