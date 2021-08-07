using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App1.Db;

namespace App1.Views
{
    public partial class InitialScreen : Form
    {
        public InitialScreen()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new_client NovoCliente = new new_client(this);
            NovoCliente.ShowDialog();
        }

        private void InitialScreen_Load(object sender, EventArgs e)
        {
            DbClient c = new DbClient();
            ClientsGridView.DataSource = c.ListClients();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbClient c = new DbClient();
            ClientsGridView.DataSource = c.ListClients();
        }
    }
}
