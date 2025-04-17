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

namespace BookHeven.Forms.BookManagement
{
    public partial class NewBookLatest : Form
    {
        private string title;
        private string selectedAuther;
        private string selectedPublisher;
        private string selectedGenre;
        private string iSBN;
        private string price;
        private string quantity;
        //private string connectionString = "server=localhost;database=bookhaven;uid=root;pwd=1234;";
        private MySqlConnection connection;

        public NewBookLatest()
        {
            InitializeComponent();
            connection = DataSourceConfig.GetConnection();
            LoadAuthors();
            LoadGenres();
            LoadBooks();
        }

        private void LoadAuthors()
        {
            try
            {
                connection.Open();
                string query = "SELECT author_id, CONCAT(first_name, ' ', last_name) AS name FROM authors";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                List<Author> list = new List<Author>();
                while (reader.Read())
                {
                    list.Add(new Author() { ID = reader["author_id"].ToString(), Name = reader["name"].ToString() });
                }
                cmbAuthor.DataSource = list;
                cmbAuthor.ValueMember = "ID";
                cmbAuthor.DisplayMember = "Name";
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading authors: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadGenres()
        {
            try
            {
                connection.Open();
                string query = "SELECT genre_id, name FROM genres";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                List<Genre> list = new List<Genre>();
                while (reader.Read())
                {
                    list.Add(new Genre() { ID = reader["genre_id"].ToString(), Name = reader["name"].ToString() });
                }
                cmbGenre.DataSource = list;
                cmbGenre.ValueMember = "ID";
                cmbGenre.DisplayMember = "Name";
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading genres: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            this.title = txtTitle.Text;
        }

        private void cmbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedAuthor = (Author)cmbAuthor.SelectedItem;
            this.selectedAuther = selectedAuthor.ID;
        }

        private void cmbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedGenre = cmbGenre.Text;
        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            this.iSBN = txtISBN.Text;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            this.price = txtPrice.Text;
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            this.quantity = txtQuantity.Text;
        }
        private void LoadBooks()
        {
            try
            {
                connection.Open();
                string query = @"
                    SELECT b.*, CONCAT(a.first_name, ' ', a.last_name) AS author_name, g.name AS genre_name
                    FROM books b
                    LEFT JOIN authors a ON a.author_id = b.author_id
                    LEFT JOIN genres g ON g.genre_id = b.genre_id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvBook.DataSource = dataTable;
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

        //under construction
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = @"
                    SELECT b.*, CONCAT(a.first_name, ' ', a.last_name) AS author_name, g.name AS genre_name
                    FROM books b
                    LEFT JOIN authors a ON a.author_id = b.author_id
                    LEFT JOIN genres g ON g.genre_id = b.genre_id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvBook.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating the book: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
 class Author
{
    public string ID { get; set; }
    public string Name { get; set; }
}
class Genre
{
    public string ID { get; set; }
    public string Name { get; set; }
}