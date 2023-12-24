using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POINT_OF_SALE.Controller.Cashier
{
    public partial class UC_Transaksi : UserControl
    {
        private SqlConnection _conn;
        public UC_Transaksi()
        {
            InitializeComponent();
            string connString = @"Data Source=DESKTOP-Q6I09KV\SQLEXPRESS;initial catalog=DB_POS;integrated security=true";
            _conn = new SqlConnection(connString);
            ShowDataGridBarang();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UC_Transaksi_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {

        }

        public void ShowDataGridBarang()
        {
            try
            {
                _conn.Open();
                string sql = "SELECT * FROM products";
                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rd);
                    dgv_barang.DataSource = dt;
                    dgv_barang.Columns[0].HeaderText = "ID Barang";
                    dgv_barang.Columns[1].HeaderText = "Nama Barang";
                    dgv_barang.Columns[2].HeaderText = "Stok Barang";
                    dgv_barang.Columns[3].HeaderText = "Harga Barang";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close(); // Close the connection in the finally block
                }
            }
        }

        private void dgv_barang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_barang.Rows[e.RowIndex];

                txt_kodebarang.Text = row.Cells["id_product"].Value.ToString();
                txt_namabarang.Text = row.Cells["product_name"].Value.ToString();
                txt_jumlahbarang.Text = row.Cells["stock"].Value.ToString();
                txt_hargabarang.Text = row.Cells["price"].Value.ToString();

            }
        }
    }
}
