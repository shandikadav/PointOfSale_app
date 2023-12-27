namespace POINT_OF_SALE.View
{
    partial class Frm_Cashier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_detailtransaksi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.btn_transaksi = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_changedata = new System.Windows.Forms.Label();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.uC_DetailTransaksi1 = new POINT_OF_SALE.Controller.Cashier.UC_DetailTransaksi();
            this.uC_Transaksi1 = new POINT_OF_SALE.Controller.Cashier.UC_Transaksi();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_detailtransaksi);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_transaksi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 630);
            this.panel1.TabIndex = 2;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_logout.Image = global::POINT_OF_SALE.Properties.Resources.logout;
            this.btn_logout.Location = new System.Drawing.Point(-3, 512);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_logout.Size = new System.Drawing.Size(200, 40);
            this.btn_logout.TabIndex = 21;
            this.btn_logout.Text = "         Log out  ";
            this.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_detailtransaksi
            // 
            this.btn_detailtransaksi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_detailtransaksi.FlatAppearance.BorderSize = 0;
            this.btn_detailtransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detailtransaksi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detailtransaksi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_detailtransaksi.Image = global::POINT_OF_SALE.Properties.Resources.transaction_history;
            this.btn_detailtransaksi.Location = new System.Drawing.Point(0, 203);
            this.btn_detailtransaksi.Name = "btn_detailtransaksi";
            this.btn_detailtransaksi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_detailtransaksi.Size = new System.Drawing.Size(200, 50);
            this.btn_detailtransaksi.TabIndex = 18;
            this.btn_detailtransaksi.Text = "Histori Transaksi   ";
            this.btn_detailtransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_detailtransaksi.UseVisualStyleBackColor = false;
            this.btn_detailtransaksi.Click += new System.EventHandler(this.btn_detailtransaksi_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbl_firstname);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 150);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POINT_OF_SALE.Properties.Resources.user__1_;
            this.pictureBox1.Location = new System.Drawing.Point(27, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_firstname.Location = new System.Drawing.Point(91, 67);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(50, 19);
            this.lbl_firstname.TabIndex = 11;
            this.lbl_firstname.Text = "Kasir";
            this.lbl_firstname.Click += new System.EventHandler(this.lbl_firstname_Click);
            // 
            // btn_transaksi
            // 
            this.btn_transaksi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_transaksi.FlatAppearance.BorderSize = 0;
            this.btn_transaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transaksi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transaksi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_transaksi.Image = global::POINT_OF_SALE.Properties.Resources.shopping_cart__1_;
            this.btn_transaksi.Location = new System.Drawing.Point(0, 151);
            this.btn_transaksi.Name = "btn_transaksi";
            this.btn_transaksi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_transaksi.Size = new System.Drawing.Size(200, 50);
            this.btn_transaksi.TabIndex = 12;
            this.btn_transaksi.Text = "      Transaksi      ";
            this.btn_transaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_transaksi.UseVisualStyleBackColor = false;
            this.btn_transaksi.Click += new System.EventHandler(this.btn_transaksi_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel4.Controls.Add(this.lbl_changedata);
            this.panel4.Controls.Add(this.lbl_menu);
            this.panel4.Controls.Add(this.btn_close);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(750, 60);
            this.panel4.TabIndex = 12;
            // 
            // lbl_changedata
            // 
            this.lbl_changedata.AutoSize = true;
            this.lbl_changedata.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_changedata.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_changedata.Location = new System.Drawing.Point(67, 23);
            this.lbl_changedata.Name = "lbl_changedata";
            this.lbl_changedata.Size = new System.Drawing.Size(134, 19);
            this.lbl_changedata.TabIndex = 13;
            this.lbl_changedata.Text = "Data Karyawan";
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_menu.Location = new System.Drawing.Point(18, 23);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(53, 19);
            this.lbl_menu.TabIndex = 12;
            this.lbl_menu.Text = "Menu";
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Red;
            this.btn_close.Location = new System.Drawing.Point(691, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(60, 60);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // uC_DetailTransaksi1
            // 
            this.uC_DetailTransaksi1.Location = new System.Drawing.Point(200, 60);
            this.uC_DetailTransaksi1.Name = "uC_DetailTransaksi1";
            this.uC_DetailTransaksi1.Size = new System.Drawing.Size(751, 570);
            this.uC_DetailTransaksi1.TabIndex = 14;
            this.uC_DetailTransaksi1.Load += new System.EventHandler(this.uC_DetailTransaksi1_Load);
            // 
            // uC_Transaksi1
            // 
            this.uC_Transaksi1.CashierName = null;
            this.uC_Transaksi1.Location = new System.Drawing.Point(200, 60);
            this.uC_Transaksi1.Name = "uC_Transaksi1";
            this.uC_Transaksi1.Size = new System.Drawing.Size(751, 570);
            this.uC_Transaksi1.TabIndex = 13;
            // 
            // Frm_Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 630);
            this.Controls.Add(this.uC_DetailTransaksi1);
            this.Controls.Add(this.uC_Transaksi1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Cashier";
            this.Load += new System.EventHandler(this.Frm_Cashier_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_detailtransaksi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.Button btn_transaksi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_changedata;
        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.Button btn_close;
        private Controller.Cashier.UC_Transaksi uC_Transaksi1;
        private Controller.Cashier.UC_DetailTransaksi uC_DetailTransaksi1;
    }
}