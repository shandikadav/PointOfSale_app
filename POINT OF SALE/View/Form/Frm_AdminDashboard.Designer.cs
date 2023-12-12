using POINT_OF_SALE.Model.Context;

namespace POINT_OF_SALE
{
    partial class Frm_AdminDashboard
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
            this.btn_datapayment = new System.Windows.Forms.Button();
            this.btn_menubarang = new System.Windows.Forms.Button();
            this.btn_menuuser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_menukaryawan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_changedata = new System.Windows.Forms.Label();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.uC_DataPayment1 = new POINT_OF_SALE.Controller.UC_DataPayment();
            this.uC_DataBarang1 = new POINT_OF_SALE.Controller.UC_DataBarang();
            this.uC_DataKaryawan1 = new POINT_OF_SALE.Controller.UC_DataKaryawan();
            this.uC_DataUserEdit = new POINT_OF_SALE.Controller.UC_DataUser();
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
            this.panel1.Controls.Add(this.btn_datapayment);
            this.panel1.Controls.Add(this.btn_menubarang);
            this.panel1.Controls.Add(this.btn_menuuser);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_menukaryawan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 630);
            this.panel1.TabIndex = 1;
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
            // btn_datapayment
            // 
            this.btn_datapayment.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_datapayment.FlatAppearance.BorderSize = 0;
            this.btn_datapayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_datapayment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datapayment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_datapayment.Image = global::POINT_OF_SALE.Properties.Resources.credit_card;
            this.btn_datapayment.Location = new System.Drawing.Point(0, 309);
            this.btn_datapayment.Name = "btn_datapayment";
            this.btn_datapayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_datapayment.Size = new System.Drawing.Size(200, 50);
            this.btn_datapayment.TabIndex = 20;
            this.btn_datapayment.Text = "     Data Payment   ";
            this.btn_datapayment.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_datapayment.UseVisualStyleBackColor = false;
            this.btn_datapayment.Click += new System.EventHandler(this.btn_datapayment_Click);
            // 
            // btn_menubarang
            // 
            this.btn_menubarang.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_menubarang.FlatAppearance.BorderSize = 0;
            this.btn_menubarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menubarang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menubarang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_menubarang.Image = global::POINT_OF_SALE.Properties.Resources.checklists;
            this.btn_menubarang.Location = new System.Drawing.Point(0, 256);
            this.btn_menubarang.Name = "btn_menubarang";
            this.btn_menubarang.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_menubarang.Size = new System.Drawing.Size(200, 50);
            this.btn_menubarang.TabIndex = 19;
            this.btn_menubarang.Text = "      Data Barang   ";
            this.btn_menubarang.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_menubarang.UseVisualStyleBackColor = false;
            this.btn_menubarang.Click += new System.EventHandler(this.btn_menubarang_Click);
            // 
            // btn_menuuser
            // 
            this.btn_menuuser.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_menuuser.FlatAppearance.BorderSize = 0;
            this.btn_menuuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuuser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menuuser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_menuuser.Image = global::POINT_OF_SALE.Properties.Resources.next__1_;
            this.btn_menuuser.Location = new System.Drawing.Point(0, 203);
            this.btn_menuuser.Name = "btn_menuuser";
            this.btn_menuuser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_menuuser.Size = new System.Drawing.Size(200, 50);
            this.btn_menuuser.TabIndex = 18;
            this.btn_menuuser.Text = "        Data User   ";
            this.btn_menuuser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_menuuser.UseVisualStyleBackColor = false;
            this.btn_menuuser.Click += new System.EventHandler(this.btn_menuuser_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label7);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(91, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Admin";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btn_menukaryawan
            // 
            this.btn_menukaryawan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_menukaryawan.FlatAppearance.BorderSize = 0;
            this.btn_menukaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menukaryawan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menukaryawan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_menukaryawan.Image = global::POINT_OF_SALE.Properties.Resources.group;
            this.btn_menukaryawan.Location = new System.Drawing.Point(0, 151);
            this.btn_menukaryawan.Name = "btn_menukaryawan";
            this.btn_menukaryawan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_menukaryawan.Size = new System.Drawing.Size(200, 50);
            this.btn_menukaryawan.TabIndex = 12;
            this.btn_menukaryawan.Text = "Data Karyawan   ";
            this.btn_menukaryawan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_menukaryawan.UseVisualStyleBackColor = false;
            this.btn_menukaryawan.Click += new System.EventHandler(this.btn_menukaryawan_Click);
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
            this.panel4.Size = new System.Drawing.Size(751, 60);
            this.panel4.TabIndex = 11;
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
            // uC_DataPayment1
            // 
            this.uC_DataPayment1.Location = new System.Drawing.Point(200, 59);
            this.uC_DataPayment1.Name = "uC_DataPayment1";
            this.uC_DataPayment1.Size = new System.Drawing.Size(751, 570);
            this.uC_DataPayment1.TabIndex = 15;
            // 
            // uC_DataBarang1
            // 
            this.uC_DataBarang1.Location = new System.Drawing.Point(200, 59);
            this.uC_DataBarang1.Name = "uC_DataBarang1";
            this.uC_DataBarang1.Size = new System.Drawing.Size(751, 570);
            this.uC_DataBarang1.TabIndex = 14;
            // 
            // uC_DataKaryawan1
            // 
            this.uC_DataKaryawan1.Location = new System.Drawing.Point(200, 59);
            this.uC_DataKaryawan1.Name = "uC_DataKaryawan1";
            this.uC_DataKaryawan1.Size = new System.Drawing.Size(751, 570);
            this.uC_DataKaryawan1.TabIndex = 12;
            // 
            // uC_DataUserEdit
            // 
            this.uC_DataUserEdit.Location = new System.Drawing.Point(200, 60);
            this.uC_DataUserEdit.Name = "uC_DataUserEdit";
            this.uC_DataUserEdit.Size = new System.Drawing.Size(751, 570);
            this.uC_DataUserEdit.TabIndex = 16;
            // 
            // Frm_AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 630);
            this.Controls.Add(this.uC_DataUserEdit);
            this.Controls.Add(this.uC_DataPayment1);
            this.Controls.Add(this.uC_DataBarang1);
            this.Controls.Add(this.uC_DataKaryawan1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_AdminDashboard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AdminDashboard";
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_menukaryawan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_menuuser;
        private System.Windows.Forms.Button btn_menubarang;
        private System.Windows.Forms.Button btn_datapayment;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.Button btn_close;
        private Controller.UC_DataKaryawan uC_DataKaryawan1;
        private System.Windows.Forms.Label lbl_changedata;
        private Controller.UC_DataBarang uC_DataBarang1;
        private Controller.UC_DataPayment uC_DataPayment1;
        private Controller.UC_DataUser uC_DataUserEdit;
    }
}