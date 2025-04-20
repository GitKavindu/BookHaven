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

namespace BookHeven.Forms.OrderManagement
{
    public partial class AllOrders : Form
    {
        MySqlConnection connection;
        public AllOrders()
        {
            InitializeComponent();
            connection = DataSourceConfig.GetConnection();
        }

        private void AllOrders_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                connection.Open();
                string query = @"
                    select o.order_id,CONCAT(c.first_name, ' ', c.last_name) AS customer,o.order_date,b.title,i.quantity,i.unit_price as price,o.total_amount 
                    from orders o
                    inner join order_items i on i.order_id=o.order_id
                    inner join customers c on c.customer_id=o.customer_id
                    inner join books b on b.book_id=i.book_id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                grid_Order.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

