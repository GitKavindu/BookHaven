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

namespace BookHeven.Forms.CustomerManagement
{
    public partial class AddNewCustomer: Form
    {
        private MySqlConnection connection;
        public AddNewCustomer()
        {
            InitializeComponent();
            connection = DataSourceConfig.GetConnection();
            this.LoadCustomers();
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string query = @"
                    INSERT INTO customers (first_name,last_name,email,phone,address) 
                    VALUES (@first_name,@last_name,@email,@phone,@address)";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating the book: " + ex.Message);
            }
            finally
            {
                connection.Close();
                this.LoadCustomers();
            }
        }

        private void LoadCustomers()
        {
            try
            {
                connection.Open();
                string query = @"
                    SELECT customer_id,first_name,last_name,email,phone,address,created_at FROM customers;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                CustomerGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
