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
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { string item=null;
            string list = null;
            foreach (string x in checkedListBox1.CheckedItems)
            {
                item += " " + x;
            }
            list = listBox1.Text;
            MessageBox.Show($"You selected: {list} from list box and\nYou selected:{item} from Checked list box");
        }
    }
}
