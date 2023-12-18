using POINT_OF_SALE.Model.Entity;
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

namespace POINT_OF_SALE.Controller
{
    public partial class UC_DataBarang : UserControl
    {
        Barang barang = new Barang();
        private BarangController barangController;
        private SqlConnection _conn;
        public UC_DataBarang()
        {
            InitializeComponent();
            string connString = @"Data Source=DESKTOP-Q6I09KV\SQLEXPRESS;initial catalog=DB_POS;integrated security=true";
            _conn = new SqlConnection(connString);
            barangController = new BarangController();
            ShowDataGrid();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            var valStok = int.Parse(txt_stokbarang.Text);
            var valPrice = int.Parse(txt_hargabarang.Text);
            barang.BarangId = txt_barangid.Text;
            barang.BarangName = txt_barangname.Text;
            barang.StokBarang = valStok;
            barang.Price = valPrice;

            barangController.Create(barang);
            ShowDataGrid();
            ClearData();
        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            var valStok = int.Parse(txt_stokbarang.Text);
            var valPrice = int.Parse(txt_hargabarang.Text);
            barang.BarangId = txt_barangid.Text;
            barang.BarangName = txt_barangname.Text;
            barang.StokBarang = valStok;
            barang.Price = valPrice;

            barangController.Update(barang);
            ShowDataGrid();
            ClearData();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            barang.BarangId = txt_barangid.Text;
            barang.BarangName = txt_barangname.Text;
            barang.StokBarang = int.Parse(txt_stokbarang.Text);
            barang.Price = int.Parse(txt_hargabarang.Text);

            barangController.Delete(barang);
            ShowDataGrid();
            ClearData();
        }

        public void ShowDataGrid()
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

                txt_barangid.Text = row.Cells["id_product"].Value.ToString();
                txt_barangname.Text = row.Cells["product_name"].Value.ToString();
                txt_stokbarang.Text = row.Cells["stock"].Value.ToString();
                txt_hargabarang.Text = row.Cells["price"].Value.ToString();
                
            }
        }

        private void ClearData()
        {
            txt_barangid.Text = "";
            txt_barangname.Text = "";
            txt_hargabarang.Text = "";
            txt_stokbarang.Text = "";
            txt_barangid.Focus();
        }

        private void txt_stokbarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_hargabarang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
