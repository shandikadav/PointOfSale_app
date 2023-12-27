using CrystalDecisions.CrystalReports.Engine;
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
    public partial class UC_DetailTransaksi : UserControl
    {
        private SqlConnection _conn;
        public UC_DetailTransaksi()
        {
            InitializeComponent();
            string connString = @"Data Source=DESKTOP-Q6I09KV\SQLEXPRESS;initial catalog=DB_POS;integrated security=true";
            _conn = new SqlConnection(connString);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            printStruk();
        }

        private void printStruk()
        {
            try
            {
                ReportDocument crypt = new ReportDocument();
                DataSet ds;

                if (_conn.State == ConnectionState.Closed)
                    _conn.Open();

                string sql = @"SELECT tb_transaksi.id_transact, tb_transaksi.total_product, tb_transaksi.date, tb_transaksi.grand_total, tb_transaksi.dibayarkan, tb_transaksi.kembalian, tb_transaksi.id_payment, tb_transaksi.id_employee, tb_transaksi.id_detailtransact, detailtransacts.qty, detailtransacts.total, payment.metode, employee.firstName, products.product_name, products.price FROM tb_transaksi
                            INNER JOIN detailtransacts ON tb_transaksi.id_detailtransact = detailtransacts.id_detailtransact
                            INNER JOIN payment ON tb_transaksi.id_payment = payment.id_payment 
                            INNER JOIN employee ON tb_transaksi.id_employee = employee.id_employee
                            INNER JOIN products ON detailtransacts.id_product = products.id_product
                            WHERE id_transact = @idTransact";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    // Add a parameter to the command
                    cmd.Parameters.AddWithValue("@idTransact", txt_idtransact.Text);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd)) // Pass the command to the SqlDataAdapter
                    {
                        ds = new DataSet();
                        da.Fill(ds, "tb_transaksi");
                        crypt.Load(@"D:\IT Software\Projects\C#\POINT OF SALE\POINT OF SALE\ReportPembayaran.rpt");
                        crypt.SetDataSource(ds.Tables["tb_transaksi"]);
                        crystalReportViewer1.ReportSource = crypt;
                        crystalReportViewer1.Visible = true;
                    }
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
                    _conn.Close();
                }
            }
        }
    }
}
