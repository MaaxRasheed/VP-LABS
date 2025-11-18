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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(textBox1.Text)) {
                    throw new Exception("Book ID is empty. Cannot remove.");
                }
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\mylocaldb;Initial Catalog=LibraryStockManagement;Integrated Security=True");
                string query = "Delete From Books Where BookID='" + Convert.ToInt32(textBox1.Text) + "' ";

                con.Open();

                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                con.Close();
                MessageBox.Show("Removed SuccessFully");
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
