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
    public class TransactionRepository
    {
        private SqlConnection _conn;

        public TransactionRepository(DBContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Transaction transaction)
        {
            int result = 0;
            string sql = @"INSERT INTO tb_transaksi VALUES (@idTransact, @totalProduct, @date, @grandTotal, @totalPayment, @kembalian, @idPayment, @idEmployee, @idDetailTransact)";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@idTransact", transaction.IdTransaction);
                cmd.Parameters.AddWithValue("@totalProduct", transaction.TotalProduct);
                cmd.Parameters.AddWithValue("@date", transaction.DateTime);
                cmd.Parameters.AddWithValue("@grandTotal", transaction.GrandTotal);
                cmd.Parameters.AddWithValue("@totalPayment", transaction.TotalPayment);
                cmd.Parameters.AddWithValue("@kembalian", transaction.Kembalian);
                cmd.Parameters.AddWithValue("@idPayment", transaction.IdPayment);
                cmd.Parameters.AddWithValue("@idEmployee", transaction.IdEmployee);
                cmd.Parameters.AddWithValue("@idDetailTransact", transaction.IdDetailTransact);

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
