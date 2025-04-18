namespace BookHeven.Forms.OrderManagement
{
    partial class AddNewOrder
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
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tblPnlDataEntry = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_BookQuantity = new System.Windows.Forms.Label();
            this.num_Quantity = new System.Windows.Forms.NumericUpDown();
            this.lbl_addedBooks = new System.Windows.Forms.Label();
            this.btnAuthorSave = new System.Windows.Forms.Button();
            this.btn_AddBook = new System.Windows.Forms.Button();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBooks = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblPnlDataEntry.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(13, 12, 4, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Add New Order";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tblPnlDataEntry, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1196, 715);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tblPnlDataEntry
            // 
            this.tblPnlDataEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblPnlDataEntry.ColumnCount = 1;
            this.tblPnlDataEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPnlDataEntry.Controls.Add(this.panel1, 0, 6);
            this.tblPnlDataEntry.Controls.Add(this.lbl_addedBooks, 0, 7);
            this.tblPnlDataEntry.Controls.Add(this.btnAuthorSave, 0, 9);
            this.tblPnlDataEntry.Controls.Add(this.btn_AddBook, 0, 8);
            this.tblPnlDataEntry.Controls.Add(this.cmbBooks, 0, 5);
            this.tblPnlDataEntry.Controls.Add(this.cmbCustomers, 0, 3);
            this.tblPnlDataEntry.Controls.Add(this.label5, 0, 0);
            this.tblPnlDataEntry.Controls.Add(this.lblBooks, 0, 4);
            this.tblPnlDataEntry.Location = new System.Drawing.Point(3, 55);
            this.tblPnlDataEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblPnlDataEntry.Name = "tblPnlDataEntry";
            this.tblPnlDataEntry.RowCount = 10;
            this.tblPnlDataEntry.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPnlDataEntry.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPnlDataEntry.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPnlDataEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tblPnlDataEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tblPnlDataEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tblPnlDataEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tblPnlDataEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tblPnlDataEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tblPnlDataEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlDataEntry.Size = new System.Drawing.Size(1190, 414);
            this.tblPnlDataEntry.TabIndex = 0;
            this.tblPnlDataEntry.Paint += new System.Windows.Forms.PaintEventHandler(this.tblPnlDataEntry_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_BookQuantity);
            this.panel1.Controls.Add(this.num_Quantity);
            this.panel1.Location = new System.Drawing.Point(3, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 25);
            this.panel1.TabIndex = 3;
            // 
            // lbl_BookQuantity
            // 
            this.lbl_BookQuantity.AutoSize = true;
            this.lbl_BookQuantity.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_BookQuantity.Location = new System.Drawing.Point(0, 0);
            this.lbl_BookQuantity.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lbl_BookQuantity.Name = "lbl_BookQuantity";
            this.lbl_BookQuantity.Size = new System.Drawing.Size(115, 16);
            this.lbl_BookQuantity.TabIndex = 27;
            this.lbl_BookQuantity.Text = "Available Quantity";
            // 
            // num_Quantity
            // 
            this.num_Quantity.Location = new System.Drawing.Point(219, 3);
            this.num_Quantity.Name = "num_Quantity";
            this.num_Quantity.Size = new System.Drawing.Size(55, 22);
            this.num_Quantity.TabIndex = 23;
            // 
            // lbl_addedBooks
            // 
            this.lbl_addedBooks.AutoSize = true;
            this.lbl_addedBooks.Location = new System.Drawing.Point(3, 204);
            this.lbl_addedBooks.Name = "lbl_addedBooks";
            this.lbl_addedBooks.Size = new System.Drawing.Size(0, 16);
            this.lbl_addedBooks.TabIndex = 26;
            // 
            // btnAuthorSave
            // 
            this.btnAuthorSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAuthorSave.Location = new System.Drawing.Point(743, 371);
            this.btnAuthorSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnAuthorSave.Name = "btnAuthorSave";
            this.btnAuthorSave.Size = new System.Drawing.Size(443, 34);
            this.btnAuthorSave.TabIndex = 25;
            this.btnAuthorSave.Text = "Save";
            this.btnAuthorSave.UseVisualStyleBackColor = true;
            this.btnAuthorSave.Click += new System.EventHandler(this.btnAuthorSave_Click);
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_AddBook.Location = new System.Drawing.Point(743, 320);
            this.btn_AddBook.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(443, 32);
            this.btn_AddBook.TabIndex = 2;
            this.btn_AddBook.Text = "Add Book";
            this.btn_AddBook.UseVisualStyleBackColor = true;
            this.btn_AddBook.Click += new System.EventHandler(this.btn_addBook_Click);
            // 
            // cmbBooks
            // 
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(3, 128);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(452, 24);
            this.cmbBooks.TabIndex = 20;
            this.cmbBooks.SelectedIndexChanged += new System.EventHandler(this.bookValueChanged);
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(3, 43);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(452, 24);
            this.cmbCustomers.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Customers";
            // 
            // lblBooks
            // 
            this.lblBooks.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBooks.AutoSize = true;
            this.lblBooks.Location = new System.Drawing.Point(13, 95);
            this.lblBooks.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(46, 16);
            this.lblBooks.TabIndex = 1;
            this.lblBooks.Text = "Books";
            // 
            // AddNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 715);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddNewOrder";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tblPnlDataEntry.ResumeLayout(false);
            this.tblPnlDataEntry.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Quantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tblPnlDataEntry;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Button btnAuthorSave;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Button btn_AddBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_BookQuantity;
        private System.Windows.Forms.NumericUpDown num_Quantity;
        private System.Windows.Forms.Label lbl_addedBooks;
    }
}