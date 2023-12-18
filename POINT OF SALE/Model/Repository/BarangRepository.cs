using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POINT_OF_SALE.Model.Context;
using POINT_OF_SALE.Model.Entity;
using System.Data.SqlClient;
using System.Data;

namespace POINT_OF_SALE.Model.Repository
{
    public class BarangRepository
    {
        private SqlConnection _conn;

        public BarangRepository(DBContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Barang barang)
        {
            int result = 0;
            string sql = @"INSERT INTO products (id_product, product_name, stock, price) VALUES (@barangid, @namabarang, @stok, @price)";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@barangid", barang.BarangId);
                cmd.Parameters.AddWithValue("@namabarang", barang.BarangName);
                cmd.Parameters.AddWithValue("@stok", barang.StokBarang);
                cmd.Parameters.AddWithValue("@price", barang.Price);

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

        public int Update(Barang barang)
        {
            int result = 0;
            string sql = @"UPDATE products SET product_name = @namabarang, stock = @stok, price = @harga WHERE id_product = @barangid";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@barangid", barang.BarangId);
                cmd.Parameters.AddWithValue("@namabarang", barang.BarangName);
                cmd.Parameters.AddWithValue("@stok", barang.StokBarang);
                cmd.Parameters.AddWithValue("@harga", barang.Price);

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

        public int Delete(Barang barang)
        {
            int result = 0;
            string sql = @"DELETE FROM products WHERE id_product = @barangid";

            using (SqlCommand cmd = new SqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@barangid", barang.BarangId);
                cmd.Parameters.AddWithValue("@namabarang", barang.BarangName);
                cmd.Parameters.AddWithValue("@stok", barang.StokBarang);
                cmd.Parameters.AddWithValue("@harga", barang.Price);

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
