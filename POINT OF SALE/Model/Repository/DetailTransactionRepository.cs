using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POINT_OF_SALE.Model.Context;
using POINT_OF_SALE.Model.Entity;
using System.Data.SqlClient;

namespace POINT_OF_SALE.Model.Repository
{
    public class DetailTransactionRepository
    {
        private SqlConnection _conn;

        public DetailTransactionRepository(DBContext context)
        {
            _conn = context.Conn;
        }

        public int Create(DetailTransaction detailTransact)
        {
            int result = 0;
            string sql = @"INSERT INTO detailtransacts VALUES (@idDetailTransaction, @productid, @qty, @total)";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idDetailTransaction", detailTransact.IdDetailTransaction);
                cmd.Parameters.AddWithValue("@productid", detailTransact.ProductID);
                cmd.Parameters.AddWithValue("@qty", detailTransact.Qty);
                cmd.Parameters.AddWithValue("@total", detailTransact.Total);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
                }
            }
            return result;
        }
    }
}
