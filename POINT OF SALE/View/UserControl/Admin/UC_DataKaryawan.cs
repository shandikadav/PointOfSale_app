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
    public partial class UC_DataKaryawan : UserControl
    {
        Employee employee = new Employee();
        private EmployeeController employeeController;
        private SqlConnection _conn;
        public UC_DataKaryawan()
        {
            InitializeComponent();
            string connString = @"Data Source=DESKTOP-Q6I09KV\SQLEXPRESS;initial catalog=DB_POS;integrated security=true";
            _conn = new SqlConnection(connString);
            employeeController = new EmployeeController();
            ShowDataGrid();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            employee.IdEmployee = txt_employeeid.Text;
            employee.FirstName = txt_firstname.Text;
            employee.Email = txt_email.Text;
            employee.LastName = txt_lastname.Text;
            employee.Contact = txt_contact.Text;
            employee.Potition = cmb_position.Text;

            employeeController.Create(employee);
            ShowDataGrid();
            ClearData();
        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            employee.IdEmployee = txt_employeeid.Text;
            employee.FirstName = txt_firstname.Text;
            employee.Email = txt_email.Text;
            employee.LastName = txt_lastname.Text;
            employee.Contact = txt_contact.Text;
            employee.Potition = cmb_position.Text;

            employeeController.Update(employee);
            ShowDataGrid();
            ClearData();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            employee.IdEmployee = txt_employeeid.Text;
            employee.FirstName = txt_firstname.Text;
            employee.Email = txt_email.Text;
            employee.LastName = txt_lastname.Text;
            employee.Contact = txt_contact.Text;
            employee.Potition = cmb_position.Text;

            employeeController.Delete(employee);
            ShowDataGrid();
            ClearData();
        }

        public void ShowDataGrid()
        {
            try
            {
                _conn.Open();
                string sql = "SELECT * FROM employee";
                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rd);
                    dgv_employee.DataSource = dt;
                    dgv_employee.Columns[0].HeaderText = "ID Karyawan";
                    dgv_employee.Columns[1].HeaderText = "Nama Depan";
                    dgv_employee.Columns[2].HeaderText = "Nama Belakang";
                    dgv_employee.Columns[3].HeaderText = "No HP";
                    dgv_employee.Columns[4].HeaderText = "Email";
                    dgv_employee.Columns[5].HeaderText = "Posisi";
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

        private void dgv_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_employee.Rows[e.RowIndex];

                txt_employeeid.Text = row.Cells["id_employee"].Value.ToString();
                txt_firstname.Text = row.Cells["firstname"].Value.ToString();
                txt_lastname.Text = row.Cells["lastname"].Value.ToString();
                txt_contact.Text = row.Cells["contact"].Value.ToString();
                txt_email.Text = row.Cells["email"].Value.ToString();
                cmb_position.Text = row.Cells["position"].Value.ToString();
            }
        }

        private void ClearData()
        {
            txt_employeeid.Text = "";
            txt_firstname.Text = "";
            txt_lastname.Text = "";
            txt_contact.Text = "";
            txt_email.Text = "";
            cmb_position.Text = "";
            txt_employeeid.Focus();
        }

        private void UC_DataKaryawan_Load(object sender, EventArgs e)
        {

        }
    }
}
