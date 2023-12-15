using POINT_OF_SALE.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POINT_OF_SALE.Controller
{
    public partial class UC_DataPayment : UserControl
    {
        Payment payment = new Payment();
        private PaymentController paymentController;
        private SqlConnection _conn;
        public UC_DataPayment()
        {
            InitializeComponent();
            string connString = @"Data Source=DESKTOP-Q6I09KV\SQLEXPRESS;initial catalog=DB_POS;integrated security=true";
            _conn = new SqlConnection(connString);
            paymentController = new PaymentController();
            ShowDataGrid();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            payment.PaymentId = txt_paymentid.Text;
            payment.Method = cmb_method.Text;

            paymentController.Create(payment);
            ShowDataGrid();
            ClearData();
        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            payment.PaymentId = txt_paymentid.Text;
            payment.Method = cmb_method.Text;

            paymentController.Update(payment);
            ShowDataGrid();
            ClearData();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            payment.PaymentId = txt_paymentid.Text;
            payment.Method = cmb_method.Text;

            paymentController.Delete(payment);
            ShowDataGrid();
            ClearData();
        }

        public void ShowDataGrid()
        {
            try
            {
                _conn.Open();
                string sql = "SELECT * FROM payment";
                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rd);
                    dgv_payment.DataSource = dt;
                    dgv_payment.Columns[0].HeaderText = "ID Payment";
                    dgv_payment.Columns[1].HeaderText = "Metode Payment";
                    
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

        private void dgv_payment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_payment.Rows[e.RowIndex];

                txt_paymentid.Text = row.Cells["id_payment"].Value.ToString();
                cmb_method.Text = row.Cells["metode"].Value.ToString();
                
            }
        }

        private void ClearData()
        {
            txt_paymentid.Text = "";
            cmb_method.Text = "";
            txt_paymentid.Focus();
        }

        private void UC_DataPayment_Load(object sender, EventArgs e)
        {

        }
    }
}
