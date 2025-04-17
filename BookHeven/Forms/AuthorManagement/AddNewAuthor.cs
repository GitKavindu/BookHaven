using BookHeven.config;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHeven.Forms.AuthorManagement
{
    public partial class AddNewAuthor: Form
    {
        MySqlConnection connection;
        public AddNewAuthor()
        {
            InitializeComponent();
            connection =DataSourceConfig.GetConnection();
            LoadBooks();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tblPnlDataEntry_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
        private void btnAdd_Author(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO authors (first_name,last_name,email) VALUES (@first_name,@last_name,@email)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                
                
                cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            finally
            {
                connection.Close();
                LoadBooks();
            }
        }

        private void LoadBooks()
        {
            try
            {
                connection.Open();
                string query = @" SELECT author_id,first_name,last_name,email FROM authors";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                AuthorGrid.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
