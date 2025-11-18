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
    public partial class AddForm : Form
    {
        public AddForm()
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
                string query = "Insert into Books(BookId,Title,Author,Publisher,Category,ISBN,Quantity,Price,RackNo,DateAdded) Values('" + Convert.ToInt32(textBox1.Text) + "' , '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + comboBox1.Text + "', '" + textBox6.Text + "' , '" + Convert.ToInt32(textBox7.Text) + "' ,'" + Convert.ToInt32(textBox8.Text) + "', '" + Convert.ToInt32(textBox9.Text) + "' , '" + formattedDate + "') ";

                con.Open();

                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();

                con.Close();
                MessageBox.Show("Added Successfully");
            }
            catch(SqlException ex)
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
