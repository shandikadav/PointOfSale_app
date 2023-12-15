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
    public class PaymentRepository
    {
        private SqlConnection _conn;
        public PaymentRepository(DBContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Payment payment)
        {
            int result = 0;
            string sql = @"INSERT INTO payment VALUES (@paymentid, @method)";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@paymentid", payment.PaymentId);
                cmd.Parameters.AddWithValue("@method", payment.Method);
                

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

        public int Update(Payment payment)
        {
            int result = 0;
            string sql = @"UPDATE payment SET metode = @method WHERE id_payment = @paymentid";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@paymentid", payment.PaymentId);
                cmd.Parameters.AddWithValue("@method", payment.Method);


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

        public int Delete(Payment payment)
        {
            int result = 0;
            string sql = @"DELETE FROM payment WHERE id_payment = @paymentid";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@paymentid", payment.PaymentId);
                cmd.Parameters.AddWithValue("@method", payment.Method);


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