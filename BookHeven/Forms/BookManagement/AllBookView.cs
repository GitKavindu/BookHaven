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
    public partial class AllBookView : Form
    {
        public AllBookView()
        {
            InitializeComponent();
            LoadAllBooks();
        }

        private void LoadAllBooks()
        {
           // string connectionString = "server=localhost;database=bookhaven;uid=root;pwd=1234;";
            string query = @"
                    SELECT b.book_id, b.title, b.author, b.genre, b.isbn, b.price, b.stock_quantity, s.name as supplier_name
                    FROM books b
                    LEFT JOIN suppliers s ON b.supplier_id = s.supplier_id";

            using (MySqlConnection connection = DataSourceConfig.GetConnection())
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                gridAllBooks.DataSource = dataTable;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
