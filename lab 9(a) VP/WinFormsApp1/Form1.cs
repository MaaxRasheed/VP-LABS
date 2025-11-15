
using Microsoft.Data.SqlClient;
using System.CodeDom;
using System.Data;
using System.Data.SqlTypes;
using System.Security.Cryptography;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\mylocaldb;Initial Catalog=StudentManagement;Integrated Security=True");
            try
            {

                DateTime date = dateTimePicker1.Value;
                string formattedDate = date.ToString("yyyy-MM-dd");



                string query = "Insert into Student(Name, FatherName, CNIC, Gender, DOB, Address,DegreeProgram,MatricGrade,InterGrade) values('" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + comboBox1.SelectedItem + "','" + formattedDate + "','" + textBox5.Text + "' ,'" + listBox1.SelectedItem + "' , '" + comboBox2.SelectedItem + "','" + comboBox3.SelectedItem + "')";


                con.Open();



                SqlCommand sqlCommand = new SqlCommand(query, con);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                con.Close();
                MessageBox.Show("Student Added Successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Sql error: {ex.Message}");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occur: {ex.Message}");

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\mylocaldb;Initial Catalog=StudentManagement;Integrated Security=True");
            string query = "Select * From Student";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\mylocaldb;Initial Catalog=StudentManagement;Integrated Security=True");
            SqlDataAdapter adapter = null;
            string query = "Select * From Student";
            DataTable dataTable = null;
            try
            {
                if (dataTable != null)
                {
                    dataTable.Clear();
                }
                else
                {
                    adapter = new SqlDataAdapter(query, con);
                    dataTable = new DataTable();

                    dataGridView1.DataSource = dataTable;

                }
                adapter.Fill(dataTable);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error during refresh: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\mylocaldb;Initial Catalog=StudentManagement;Integrated Security=True");
            DialogResult result = MessageBox.Show("Are you sure you want to delete.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {


                try
                {
                    string query = null;
                    if (textBox1.Text != null)
                    {
                        query = "Delete from Student where RegId='" + Convert.ToInt32(textBox1.Text) + "' ";
                    }
                    else
                    {
                        throw new Exception("RegID is empty, cannot delete");
                    }

                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    SqlDataReader data = sqlCommand.ExecuteReader();
                    MessageBox.Show("Deleted Successfully. Please Refresh it");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Sql Error: {ex.Message}");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");

                }

            }
            else
            {
                MessageBox.Show("Deletion Cancelled.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\mylocaldb;Initial Catalog=StudentManagement;Integrated Security=True");
            try
            {

                DateTime date = dateTimePicker1.Value;
                string formattedDate = date.ToString("yyyy-MM-dd");
                if (textBox1.Text == null)
                {
                    MessageBox.Show("Fill it");
                    throw new Exception("Reg Id is empty. Cannot update");
                }
                string query = "Update Student SET Name='" + textBox2.Text + "', FatherName='" + textBox3.Text + "', CNIC= '" + textBox4.Text + "', Gender='" + comboBox1.SelectedItem + "', DOB='" + formattedDate + "', Address= '" + textBox5.Text + "' , DegreeProgram='" + listBox1.SelectedItem + "' , MatricGrade= '" + comboBox2.SelectedItem + "', InterGrade= '" + comboBox3.SelectedItem + "' WHERE RegID= '" + Convert.ToInt32(textBox1.Text) + "' ";

                con.Open();

                SqlCommand sqlCommand = new SqlCommand(query, con);
                SqlDataReader data = sqlCommand.ExecuteReader();
                con.Close();
                MessageBox.Show("Updated Successfully.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error: {ex.Message}");
            }      
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}");
            }


        }

    }
}


