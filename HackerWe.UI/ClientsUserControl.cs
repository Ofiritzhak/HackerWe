using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HackerWe.Entities;
using HackerWe.Logic;

namespace HackerWe.UI
{
    public partial class ClientsUserControl : UserControl
    {
        
        public ClientsUserControl()
        {
            InitializeComponent();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Client c = new Client(txtIDNumber.Text, txtFirstName.Text, txtLastName.Text, txtEmaie.Text, txtPhoneNumber.Text);
            Library.ClientList.Add(c);
            Library.SaveClients();
            MessageBox.Show("Client Saved");
            
            //borrowingUserControl1.Parent = this;
            //borrowingUserControl1.Show();
            //borrowingUserControl1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
        }

        private void ClientsUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
