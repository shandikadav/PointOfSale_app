using POINT_OF_SALE.Controller;
using POINT_OF_SALE.Controller.Cashier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POINT_OF_SALE.View
{
    public partial class Frm_Cashier : Form
    {
        public string FirstName {  get; set; }
       
        public Frm_Cashier()
        {
            InitializeComponent();
            lbl_changedata.Text = "";
            uC_Transaksi1.Visible = false;
            uC_DetailTransaksi1.Visible = false;

        }
       


        private void btn_transaksi_Click(object sender, EventArgs e)
        {
            lbl_changedata.Text = "Transaksi";
            uC_Transaksi1.Visible = true;
            uC_DetailTransaksi1.Visible = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_detailtransaksi_Click(object sender, EventArgs e)
        {
            lbl_changedata.Text = "Detail Transaksi";
            uC_DetailTransaksi1.Visible = true;
            uC_Transaksi1.Visible = false;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Frm_login loginPage = new Frm_login();
            DialogResult result = MessageBox.Show("Apakah kamu ingin Logout dari Aplikasi?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                loginPage.Show();
                Hide();
                lbl_changedata.Text = "";
                uC_Transaksi1.Visible = false;
                uC_DetailTransaksi1.Visible = false;
            }
            else
            {
                // do nothing
            }
        }

        private void lbl_firstname_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Cashier_Load(object sender, EventArgs e)
        {
            lbl_firstname.Text = FirstName;
            
        }

        private void uC_DetailTransaksi1_Load(object sender, EventArgs e)
        {

        }
    }
}
