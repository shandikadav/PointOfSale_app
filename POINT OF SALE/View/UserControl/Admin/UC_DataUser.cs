using POINT_OF_SALE.Model.Context;
using POINT_OF_SALE.Model.Entity;
using POINT_OF_SALE.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace POINT_OF_SALE.Controller
{
    public partial class UC_DataUser : UserControl
    {
        
        private UserController usersController;
        private SqlConnection _conn;
        User users = new User();
        public UC_DataUser()
        {
            InitializeComponent();
            usersController = new UserController();
            string connString = @"Data Source=DESKTOP-Q6I09KV\SQLEXPRESS;initial catalog=DB_POS;integrated security=true";
            _conn = new SqlConnection(connString);
            ShowDataGrid();
            var employeeList = usersController.GetEmployeeName();
            cmb_nama.DataSource = employeeList;
            cmb_nama.DisplayMember = "firstName";

            cmb_nama.SelectedIndexChanged += cmb_nama_SelectedIndexChanged;
        }

        

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            users.IdUser = txt_userid.Text;
            users.Username = txt_username.Text;
            users.Password = txt_password.Text;
            users.IdEmployee = txt_employeeid.Text;

            usersController.Create(users);
            ShowDataGrid();
        }

        public void ShowDataGrid()
        {
            try
            {
                _conn.Open();
                string sql = "SELECT users.id_user, users.username, users.password, users.id_employee, employee.firstName FROM users INNER JOIN employee on users.id_employee = employee.id_employee";
                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rd);
                    dgv_user.DataSource = dt;
                    dgv_user.Columns[0].HeaderText = "User ID";
                    dgv_user.Columns[1].HeaderText = "Username";
                    dgv_user.Columns[2].HeaderText = "Password";
                    dgv_user.Columns[3].HeaderText = "Karyawan ID";
                    dgv_user.Columns[4].HeaderText = "Nama Karyawan";
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

        private void UC_DataUser_Load(object sender, EventArgs e)
        {

        }

        private void cmb_nama_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_nama.SelectedItem != null)
            {
                string selectedEmployeeId = ((Employee)cmb_nama.SelectedItem).IdEmployee;

                // Use parameterized query to avoid SQL injection
                string sql = "SELECT id_employee FROM employee WHERE id_employee = @employeeId";

                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, _conn))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", selectedEmployeeId);

                        _conn.Open();

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            txt_employeeid.Text = result.ToString();
                        }
                        else
                        {
                            txt_employeeid.Text = string.Empty;
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
                        _conn.Close(); // Close the connection in the finally block
                    }
                }
            }
        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            users.IdUser = txt_userid.Text;
            users.Username = txt_username.Text;
            users.Password = txt_password.Text;
            users.IdEmployee = txt_employeeid.Text;

            usersController.Update(users);
            ShowDataGrid();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            users.IdUser = txt_userid.Text;
            users.Username = txt_username.Text;
            users.Password = txt_password.Text;
            users.IdEmployee = txt_employeeid.Text;

            usersController.Delete(users);
            ShowDataGrid();
        }

        private void dgv_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_user.Rows[e.RowIndex];

                txt_userid.Text = row.Cells["id_user"].Value.ToString();
                txt_username.Text = row.Cells["username"].Value.ToString();
                txt_password.Text = row.Cells["password"].Value.ToString();
                txt_employeeid.Text = row.Cells["id_employee"].Value.ToString();
                cmb_nama.Text = row.Cells["firstName"].Value.ToString();
            }
        }
    }
    }

