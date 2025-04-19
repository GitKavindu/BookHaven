using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BookHeven.config;

namespace BookHeven.Forms
{
    public partial class Login : Form
    {
        private string userName;
        private string password;
        //private string connectionString = "Server=127.0.0.1;Port=3000;Database=bookhaven;Uid=root;Pwd=1234;";

        private MySqlConnection connection;

        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            
            connection = new MySqlConnection(DataSourceConfig.GetConnection().ConnectionString);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userName = txtUserName.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            password = txtPassword.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and Password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ValidateLogin(userName, password)) {

                try
                {
                    connection.Open();
                    string query = "SELECT role FROM users WHERE UserName=@UserName";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    DataSourceConfig.role=cmd.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }

                Form dashboard = new BookHevenDashBoard();
                dashboard.Show();
                this.Hide();
              }
            
            else
            {
                MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateLogin(string userName, string password)
        {
         
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(1) FROM users WHERE UserName=@UserName AND Password=@Password";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Password", password);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count == 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally {
                    connection.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
