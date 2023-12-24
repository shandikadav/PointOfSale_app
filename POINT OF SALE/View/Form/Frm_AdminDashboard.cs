using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POINT_OF_SALE
{
    public partial class Frm_AdminDashboard : Form
    {
        public string FirstName {  get; set; }
        public Frm_AdminDashboard()
        {
            InitializeComponent();
            lbl_changedata.Text = "";
            uC_DataKaryawan1.Visible = false;
            uC_DataBarang1.Visible = false;
            uC_DataPayment1.Visible = false;
            uC_DataUserEdit.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_menuuser_Click(object sender, EventArgs e)
        {
            lbl_changedata.Text = "Data User";
            uC_DataUserEdit.Visible = true;
            uC_DataKaryawan1.Visible = false;
            uC_DataBarang1.Visible = false;
            uC_DataPayment1.Visible = false;
        }

        private void btn_menukaryawan_Click(object sender, EventArgs e)
        {
            lbl_changedata.Text = "Data Karyawan";
            uC_DataKaryawan1.Visible = true;
            uC_DataUserEdit.Visible = false;
            uC_DataBarang1.Visible = false;
            uC_DataPayment1.Visible = false;
        }

        private void btn_menubarang_Click(object sender, EventArgs e)
        {
            lbl_changedata.Text = "Data Barang";
            uC_DataBarang1.Visible = true;
            uC_DataKaryawan1.Visible = false;
            uC_DataUserEdit.Visible = false;
            uC_DataPayment1.Visible = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_datapayment_Click(object sender, EventArgs e)
        {
            lbl_changedata.Text = "Data Payment";
            uC_DataPayment1.Visible = true;
            uC_DataKaryawan1.Visible = false;
            uC_DataUserEdit.Visible = false;
            uC_DataBarang1.Visible = false;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Frm_login loginPage = new Frm_login();
            DialogResult result = MessageBox.Show("Apakah kamu ingin Logout dari Aplikasi?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            { 
                loginPage.Show();
                Hide();
                lbl_changedata.Text = "";
                uC_DataKaryawan1.Visible = false;
                uC_DataUserEdit.Visible = false;
                uC_DataBarang1.Visible = false;
                uC_DataPayment1.Visible = false;
            } else
            {
                // do nothing
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_AdminDashboard_Load_1(object sender, EventArgs e)
        {
            lbl_firstname.Text = FirstName;
        }
    }
}
