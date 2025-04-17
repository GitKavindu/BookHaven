using BookHeven.Forms.BookManagement;
using BookHeven.Forms.CustomerManagement;
using BookHeven.Forms.AuthorManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHeven.Forms
{
    public partial class BookHevenDashBoard: Form
    {

        private Form activeForm = null;

        public BookHevenDashBoard()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            //customizeDesign();
            //panelBookISubMenu.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelBookISubMenu);
        }

        private void customizeDesign() {
            panelBookISubMenu.Visible = false;
            panelCustomerMSubMenu.Visible = false;
            panelOrderMSubMenu.Visible = false;
            panelSupplierMSubMenu.Visible = false;
        }
        private void HideSubMenu()
        {
         
            if (panelBookISubMenu.Visible == true)
                panelBookISubMenu.Visible = false;
            if (panelCustomerMSubMenu.Visible == true)
                panelCustomerMSubMenu.Visible = false;
            if (panelOrderMSubMenu.Visible == true)
                panelOrderMSubMenu.Visible = false;
            if (panelSupplierMSubMenu.Visible == true)
                panelSupplierMSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu) {
            if (subMenu.Visible == false)
            {
                /*HideSubMenu();*/
                subMenu.Visible = true;
            }
            else {
                subMenu.Visible = false;
            }
        }

        private void OpenChildForm(Form childForm){
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            btnAddNewCustomer.Controls.Add(childForm);
            btnAddNewCustomer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AllBookView());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelCustomerMSubMenu);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelOrderMSubMenu);
        }

        private void btnSupplierManagement_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSupplierMSubMenu);
        }

        private void panelChild_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NewBookLatest());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddNewCustomer());
        }

        private void btnAuthor_Add(object sender, EventArgs e)
        {
            OpenChildForm(new AddNewAuthor());
        }
    }
}
