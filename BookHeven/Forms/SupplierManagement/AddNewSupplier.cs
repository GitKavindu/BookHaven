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

namespace BookHeven.Forms.SupplierManagement
{
    public partial class AddNewSupplier: Form
    {
        MySqlConnection connection;
        public AddNewSupplier()
        {
            InitializeComponent();
            connection =DataSourceConfig.GetConnection();
            LoadSuppliers();
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
                string query = "INSERT INTO suppliers (name,email,phone,address) VALUES (@name,@email,@phone,@address)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                
                
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
               

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                LoadSuppliers();
            }
        }

        private void LoadSuppliers()
        {
            try
            {
                connection.Open();
                string query = @" SELECT * FROM suppliers";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                AuthorGrid.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
