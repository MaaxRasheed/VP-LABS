using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_9_b_
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = dateTimePicker1.Value;
                string formattedDate = date.ToString("yyyy-MM-dd");
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\mylocaldb;Initial Catalog=LibraryStockManagement;Integrated Security=True");
                string query = "Update Books Set Title='" + textBox2.Text + "', Author='" + textBox3.Text + "', Publisher ='" + textBox4.Text + "' , Category='" + comboBox1.Text + "', ISBN='" + textBox6.Text + "', Quantity ='" + Convert.ToInt32(textBox7.Text) + "' , Price='" + Convert.ToInt32(textBox8.Text) + "' , RackNo='" + Convert.ToInt32(textBox9.Text) + "' , DateAdded='" + formattedDate + "' WHERE BookID= '"+Convert.ToInt32(textBox1.Text)+"' "; 

                con.Open();

                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();

                con.Close();
                MessageBox.Show("Updated Successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL error occurred: {ex}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex}");
            }
        }
    }
}
