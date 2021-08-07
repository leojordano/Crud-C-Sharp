using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace App1.Db
{
    class Conn
    {
        static readonly string Host = "localhost";
        static readonly string User = "root";
        static readonly string Db = "testing";
        static readonly string Pass = "";
        public ConnectionState State;
        public MySqlConnection Connection;
        private DataSet bdDataSet;

        public void ConnectToDatabase() 
        {
            bdDataSet = new DataSet();
            string ConnString = $"server={Host};user={User};Database={Db};port=3306;;SslMode=none;password=";
            //var ConnString = "Persist Security  Info=False;server=localhost;database=teste;uid=root;server=localhost;database=test;uid=root;pwd=''";

            if (State == ConnectionState.Closed)
            {
                Connection = new MySqlConnection(ConnString);
                try
                {
                    Connection.Open();
                    State = ConnectionState.Open;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    State = ConnectionState.Closed;
                }
            }
        }

        public void CloseConnection() {
            Connection.Close();
        }
    }
}
