﻿using POINT_OF_SALE.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using POINT_OF_SALE.Controller.Cashier;

namespace POINT_OF_SALE
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_AdminDashboard adminDashboard = new Frm_AdminDashboard();
            Frm_Cashier cashier = new Frm_Cashier();
            UC_Transaksi uC_Transaksi = new UC_Transaksi();

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-Q6I09KV\\SQLEXPRESS;initial catalog=DB_POS;integrated security=true");
            SqlCommand cmd = new SqlCommand("SELECT username, password, position, firstName FROM users INNER JOIN employee ON users.id_employee = employee.id_employee WHERE username = '" + txt_username.Text+"' AND password = '"+txt_password.Text+"'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (txt_username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Silahkan masukan Username atau Password terlebih dahulu!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_username.Focus();
            } else
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string position = dt.Rows[i]["position"].ToString();
                        string firstName = dt.Rows[i]["firstName"].ToString();
                        if (position == "Administrator")
                        {
                            MessageBox.Show("Kamu berhasil Login sebagai " + dt.Rows[i][2], "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            adminDashboard.FirstName = firstName;
                            adminDashboard.Show();
                            Hide();
                        }
                        else if (position == "Cashier")
                        {
                            MessageBox.Show("Kamu berhasil Login sebagai " + dt.Rows[i][2], "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cashier.FirstName = firstName;
                            uC_Transaksi.CashierName = firstName;
                            cashier.Show();
                            Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Username atau Password salah, silahkan coba lagi!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Text = "";
                    txt_password.Text = "";
                    txt_username.Focus();
                }
            }

            

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
