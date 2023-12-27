namespace POINT_OF_SALE.Controller.Cashier
{
    partial class UC_Transaksi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kodebarang = new System.Windows.Forms.TextBox();
            this.txt_namabarang = new System.Windows.Forms.TextBox();
            this.txt_jumlahbarang = new System.Windows.Forms.TextBox();
            this.txt_hargabarang = new System.Windows.Forms.TextBox();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.dgv_detail = new System.Windows.Forms.DataGridView();
            this.txt_tunai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_metodepayment = new System.Windows.Forms.ComboBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.dgv_barang = new System.Windows.Forms.DataGridView();
            this.txt_iddetail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_value = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_idpayment = new System.Windows.Forms.TextBox();
            this.lbl_jumlahproduk = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_datauser = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_iduser = new System.Windows.Forms.TextBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txt_idtransact = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_barang)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Kode Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Harga";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "Jumlah";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_kodebarang
            // 
            this.txt_kodebarang.Location = new System.Drawing.Point(152, 126);
            this.txt_kodebarang.Name = "txt_kodebarang";
            this.txt_kodebarang.Size = new System.Drawing.Size(151, 20);
            this.txt_kodebarang.TabIndex = 42;
            // 
            // txt_namabarang
            // 
            this.txt_namabarang.Enabled = false;
            this.txt_namabarang.Location = new System.Drawing.Point(152, 159);
            this.txt_namabarang.Name = "txt_namabarang";
            this.txt_namabarang.Size = new System.Drawing.Size(151, 20);
            this.txt_namabarang.TabIndex = 43;
            // 
            // txt_jumlahbarang
            // 
            this.txt_jumlahbarang.Location = new System.Drawing.Point(418, 128);
            this.txt_jumlahbarang.Name = "txt_jumlahbarang";
            this.txt_jumlahbarang.Size = new System.Drawing.Size(151, 20);
            this.txt_jumlahbarang.TabIndex = 45;
            this.txt_jumlahbarang.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_hargabarang
            // 
            this.txt_hargabarang.Enabled = false;
            this.txt_hargabarang.Location = new System.Drawing.Point(418, 95);
            this.txt_hargabarang.Name = "txt_hargabarang";
            this.txt_hargabarang.Size = new System.Drawing.Size(151, 20);
            this.txt_hargabarang.TabIndex = 44;
            this.txt_hargabarang.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_simpan.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_simpan.Location = new System.Drawing.Point(583, 96);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(140, 40);
            this.btn_simpan.TabIndex = 46;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // dgv_detail
            // 
            this.dgv_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detail.Location = new System.Drawing.Point(24, 196);
            this.dgv_detail.Name = "dgv_detail";
            this.dgv_detail.Size = new System.Drawing.Size(699, 84);
            this.dgv_detail.TabIndex = 47;
            // 
            // txt_tunai
            // 
            this.txt_tunai.Location = new System.Drawing.Point(202, 356);
            this.txt_tunai.Name = "txt_tunai";
            this.txt_tunai.Size = new System.Drawing.Size(101, 20);
            this.txt_tunai.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 49;
            this.label7.Text = "Dibayarkan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 19);
            this.label8.TabIndex = 48;
            this.label8.Text = "Metode Pembayaran";
            // 
            // cmb_metodepayment
            // 
            this.cmb_metodepayment.FormattingEnabled = true;
            this.cmb_metodepayment.Location = new System.Drawing.Point(202, 325);
            this.cmb_metodepayment.Name = "cmb_metodepayment";
            this.cmb_metodepayment.Size = new System.Drawing.Size(101, 21);
            this.cmb_metodepayment.TabIndex = 54;
            this.cmb_metodepayment.SelectedIndexChanged += new System.EventHandler(this.cmb_metodepayment_SelectedIndexChanged);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_print.Location = new System.Drawing.Point(583, 295);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(140, 40);
            this.btn_print.TabIndex = 57;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // dgv_barang
            // 
            this.dgv_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_barang.Location = new System.Drawing.Point(24, 14);
            this.dgv_barang.Name = "dgv_barang";
            this.dgv_barang.Size = new System.Drawing.Size(699, 67);
            this.dgv_barang.TabIndex = 58;
            this.dgv_barang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_barang_CellContentClick);
            // 
            // txt_iddetail
            // 
            this.txt_iddetail.Enabled = false;
            this.txt_iddetail.Location = new System.Drawing.Point(152, 96);
            this.txt_iddetail.Name = "txt_iddetail";
            this.txt_iddetail.Size = new System.Drawing.Size(88, 20);
            this.txt_iddetail.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 19);
            this.label9.TabIndex = 59;
            this.label9.Text = "Kode Order";
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_value.Location = new System.Drawing.Point(479, 323);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(46, 19);
            this.lbl_value.TabIndex = 56;
            this.lbl_value.Text = "value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "Total";
            // 
            // txt_idpayment
            // 
            this.txt_idpayment.Location = new System.Drawing.Point(332, 356);
            this.txt_idpayment.Name = "txt_idpayment";
            this.txt_idpayment.Size = new System.Drawing.Size(111, 20);
            this.txt_idpayment.TabIndex = 61;
            this.txt_idpayment.Visible = false;
            // 
            // lbl_jumlahproduk
            // 
            this.lbl_jumlahproduk.AutoSize = true;
            this.lbl_jumlahproduk.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jumlahproduk.Location = new System.Drawing.Point(479, 296);
            this.lbl_jumlahproduk.Name = "lbl_jumlahproduk";
            this.lbl_jumlahproduk.Size = new System.Drawing.Size(46, 19);
            this.lbl_jumlahproduk.TabIndex = 63;
            this.lbl_jumlahproduk.Text = "value";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(328, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 19);
            this.label10.TabIndex = 62;
            this.label10.Text = "Jumlah Produk";
            // 
            // cmb_datauser
            // 
            this.cmb_datauser.FormattingEnabled = true;
            this.cmb_datauser.Location = new System.Drawing.Point(202, 387);
            this.cmb_datauser.Name = "cmb_datauser";
            this.cmb_datauser.Size = new System.Drawing.Size(101, 21);
            this.cmb_datauser.TabIndex = 66;
            this.cmb_datauser.SelectedIndexChanged += new System.EventHandler(this.cmb_datauser_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 65;
            this.label6.Text = "Nama Kasir";
            // 
            // txt_iduser
            // 
            this.txt_iduser.Location = new System.Drawing.Point(332, 382);
            this.txt_iduser.Name = "txt_iduser";
            this.txt_iduser.Size = new System.Drawing.Size(151, 20);
            this.txt_iduser.TabIndex = 67;
            this.txt_iduser.Visible = false;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 426);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(751, 141);
            this.crystalReportViewer1.TabIndex = 68;
            // 
            // txt_idtransact
            // 
            this.txt_idtransact.Location = new System.Drawing.Point(202, 295);
            this.txt_idtransact.Name = "txt_idtransact";
            this.txt_idtransact.Size = new System.Drawing.Size(84, 20);
            this.txt_idtransact.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 19);
            this.label11.TabIndex = 69;
            this.label11.Text = "Kode Transaksi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(449, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 19);
            this.label12.TabIndex = 71;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(449, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 19);
            this.label13.TabIndex = 72;
            this.label13.Text = ":";
            // 
            // UC_Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_idtransact);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.txt_iduser);
            this.Controls.Add(this.cmb_datauser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_jumlahproduk);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_idpayment);
            this.Controls.Add(this.txt_iddetail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgv_barang);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_metodepayment);
            this.Controls.Add(this.txt_tunai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv_detail);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.txt_jumlahbarang);
            this.Controls.Add(this.txt_hargabarang);
            this.Controls.Add(this.txt_namabarang);
            this.Controls.Add(this.txt_kodebarang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "UC_Transaksi";
            this.Size = new System.Drawing.Size(751, 570);
            this.Load += new System.EventHandler(this.UC_Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_barang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_kodebarang;
        private System.Windows.Forms.TextBox txt_namabarang;
        private System.Windows.Forms.TextBox txt_jumlahbarang;
        private System.Windows.Forms.TextBox txt_hargabarang;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.DataGridView dgv_detail;
        private System.Windows.Forms.TextBox txt_tunai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_metodepayment;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.DataGridView dgv_barang;
        private System.Windows.Forms.TextBox txt_iddetail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_idpayment;
        private System.Windows.Forms.Label lbl_jumlahproduk;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_datauser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_iduser;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox txt_idtransact;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}
