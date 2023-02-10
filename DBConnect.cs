using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace G_Pro_Try
{
    class DBConnect
    {
        private SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Nadeeshani\Documents\WECAREdb.mdf;Integrated Security=True;Connect Timeout=30");

        public SqlConnection Getcon()
        {
            return Connection; 
        }
        
        public void OpenCon()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }

        }

        public void CloseCon()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }
        }
    }
}
