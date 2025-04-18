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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookHeven.Forms.OrderManagement
{
    public partial class AddNewOrder: Form
    {
        MySqlConnection connection;
        List<Book> orderBooks;
        List<Book> booklist;
        public AddNewOrder()
        {
            InitializeComponent();
            connection =DataSourceConfig.GetConnection();
            // LoadSuppliers();
            LoadBooks();
            LoadCustomers();
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

        
        private void LoadBooks()
        {
            try
            {
                connection.Open();
                string query = "select price,book_id,title,stock_quantity from books where stock_quantity>0";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                 booklist= new List<Book>();
                 orderBooks= new List<Book>();
                 
                while (reader.Read())
                {
                    booklist.Add(new Book() { book_id = int.Parse( reader["book_id"].ToString() ) , title = reader["title"].ToString() ,stock_quantity=int.Parse(reader["stock_quantity"].ToString()), price = double.Parse(reader["price"].ToString())});
                }
                cmbBooks.DataSource = booklist;
                cmbBooks.ValueMember = "book_id";
                cmbBooks.DisplayMember = "title";
                reader.Close();
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

        private void LoadCustomers()
        {
            try
            {
                connection.Open();
                string query = "select customer_id,CONCAT(a.first_name, ' ', a.last_name) AS customer_name from customers a;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                List<Customer> list = new List<Customer>();
                while (reader.Read())
                {
                    list.Add(new Customer() {customer_id = int.Parse(reader["customer_id"].ToString()), customer_name = reader["customer_name"].ToString() });
                }
                cmbCustomers.DataSource = list;
                cmbCustomers.ValueMember = "customer_id";
                cmbCustomers.DisplayMember = "customer_name";
                reader.Close();
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

        private void btnAdd_Author(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO suppliers (name,email,phone,address) VALUES (@name,@email,@phone,@address)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                
                
                cmd.Parameters.AddWithValue("@name", cmbBooks.SelectedValue);
                //cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                //cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                //cmd.Parameters.AddWithValue("@address", txtAddress.Text);
               

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                
            }
        }

        

        private void btn_addBook_Click(object sender, EventArgs e)
        {
            int removeIndex=cmbBooks.SelectedIndex;
            
            if (cmbBooks.Items.Count > 0)
            {
                AddToOrder(int.Parse(cmbBooks.SelectedValue.ToString()), int.Parse(num_Quantity.Text));

                List<Book> temp = booklist;
                temp.RemoveAt(removeIndex);
                booklist= temp;

                cmbBooks.DataSource = null;
                cmbBooks.Items.Clear();
                cmbBooks.DataSource = booklist; 

                cmbBooks.ValueMember = "book_id";
                cmbBooks.DisplayMember = "title";

                //lbl_addedBooks.Text=lbl_addedBooks.Text+$"{cmbBooks.SelectedText} - {booklist.}";
                cmbCustomers.Enabled= false;
                
            }   
        }

        
        private void AddToOrder(int bookId,int quantity)
        {
            
            foreach(Book book in booklist) 
            {
                if(book.book_id==bookId)
                {
                    Book Addbook = book;
                    Addbook.stock_quantity = quantity;
                    orderBooks.Add(Addbook);
                    break;
                }
            }
            Renderbooks();
        }

        private void Renderbooks()
        {
            lbl_addedBooks.Text = "";
            foreach (Book book in orderBooks) 
            {
                lbl_addedBooks.Text = lbl_addedBooks.Text + $"\n {book.title} - {book.stock_quantity} : Rs.{book.price*book.stock_quantity}";
            }
        }

        private void bookValueChanged(object sender, EventArgs e)
        {
            if(cmbBooks.SelectedItem!=null)
            {
                int removeIndex = cmbBooks.SelectedIndex;
                num_Quantity.Minimum = 1;
                num_Quantity.Maximum = booklist[removeIndex].stock_quantity;
                lbl_BookQuantity.Text = $"Available Quantity:{booklist[removeIndex].stock_quantity}";
            }
            
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAuthorSave_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO orders (customer_id,order_date,status,total_amount) VALUES (@customer_id,@order_date,@status,@total_amount)";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@customer_id", cmbCustomers.SelectedValue);
                cmd.Parameters.AddWithValue("@order_date", DateTime.Now); //DateTime.Now.ToString("yyyy-MM-dd")
                cmd.Parameters.AddWithValue("@status", "Pending");
                cmd.Parameters.AddWithValue("@total_amount",calculateTotal());

                cmd.ExecuteNonQuery();

                query = "SELECT MAX(order_id) FROM orders";
                cmd = new MySqlCommand(query, connection);
                int orderid=int.Parse(cmd.ExecuteScalar().ToString());
                
                foreach(Book orders in orderBooks) 
                {
                    int currentQuantity;
                    query = "SELECT stock_quantity FROM books WHERE book_id=@book_id";
                    cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@book_id", orders.book_id);
                    currentQuantity= int.Parse(cmd.ExecuteScalar().ToString());

                    if(currentQuantity > orders.stock_quantity)
                    {
                        //update table books
                        query = "UPDATE books SET stock_quantity=@stock_quantity WHERE book_id=@book_id";
                        cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@book_id", orders.book_id);
                        cmd.Parameters.AddWithValue("@stock_quantity", currentQuantity - orders.stock_quantity);
                        cmd.ExecuteNonQuery();

                        //Insert data to order_items table
                        query = "INSERT INTO order_items (order_id,book_id,quantity,unit_price) VALUES (@order_id,@book_id,@quantity,@unit_price)";
                        cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@order_id", orderid);
                        cmd.Parameters.AddWithValue("@book_id", orders.book_id);
                        cmd.Parameters.AddWithValue("@quantity", orders.stock_quantity);
                        cmd.Parameters.AddWithValue("@unit_price", orders.price * orders.stock_quantity);
                        cmd.ExecuteNonQuery();
                        
                    }
                    else 
                    {
                        throw new ArgumentOutOfRangeException("current quantity is not sufficient to process this request!");
                    }  
                }

                MessageBox.Show("Order Placed sucessfully!!");
            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Can't process: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                RefreshList();
            }
        }

        private void RefreshList()
        {
            LoadBooks();
            lbl_addedBooks.Text= "";
            cmbCustomers.Enabled= true;
        }

        private double calculateTotal()
        {
            double Total=0;
            foreach(Book book in orderBooks) 
            {
               Total=Total+(book.stock_quantity*book.price);
            }

            return Total;
        }
    }

    public class Book
    {
        public int book_id { get; set; }
        public int stock_quantity { get; set; }
        public string title { get; set; }
        public double price { get; set; }
    }

    public class Customer
    {
        public int customer_id { get; set; }
        public string customer_name { get; set; }
    }
}
