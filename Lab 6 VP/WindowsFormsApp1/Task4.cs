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
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x=comboBox1.Text;
            string y=numericUpDown1.Text;
            Convert.ToInt32(y);

            MessageBox.Show($"Your Selected Country: {x}\nYour age: {y}");
        }
    }
}
