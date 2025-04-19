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
            this.UserPnl = new System.Windows.Forms.Panel();
            this.btn_UserAdd = new System.Windows.Forms.Button();
            this.btn_UserManage = new System.Windows.Forms.Button();
            this.AuthorPanel = new System.Windows.Forms.Panel();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btn_Author = new System.Windows.Forms.Button();
            this.SuplierPanel = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelOrderMSubMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btn_PlaceOrder = new System.Windows.Forms.Button();
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
            this.UserPnl.SuspendLayout();
            this.AuthorPanel.SuspendLayout();
            this.SuplierPanel.SuspendLayout();
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
            this.panelSideMenu.Controls.Add(this.UserPnl);
            this.panelSideMenu.Controls.Add(this.btn_UserManage);
            this.panelSideMenu.Controls.Add(this.AuthorPanel);
            this.panelSideMenu.Controls.Add(this.btn_Author);
            this.panelSideMenu.Controls.Add(this.SuplierPanel);
            this.panelSideMenu.Controls.Add(this.button4);
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
            this.panelSideMenu.Size = new System.Drawing.Size(399, 1010);
            this.panelSideMenu.TabIndex = 0;
            // 
            // UserPnl
            // 
            this.UserPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.UserPnl.Controls.Add(this.btn_UserAdd);
            this.UserPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserPnl.Location = new System.Drawing.Point(0, 921);
            this.UserPnl.Margin = new System.Windows.Forms.Padding(4);
            this.UserPnl.Name = "UserPnl";
            this.UserPnl.Size = new System.Drawing.Size(399, 45);
            this.UserPnl.TabIndex = 29;
            this.UserPnl.Visible = false;
            // 
            // btn_UserAdd
            // 
            this.btn_UserAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_UserAdd.FlatAppearance.BorderSize = 0;
            this.btn_UserAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UserAdd.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UserAdd.ForeColor = System.Drawing.Color.Black;
            this.btn_UserAdd.Location = new System.Drawing.Point(0, 0);
            this.btn_UserAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_UserAdd.Name = "btn_UserAdd";
            this.btn_UserAdd.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btn_UserAdd.Size = new System.Drawing.Size(399, 34);
            this.btn_UserAdd.TabIndex = 20;
            this.btn_UserAdd.Text = "Add New User";
            this.btn_UserAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UserAdd.UseVisualStyleBackColor = true;
            this.btn_UserAdd.Click += new System.EventHandler(this.btn_UserAdd_Click_1);
            // 
            // btn_UserManage
            // 
            this.btn_UserManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(211)))), ((int)(((byte)(191)))));
            this.btn_UserManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_UserManage.Enabled = false;
            this.btn_UserManage.FlatAppearance.BorderSize = 0;
            this.btn_UserManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UserManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UserManage.ForeColor = System.Drawing.Color.Black;
            this.btn_UserManage.Location = new System.Drawing.Point(0, 871);
            this.btn_UserManage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_UserManage.Name = "btn_UserManage";
            this.btn_UserManage.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btn_UserManage.Size = new System.Drawing.Size(399, 50);
            this.btn_UserManage.TabIndex = 27;
            this.btn_UserManage.Text = "User Management";
            this.btn_UserManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UserManage.UseVisualStyleBackColor = false;
            this.btn_UserManage.Click += new System.EventHandler(this.btn_UserAdd_Click);
            // 
            // AuthorPanel
            // 
            this.AuthorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.AuthorPanel.Controls.Add(this.btnAddAuthor);
            this.AuthorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthorPanel.Location = new System.Drawing.Point(0, 824);
            this.AuthorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.AuthorPanel.Name = "AuthorPanel";
            this.AuthorPanel.Size = new System.Drawing.Size(399, 47);
            this.AuthorPanel.TabIndex = 26;
            this.AuthorPanel.Visible = false;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddAuthor.FlatAppearance.BorderSize = 0;
            this.btnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAuthor.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.ForeColor = System.Drawing.Color.Black;
            this.btnAddAuthor.Location = new System.Drawing.Point(0, 0);
            this.btnAddAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnAddAuthor.Size = new System.Drawing.Size(399, 37);
            this.btnAddAuthor.TabIndex = 19;
            this.btnAddAuthor.Text = "Add New Author";
            this.btnAddAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAuthor_Add);
            // 
            // btn_Author
            // 
            this.btn_Author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(211)))), ((int)(((byte)(191)))));
            this.btn_Author.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Author.FlatAppearance.BorderSize = 0;
            this.btn_Author.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Author.ForeColor = System.Drawing.Color.Black;
            this.btn_Author.Location = new System.Drawing.Point(0, 776);
            this.btn_Author.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Author.Name = "btn_Author";
            this.btn_Author.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btn_Author.Size = new System.Drawing.Size(399, 48);
            this.btn_Author.TabIndex = 24;
            this.btn_Author.Text = "Author Management";
            this.btn_Author.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Author.UseVisualStyleBackColor = false;
            this.btn_Author.Click += new System.EventHandler(this.btn_Author_Click_1);
            // 
            // SuplierPanel
            // 
            this.SuplierPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.SuplierPanel.Controls.Add(this.button13);
            this.SuplierPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SuplierPanel.Location = new System.Drawing.Point(0, 729);
            this.SuplierPanel.Margin = new System.Windows.Forms.Padding(4);
            this.SuplierPanel.Name = "SuplierPanel";
            this.SuplierPanel.Size = new System.Drawing.Size(399, 47);
            this.SuplierPanel.TabIndex = 19;
            this.SuplierPanel.Visible = false;
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Top;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.Black;
            this.button13.Location = new System.Drawing.Point(0, 0);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.button13.Size = new System.Drawing.Size(399, 33);
            this.button13.TabIndex = 19;
            this.button13.Text = "Add New Supplier";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.btnAdd_Supplier);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(0, 672);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(399, 57);
            this.button4.TabIndex = 17;
            this.button4.Text = "Supplier Management";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // panelOrderMSubMenu
            // 
            this.panelOrderMSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.panelOrderMSubMenu.Controls.Add(this.button1);
            this.panelOrderMSubMenu.Controls.Add(this.button8);
            this.panelOrderMSubMenu.Controls.Add(this.btn_PlaceOrder);
            this.panelOrderMSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrderMSubMenu.Location = new System.Drawing.Point(0, 519);
            this.panelOrderMSubMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelOrderMSubMenu.Name = "panelOrderMSubMenu";
            this.panelOrderMSubMenu.Size = new System.Drawing.Size(399, 153);
            this.panelOrderMSubMenu.TabIndex = 4;
            this.panelOrderMSubMenu.Visible = false;
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
            this.button1.Size = new System.Drawing.Size(399, 41);
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
            this.button8.Size = new System.Drawing.Size(399, 49);
            this.button8.TabIndex = 1;
            this.button8.Text = "button8";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btn_PlaceOrder
            // 
            this.btn_PlaceOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PlaceOrder.FlatAppearance.BorderSize = 0;
            this.btn_PlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlaceOrder.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlaceOrder.ForeColor = System.Drawing.Color.Black;
            this.btn_PlaceOrder.Location = new System.Drawing.Point(0, 0);
            this.btn_PlaceOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PlaceOrder.Name = "btn_PlaceOrder";
            this.btn_PlaceOrder.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btn_PlaceOrder.Size = new System.Drawing.Size(399, 49);
            this.btn_PlaceOrder.TabIndex = 0;
            this.btn_PlaceOrder.Text = "PlaceOrder";
            this.btn_PlaceOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PlaceOrder.UseVisualStyleBackColor = true;
            this.btn_PlaceOrder.Click += new System.EventHandler(this.btn_PlaceOrder_Click);
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
            this.btnOrderManagement.Size = new System.Drawing.Size(399, 57);
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
            this.panelCustomerMSubMenu.Size = new System.Drawing.Size(399, 153);
            this.panelCustomerMSubMenu.TabIndex = 3;
            this.panelCustomerMSubMenu.Visible = false;
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
            this.button5.Size = new System.Drawing.Size(399, 31);
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
            this.button6.Size = new System.Drawing.Size(399, 49);
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
            this.button7.Size = new System.Drawing.Size(399, 49);
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
            this.btnCustomerManagement.Size = new System.Drawing.Size(399, 57);
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
            this.panelBookISubMenu.Size = new System.Drawing.Size(399, 101);
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
            this.btnAddNewBook.Size = new System.Drawing.Size(399, 49);
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
            this.btnVewAllBooks.Size = new System.Drawing.Size(399, 49);
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
            this.btnBookInventoryManagement.Size = new System.Drawing.Size(399, 57);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(399, 94);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(391, 86);
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
            this.btnAddNewCustomer.Size = new System.Drawing.Size(1186, 1010);
            this.btnAddNewCustomer.TabIndex = 4;
            this.btnAddNewCustomer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChild_Paint);
            // 
            // BookHevenDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 1010);
            this.Controls.Add(this.btnAddNewCustomer);
            this.Controls.Add(this.panelSideMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BookHevenDashBoard";
            this.Text = "Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSideMenu.ResumeLayout(false);
            this.UserPnl.ResumeLayout(false);
            this.AuthorPanel.ResumeLayout(false);
            this.SuplierPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelOrderMSubMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btn_PlaceOrder;
        private System.Windows.Forms.Button btnOrderManagement;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel SuplierPanel;
        private System.Windows.Forms.Panel AuthorrPanel;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel AuthorPanel;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btn_Author;
        private System.Windows.Forms.Panel UserPnl;
        private System.Windows.Forms.Button btn_UserAdd;
        private System.Windows.Forms.Button btn_UserManage;
    }
}