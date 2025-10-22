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
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string y=null;
            string x = null;
            if (checkBox1.Checked) x += checkBox1.Text+" ";
            if(checkBox2.Checked) x += checkBox2.Text+" ";
            if(checkBox3.Checked) x += checkBox3.Text+" ";

            
            if(radioButton1.Checked) y= radioButton1.Text;
            if (radioButton2.Checked) y= radioButton2.Text;

            label1.Text =$"You selected {x} from groupbox\nYou selected {y} from panel";
        }
    }
}
