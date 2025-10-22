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
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string skill = null;
            if (checkBox1.Checked) skill += " C#";
            if (checkBox2.Checked) skill += " Python";

            string gender = null;

            if (radioButton1.Checked) gender += " Male ";
            if (radioButton2.Checked) gender += " Female ";
            MessageBox.Show($"Your skill:{skill}.\nYour Gender:{gender}.");
            
        }
    }
}
