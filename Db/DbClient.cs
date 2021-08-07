using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Models;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace App1.Db
{
    class DbClient
    {
        public void AddClient(Client c)
        {
            Conn conn = new Conn();
            conn.ConnectToDatabase();

            if (conn.Connection.State == ConnectionState.Open) {
                try
                {
                    string sql = $"INSERT INTO `clients`( `name`, `email`, `adress`, `cpf`) VALUES ( '{c.Name}', '{c.Email}', '{c.Adress}', '{c.Cpf}' )";
                    MySqlCommand SqlCmm = new MySqlCommand(sql, conn.Connection);
                    MySqlDataReader Reader;
                    Reader = SqlCmm.ExecuteReader();
                }
                catch 
                {
                    MessageBox.Show("Não foi possivel adicionar o usuario");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable ListClients() 
        {
            DataTable dt = new DataTable();
            Conn conn = new Conn();
            conn.ConnectToDatabase();

            if (conn.Connection.State == ConnectionState.Open)
            {
                string sql = $"SELECT * FROM `clients`";
                MySqlCommand SqlCmm = new MySqlCommand(sql, conn.Connection);
                MySqlDataAdapter res = new MySqlDataAdapter();
                res.SelectCommand = SqlCmm;
                res.Fill(dt);
                conn.CloseConnection();
            }

            return dt;
        }
    }
}
