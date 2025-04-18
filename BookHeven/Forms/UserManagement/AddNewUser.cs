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

namespace BookHeven.Forms.UserManagement
{
    public partial class AddNewUser: Form
    {
        MySqlConnection connection;
        public AddNewUser()
        {
            InitializeComponent();
            connection =DataSourceConfig.GetConnection();
            LoadUsers();
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

        
        private void btnAdd_User(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO users (username,password,role,email,full_name,created_at) VALUES (@username,@password,@role,@email,@full_name,@created_at)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                
                
                cmd.Parameters.AddWithValue("@username", txtName.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@role", lbl_Admin.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@full_name", txtFullName.Text);
                cmd.Parameters.AddWithValue("@created_at", DateTime.Now);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                LoadUsers();
            }
        }

        private void LoadUsers()
        {
            try
            {
                connection.Open();
                string query = @"SELECT username,role,email,full_name,created_at FROM users;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                UserGrid.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnUserFuncChange_Click(object sender, EventArgs e)
        {

        }

        private void btn_UsrRoleChange(object sender, EventArgs e)
        {
            if(lbl_Admin.Text=="Admin")
            {
                lbl_Admin.Text = "Sales Clerk";
            }
            else 
            {
                lbl_Admin.Text = "Admin";
            }
        }
    }
}
