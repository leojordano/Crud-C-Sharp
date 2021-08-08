using App1.Db;
using App1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1.Views
{
    public partial class ListClients : Form
    {
        public ListClients()
        {
            InitializeComponent();
        }

        private void ListClients_Load(object sender, EventArgs e)
        {
            DbClient c = new DbClient();
            List<Client> ClientList = c.ListClients();
            var list = ListViewClients;
            list.Items.Clear();

            foreach (Client cli in ClientList) {
                var row = new string[] { cli.Id.ToString(), cli.Name, cli.Email, cli.Adress, cli.Cpf };
                var li = new ListViewItem(row);
                li.Tag = cli;

                list.Items.Add(li);
            }
        }

        private void ClientsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListViewClients_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListViewClients.SelectedItems.Count >= 1)
            {
                ListViewItem item = ListViewClients.SelectedItems[0];

                //here i check for the Mouse pointer location on click if its contained 
                // in the actual selected item's bounds or not .
                // cuz i ran into a problem with the ui once because of that ..
                if (item.Bounds.Contains(e.Location))
                {
                    MessageBox.Show("Double Clicked on :" + item.Text);
                }
            }
        }
    }
}
