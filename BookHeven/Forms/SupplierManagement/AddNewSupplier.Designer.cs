namespace BookHeven.Forms.SupplierManagement
{
    partial class AddNewSupplier
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tblPnlDataEntry = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAuthorSave = new System.Windows.Forms.Button();
            this.AuthorGrid = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblPnlDataEntry.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tblPnlDataEntry, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AuthorGrid, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1196, 715);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tblPnlDataEntry
            // 
            this.tblPnlDataEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblPnlDataEntry.ColumnCount = 4;
            this.tblPnlDataEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPnlDataEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tblPnlDataEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPnlDataEntry.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tblPnlDataEntry.Controls.Add(this.txtAddress, 0, 3);
            this.tblPnlDataEntry.Controls.Add(this.lbl_address, 0, 3);
            this.tblPnlDataEntry.Controls.Add(this.label2, 0, 0);
            this.tblPnlDataEntry.Controls.Add(this.label4, 0, 1);
            this.tblPnlDataEntry.Controls.Add(this.label5, 0, 2);
            this.tblPnlDataEntry.Controls.Add(this.txtName, 1, 0);
            this.tblPnlDataEntry.Controls.Add(this.txtEmail, 1, 1);
            this.tblPnlDataEntry.Controls.Add(this.txtPhone, 1, 2);
            this.tblPnlDataEntry.Controls.Add(this.tableLayoutPanel2, 3, 3);
            this.tblPnlDataEntry.Location = new System.Drawing.Point(3, 55);
            this.tblPnlDataEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblPnlDataEntry.Name = "tblPnlDataEntry";
            this.tblPnlDataEntry.RowCount = 4;
            this.tblPnlDataEntry.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPnlDataEntry.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPnlDataEntry.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPnlDataEntry.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlDataEntry.Size = new System.Drawing.Size(1190, 207);
            this.tblPnlDataEntry.TabIndex = 0;
            this.tblPnlDataEntry.Paint += new System.Windows.Forms.PaintEventHandler(this.tblPnlDataEntry_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(97, 12);
            this.txtName.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(504, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(97, 58);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(504, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(97, 104);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(504, 22);
            this.txtPhone.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAuthorSave, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(618, 142);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(568, 61);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.Location = new System.Drawing.Point(290, 12);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 37);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAuthorSave
            // 
            this.btnAuthorSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAuthorSave.Location = new System.Drawing.Point(431, 12);
            this.btnAuthorSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnAuthorSave.Name = "btnAuthorSave";
            this.btnAuthorSave.Size = new System.Drawing.Size(133, 37);
            this.btnAuthorSave.TabIndex = 1;
            this.btnAuthorSave.Text = "Save";
            this.btnAuthorSave.UseVisualStyleBackColor = true;
            this.btnAuthorSave.Click += new System.EventHandler(this.btnAdd_Author);
            // 
            // AuthorGrid
            // 
            this.AuthorGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorGrid.Location = new System.Drawing.Point(13, 313);
            this.AuthorGrid.Margin = new System.Windows.Forms.Padding(13, 49, 13, 25);
            this.AuthorGrid.Name = "AuthorGrid";
            this.AuthorGrid.RowHeadersWidth = 51;
            this.AuthorGrid.Size = new System.Drawing.Size(1170, 377);
            this.AuthorGrid.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(13, 12, 4, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Add New Supplier";
            // 
            // lbl_address
            // 
            this.lbl_address.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(13, 164);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(58, 16);
            this.lbl_address.TabIndex = 14;
            this.lbl_address.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(97, 161);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(504, 22);
            this.txtAddress.TabIndex = 15;
            // 
            // AddNewAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 715);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddNewAuthor";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tblPnlDataEntry.ResumeLayout(false);
            this.tblPnlDataEntry.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AuthorGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView AuthorGrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tblPnlDataEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAuthorSave;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbl_address;
    }
}