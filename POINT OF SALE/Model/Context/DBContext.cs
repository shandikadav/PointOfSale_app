using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POINT_OF_SALE.Model.Context
{
    public class DBContext : IDisposable
    {
        private SqlConnection _conn;

        public SqlConnection Conn { get { return _conn ?? (_conn = GetSqlConnection()); } }

        private SqlConnection GetSqlConnection()
        {
            SqlConnection conn = null;
            try
            {
                string connString = @"Data Source=DESKTOP-Q6I09KV\SQLEXPRESS;initial catalog=DB_POS;integrated security=true";
                conn = new SqlConnection(connString);
                conn.Open();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
            }
            return conn;
        }

        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }
            GC.SuppressFinalize(this);
        }

    }
}

