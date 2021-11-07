using HackerWe.Entities;
using HackerWe.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackerWe.UI
{
    public partial class BorrowingUserControl : UserControl
    {
        Borowing borowing;

        public BorrowingUserControl()
        {
            InitializeComponent();
        }

        private void BorrowingUserControl_Load(object sender, EventArgs e)
        {
            Reset();
            dtpBorrowingDate.MaxDate = DateTime.Now.AddDays(2);

            cmbBooks.DataSource = Library.RelevantBooks;
            cmbBooks.DisplayMember = "Name";
            cmbBooks.Text = "";






            comboBox1.DataSource = Library.ClientList;
            comboBox1.DisplayMember = "FullName";
            comboBox1.Text = "";
        }

        ClientsUserControl ClientsUserControl32 = new ClientsUserControl();
        private void dtpBorrowingDate_ValueChanged(object sender, EventArgs e)
        {
            borowing.BorowingDate = dtpBorrowingDate.Value;
            lblDueReturningdate.Text = borowing.DueReturningDate.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (comboBox1.Text == "")
            {
                lblClientValidMessage.Text = "This is must";
                flag = false;
            }
            if (cmbBooks.Text == "")
            {
                lblMessageBook.Text = "This is must";
                flag = false;

            }
            else
            {

                
                //borowing.Client = (Client)comboBox1.SelectedItem;
               // borowing.Book = cmbBooks.SelectedItem as Book;

                Library.Borowings.Add(borowing);
                Library.SaveBorrowings();
                MessageBox.Show("Borrowing sucsses");

                cmbBooks.Text = "";
                comboBox1.Text = "";
                lblMessageBook.Text = string.Empty;


                //this.Controls.Clear();

                //ClientsUserControl32.Show();
                //3. Send mail to client
            }

        }

        private void Reset()
        {
            borowing=new Borowing();
            
            lblClientValidMessage.Text = string.Empty;
            

            dtpBorrowingDate.MinDate = DateTime.Now;
            dtpBorrowingDate.Value = DateTime.Now;
            
        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "FullName";
            if (comboBox1.SelectedItem != null)
                lblClientValidMessage.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
