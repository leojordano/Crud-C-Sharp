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
using App1.Models;

namespace App1.Views
{
    public partial class new_client : Form
    {
        private InitialScreen Parent;
        public new_client(InitialScreen InitialScreen )
        {
            InitializeComponent();
            this.Parent = InitialScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void new_client_Load(object sender, EventArgs e)
        {
            //Parent.Hide();
        }

        private void new_client_FormClosed(object sender, EventArgs e) 
        {
            Parent.Show();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Parent.Show();
            this.Close();
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            DbClient c = new DbClient();
            Client Obj = new Client {
                Name = c_name.Text,
                Adress = c_adress.Text,
                Email = c_email.Text,
                Cpf = c_cpf.Text
            };

            c.AddClient(Obj);
        }

    }
}
