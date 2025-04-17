namespace BookHeven.Forms
{
    partial class BookHevenDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookHevenDashBoard));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelSupplierMSubMenu = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btnSupplierManagement = new System.Windows.Forms.Button();
            this.panelOrderMSubMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnOrderManagement = new System.Windows.Forms.Button();
            this.panelCustomerMSubMenu = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnCustomerManagement = new System.Windows.Forms.Button();
            this.panelBookISubMenu = new System.Windows.Forms.Panel();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.btnVewAllBooks = new System.Windows.Forms.Button();
            this.btnBookInventoryManagement = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.btnAddNewCustomer = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelSupplierMSubMenu.SuspendLayout();
            this.panelOrderMSubMenu.SuspendLayout();
            this.panelCustomerMSubMenu.SuspendLayout();
            this.panelBookISubMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(211)))), ((int)(((byte)(191)))));
            this.panelSideMenu.Controls.Add(this.button3);
            this.panelSideMenu.Controls.Add(this.button2);
            this.panelSideMenu.Controls.Add(this.panelSupplierMSubMenu);
            this.panelSideMenu.Controls.Add(this.btnSupplierManagement);
            this.panelSideMenu.Controls.Add(this.panelOrderMSubMenu);
            this.panelSideMenu.Controls.Add(this.btnOrderManagement);
            this.panelSideMenu.Controls.Add(this.panelCustomerMSubMenu);
            this.panelSideMenu.Controls.Add(this.btnCustomerManagement);
            this.panelSideMenu.Controls.Add(this.panelBookISubMenu);
            this.panelSideMenu.Controls.Add(this.btnBookInventoryManagement);
            this.panelSideMenu.Controls.Add(this.tableLayoutPanel1);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(399, 939);
            this.panelSideMenu.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(0, 939);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(378, 49);
            this.button3.TabIndex = 16;
            this.button3.Text = "Add New Author";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnAuthor_Add);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(0, 882);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(378, 57);
            this.button2.TabIndex = 15;
            this.button2.Text = "Author Management";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panelSupplierMSubMenu
            // 
            this.panelSupplierMSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.panelSupplierMSubMenu.Controls.Add(this.button10);
            this.panelSupplierMSubMenu.Controls.Add(this.button11);
            this.panelSupplierMSubMenu.Controls.Add(this.button12);
            this.panelSupplierMSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSupplierMSubMenu.Location = new System.Drawing.Point(0, 729);
            this.panelSupplierMSubMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelSupplierMSubMenu.Name = "panelSupplierMSubMenu";
            this.panelSupplierMSubMenu.Size = new System.Drawing.Size(378, 153);
            this.panelSupplierMSubMenu.TabIndex = 6;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button10.Location = new System.Drawing.Point(0, 98);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(378, 54);
            this.button10.TabIndex = 2;
            this.button10.Text = "button10";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button11.Location = new System.Drawing.Point(0, 49);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button11.Size = new System.Drawing.Size(378, 49);
            this.button11.TabIndex = 1;
            this.button11.Text = "button11";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Black;
            this.button12.Location = new System.Drawing.Point(0, 0);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(378, 49);
            this.button12.TabIndex = 0;
            this.button12.Text = "Add supplier";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // btnSupplierManagement
            // 
            this.btnSupplierManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupplierManagement.FlatAppearance.BorderSize = 0;
            this.btnSupplierManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplierManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierManagement.ForeColor = System.Drawing.Color.Black;
            this.btnSupplierManagement.Location = new System.Drawing.Point(0, 672);
            this.btnSupplierManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupplierManagement.Name = "btnSupplierManagement";
            this.btnSupplierManagement.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnSupplierManagement.Size = new System.Drawing.Size(378, 57);
            this.btnSupplierManagement.TabIndex = 7;
            this.btnSupplierManagement.Text = "Supplier Management";
            this.btnSupplierManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplierManagement.UseVisualStyleBackColor = true;
            this.btnSupplierManagement.Click += new System.EventHandler(this.btnSupplierManagement_Click);
            // 
            // panelOrderMSubMenu
            // 
            this.panelOrderMSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.panelOrderMSubMenu.Controls.Add(this.button1);
            this.panelOrderMSubMenu.Controls.Add(this.button8);
            this.panelOrderMSubMenu.Controls.Add(this.button9);
            this.panelOrderMSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrderMSubMenu.Location = new System.Drawing.Point(0, 519);
            this.panelOrderMSubMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelOrderMSubMenu.Name = "panelOrderMSubMenu";
            this.panelOrderMSubMenu.Size = new System.Drawing.Size(378, 153);
            this.panelOrderMSubMenu.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, 98);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(378, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(0, 49);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(378, 49);
            this.button8.TabIndex = 1;
            this.button8.Text = "button8";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(378, 49);
            this.button9.TabIndex = 0;
            this.button9.Text = "button9";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // btnOrderManagement
            // 
            this.btnOrderManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderManagement.FlatAppearance.BorderSize = 0;
            this.btnOrderManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderManagement.ForeColor = System.Drawing.Color.Black;
            this.btnOrderManagement.Location = new System.Drawing.Point(0, 462);
            this.btnOrderManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderManagement.Name = "btnOrderManagement";
            this.btnOrderManagement.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnOrderManagement.Size = new System.Drawing.Size(378, 57);
            this.btnOrderManagement.TabIndex = 5;
            this.btnOrderManagement.Text = "Order Management";
            this.btnOrderManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderManagement.UseVisualStyleBackColor = true;
            this.btnOrderManagement.Click += new System.EventHandler(this.btnOrderManagement_Click);
            // 
            // panelCustomerMSubMenu
            // 
            this.panelCustomerMSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.panelCustomerMSubMenu.Controls.Add(this.button5);
            this.panelCustomerMSubMenu.Controls.Add(this.button6);
            this.panelCustomerMSubMenu.Controls.Add(this.button7);
            this.panelCustomerMSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCustomerMSubMenu.Location = new System.Drawing.Point(0, 309);
            this.panelCustomerMSubMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelCustomerMSubMenu.Name = "panelCustomerMSubMenu";
            this.panelCustomerMSubMenu.Size = new System.Drawing.Size(378, 153);
            this.panelCustomerMSubMenu.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(0, 98);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(378, 54);
            this.button5.TabIndex = 2;
            this.button5.Text = "button5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(0, 49);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(378, 49);
            this.button6.TabIndex = 1;
            this.button6.Text = "button6";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(378, 49);
            this.button7.TabIndex = 0;
            this.button7.Text = "Add New Customer";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnCustomerManagement
            // 
            this.btnCustomerManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerManagement.FlatAppearance.BorderSize = 0;
            this.btnCustomerManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerManagement.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerManagement.Location = new System.Drawing.Point(0, 252);
            this.btnCustomerManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomerManagement.Name = "btnCustomerManagement";
            this.btnCustomerManagement.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnCustomerManagement.Size = new System.Drawing.Size(378, 57);
            this.btnCustomerManagement.TabIndex = 3;
            this.btnCustomerManagement.Text = "Customer Management";
            this.btnCustomerManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerManagement.UseVisualStyleBackColor = true;
            this.btnCustomerManagement.Click += new System.EventHandler(this.btnCustomerManagement_Click);
            // 
            // panelBookISubMenu
            // 
            this.panelBookISubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.panelBookISubMenu.Controls.Add(this.btnAddNewBook);
            this.panelBookISubMenu.Controls.Add(this.btnVewAllBooks);
            this.panelBookISubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBookISubMenu.Location = new System.Drawing.Point(0, 151);
            this.panelBookISubMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelBookISubMenu.Name = "panelBookISubMenu";
            this.panelBookISubMenu.Size = new System.Drawing.Size(378, 101);
            this.panelBookISubMenu.TabIndex = 2;
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNewBook.FlatAppearance.BorderSize = 0;
            this.btnAddNewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewBook.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBook.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewBook.Location = new System.Drawing.Point(0, 49);
            this.btnAddNewBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnAddNewBook.Size = new System.Drawing.Size(378, 49);
            this.btnAddNewBook.TabIndex = 1;
            this.btnAddNewBook.Text = "Add New Book";
            this.btnAddNewBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // btnVewAllBooks
            // 
            this.btnVewAllBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVewAllBooks.FlatAppearance.BorderSize = 0;
            this.btnVewAllBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVewAllBooks.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVewAllBooks.ForeColor = System.Drawing.Color.Black;
            this.btnVewAllBooks.Location = new System.Drawing.Point(0, 0);
            this.btnVewAllBooks.Margin = new System.Windows.Forms.Padding(4);
            this.btnVewAllBooks.Name = "btnVewAllBooks";
            this.btnVewAllBooks.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnVewAllBooks.Size = new System.Drawing.Size(378, 49);
            this.btnVewAllBooks.TabIndex = 0;
            this.btnVewAllBooks.Text = "View Books";
            this.btnVewAllBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVewAllBooks.UseVisualStyleBackColor = true;
            this.btnVewAllBooks.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBookInventoryManagement
            // 
            this.btnBookInventoryManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookInventoryManagement.FlatAppearance.BorderSize = 0;
            this.btnBookInventoryManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookInventoryManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookInventoryManagement.ForeColor = System.Drawing.Color.Black;
            this.btnBookInventoryManagement.Location = new System.Drawing.Point(0, 94);
            this.btnBookInventoryManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBookInventoryManagement.Name = "btnBookInventoryManagement";
            this.btnBookInventoryManagement.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnBookInventoryManagement.Size = new System.Drawing.Size(378, 57);
            this.btnBookInventoryManagement.TabIndex = 0;
            this.btnBookInventoryManagement.Text = "Book Inventory ";
            this.btnBookInventoryManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookInventoryManagement.UseVisualStyleBackColor = true;
            this.btnBookInventoryManagement.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 94);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(186)))), ((int)(((byte)(161)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(370, 86);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(76, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "BOOK HEAVEN";
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            this.btnAddNewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCustomer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(399, 0);
            this.btnAddNewCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(1250, 939);
            this.btnAddNewCustomer.TabIndex = 4;
            this.btnAddNewCustomer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChild_Paint);
            // 
            // BookHevenDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 939);
            this.Controls.Add(this.btnAddNewCustomer);
            this.Controls.Add(this.panelSideMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BookHevenDashBoard";
            this.Text = "Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSideMenu.ResumeLayout(false);
            this.panelSupplierMSubMenu.ResumeLayout(false);
            this.panelOrderMSubMenu.ResumeLayout(false);
            this.panelCustomerMSubMenu.ResumeLayout(false);
            this.panelBookISubMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnBookInventoryManagement;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.Panel panelBookISubMenu;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Button btnVewAllBooks;
        private System.Windows.Forms.Panel panelCustomerMSubMenu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnCustomerManagement;
        private System.Windows.Forms.Panel btnAddNewCustomer;
        private System.Windows.Forms.Panel panelSupplierMSubMenu;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btnSupplierManagement;
        private System.Windows.Forms.Panel panelOrderMSubMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnOrderManagement;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}