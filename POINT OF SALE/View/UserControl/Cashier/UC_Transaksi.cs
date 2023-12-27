using CrystalDecisions.CrystalReports.Engine;
using POINT_OF_SALE.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POINT_OF_SALE.Controller.Cashier
{
    public partial class UC_Transaksi : UserControl
    {
        public string CashierName {  get; set; }

        Transaction transact = new Transaction();
        private DetailTransactionController detailTransactController;
        private TransactionController transactionController;
        private UserController userController;
        private PaymentController paymentController;
        private SqlConnection _conn;
        private DataTable tempDataTable;
        public UC_Transaksi()
        {
            InitializeComponent();
           
            string connString = @"Data Source=DESKTOP-Q6I09KV\SQLEXPRESS;initial catalog=DB_POS;integrated security=true";
            _conn = new SqlConnection(connString);
            detailTransactController = new DetailTransactionController();
            transactionController = new TransactionController();
            userController = new UserController();
            paymentController = new PaymentController();
            ShowDataGridBarang();
            txt_iddetail.Text = GenerateDetailTransactionID();

            // menampilkan data karyawan
            var employeeList = userController.GetEmployeeNameByPosition();
            cmb_datauser.DataSource = employeeList;
            cmb_datauser.DisplayMember = "firstName";

            cmb_datauser.SelectedIndexChanged += cmb_datauser_SelectedIndexChanged;

            //menampilkan data metode pembayaran
            var paymentList = paymentController.GetPaymentName();
            cmb_metodepayment.DataSource = paymentList;
            cmb_metodepayment.DisplayMember = "Method";

            cmb_metodepayment.SelectedIndexChanged += cmb_metodepayment_SelectedIndexChanged;
            //ShowDataGridDetailBarang();
            //TemporaryDataDetail();

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
            try
            {
                int valQty, valTotal;

                if (int.TryParse(txt_jumlahbarang.Text, out valQty) && int.TryParse(txt_hargabarang.Text, out valTotal))
                {
                    valTotal *= valQty;  // Kalkulasi total

                    TemporaryDataDetail();

                    DataRow newRow = tempDataTable.NewRow();
                    newRow["id_detailtransact"] = txt_iddetail.Text;
                    newRow["id_product"] = txt_kodebarang.Text;
                    newRow["product_name"] = txt_namabarang.Text;
                    newRow["qty"] = valQty;
                    newRow["total"] = valTotal;

                    tempDataTable.Rows.Add(newRow);

                    dgv_detail.DataSource = tempDataTable;
                    TemporaryDataDetail();
                    ClearInputFields();
                    HitungTotalSementara();

                    int totalProdukSementara = GetTotalProdukSementara();
                    lbl_jumlahproduk.Text = totalProdukSementara.ToString();
                }
                else
                {
                    MessageBox.Show("Qty or Total is not a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            txt_kodebarang.Clear();
            txt_namabarang.Clear();
            txt_jumlahbarang.Clear();
            txt_hargabarang.Clear();
        }

        public void ShowDataGridBarang()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM products";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(rd);
                            dgv_barang.DataSource = dt;
                            dgv_barang.Columns[0].HeaderText = "ID Barang";
                            dgv_barang.Columns[1].HeaderText = "Nama Barang";
                            dgv_barang.Columns[2].HeaderText = "Stok Barang";
                            dgv_barang.Columns[3].HeaderText = "Harga Barang";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void TemporaryDataDetail()
        {
            if (tempDataTable == null)
            {
                tempDataTable = new DataTable();
                tempDataTable.Columns.Add("id_detailtransact");
                tempDataTable.Columns.Add("id_product");
                tempDataTable.Columns.Add("product_name");
                tempDataTable.Columns.Add("qty", typeof(int));
                tempDataTable.Columns.Add("total", typeof(int));
            }
        }
        private void HitungTotalSementara()
        {
            int total = 0;

            foreach (DataGridViewRow row in dgv_detail.Rows)
            {
                if (row.Cells["total"].Value != null)
                {
                    total += Convert.ToInt32(row.Cells["total"].Value);
                }
            }

            lbl_value.Text = total.ToString();
        }

        private int GetTotalProdukSementara()
        {
            int totalRows = dgv_detail.Rows.Count > 1 ? dgv_detail.Rows.Count - 1 : dgv_detail.Rows.Count;
            return totalRows;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                SaveDetailTransactions();
                SaveTransaction();
                

                printStruk();

                // Clear all controls after successful save
                ClearAllControls();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveDetailTransactions()
        {
            try
            {
                foreach (DataRow row in tempDataTable.Rows)
                {
                    DetailTransaction detailTransact = new DetailTransaction();
                    detailTransact.IdDetailTransaction = row["id_detailtransact"].ToString();
                    detailTransact.ProductID = row["id_product"].ToString();
                    detailTransact.Qty = Convert.ToInt32(row["qty"]);
                    detailTransact.Total = Convert.ToInt32(row["total"]);
                    detailTransactController.Create(detailTransact);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving detail transactions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; // Re-throw the exception to propagate it to the caller
            }
            finally
            {
                // Close the connection after attempting to save detail transactions
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }

        private void SaveTransaction()
        {
            try
            {
                int totalProduct = Convert.ToInt32(lbl_jumlahproduk.Text);
                int grandTotal = Convert.ToInt32(lbl_value.Text);
                int totalPayment = Convert.ToInt32(txt_tunai.Text);
                int kembalian = totalPayment - grandTotal;

                transact.IdTransaction = txt_idtransact.Text;
                transact.TotalProduct = totalProduct;
                transact.DateTime = DateTime.Now;
                transact.GrandTotal = grandTotal;
                transact.TotalPayment = totalPayment;
                transact.Kembalian = kembalian;
                transact.IdPayment = txt_idpayment.Text;
                transact.IdEmployee = txt_iduser.Text;
                transact.IdDetailTransact =txt_iddetail.Text;

                transactionController.Create(transact);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; // Re-throw the exception to propagate it to the caller
            }
        }


        private void cmb_datauser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_datauser.SelectedItem != null)
            {
                string selectedEmployeeId = ((Employee)cmb_datauser.SelectedItem).IdEmployee;

                // Use parameterized query to avoid SQL injection
                string sql = "SELECT id_employee FROM employee WHERE id_employee = @employeeId";

                try
                {
                    if (_conn.State == ConnectionState.Closed)
                        _conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, _conn))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", selectedEmployeeId);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            txt_iduser.Text = result.ToString();
                        }
                        else
                        {
                            txt_iduser.Text = string.Empty;
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

        private void cmb_metodepayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_metodepayment.SelectedItem != null)
            {
                string selectedPaymentId = ((Payment)cmb_metodepayment.SelectedItem).PaymentId;

                // Use parameterized query to avoid SQL injection
                string sql = "SELECT id_payment FROM payment WHERE id_payment = @paymentId";

                try
                {
                    if (_conn.State == ConnectionState.Closed)
                        _conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, _conn))
                    {
                        cmd.Parameters.AddWithValue("@paymentId", selectedPaymentId);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            txt_idpayment.Text = result.ToString();
                        }
                        else
                        {
                            txt_idpayment.Text = string.Empty;
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

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            try
            {
                SaveDetailTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void ClearAllControls()
        {
            // Clear DataGridView
            dgv_detail.DataSource = null;
            dgv_detail.Rows.Clear();
            dgv_detail.Columns.Clear();
            tempDataTable.Clear();

            // Clear TextBoxes
            txt_kodebarang.Clear();
            txt_namabarang.Clear();
            txt_jumlahbarang.Clear();
            txt_hargabarang.Clear();
            txt_iduser.Clear();
            txt_idpayment.Clear();
            txt_tunai.Clear();
            txt_idtransact.Clear();
            txt_iddetail.Clear();
            txt_iddetail.Text = GenerateDetailTransactionID();

            // Clear Labels
            lbl_value.Text = "0";
            lbl_jumlahproduk.Text = "0";


            // Refresh DataGridView
            dgv_detail.Refresh();
        }

        private string GenerateDetailTransactionID()
        {
            string prefix = "ORD";
            int currentNumber = GetNextDetailTransactionNumber(); // Implement GetNextDetailTransactionNumber() untuk mendapatkan nomor urut berikutnya

            // Format nomor urut ke dalam format "000" (misal: 001, 002)
            string formattedNumber = currentNumber.ToString("000");

            return $"{prefix}{formattedNumber}";
        }

        private int GetNextDetailTransactionNumber()
        {
            int lastNumber = 0;

            try
            {
                if (_conn.State == ConnectionState.Closed)
                    _conn.Open();

                string sql = "SELECT MAX(CAST(SUBSTRING(id_detailtransact, 4, LEN(id_detailtransact) - 3) AS INT)) AS MaxID FROM detailtransacts";
                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        lastNumber = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting next detail transaction number: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }

            return lastNumber + 1;
        }

    }
}
