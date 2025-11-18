using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_9_b_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "Maaz" && password == "maaz123")
            {
                MessageBox.Show("Login Successful.");
              
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else {
                MessageBox.Show("Login failed. Username or Password is incorrect.");
            }
        }
    }
}
