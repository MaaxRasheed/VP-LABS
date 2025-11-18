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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_9_b_
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source=(localdb)\\mylocaldb;Initial Catalog=LibraryStockManagement;Integrated Security=True");
                string query= "SELECT * FROM Books WHERE 1 = 1";
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    if (int.TryParse(textBox1.Text, out _))
                    {
                        query += " AND BookID = " + textBox1.Text;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Book ID. Please enter a valid number.");
                        return;
                    }
                }
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    query += " AND Author LIKE '%" + textBox2.Text + "%'";
                }
                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    query += " AND Title LIKE '%" + textBox3.Text + "%'";
                }
                if (!string.IsNullOrEmpty(textBox4.Text))
                {
                    query += " AND ISBN = '" + textBox4.Text + "'";
                }

                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                dataGridView1.DataSource = dataTable;
                
                con.Close();
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\mylocaldb;Initial Catalog=LibraryStockManagement;Integrated Security=True");
            string query = "Select * From Books";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;
            con.Close();
        }
    }
}
