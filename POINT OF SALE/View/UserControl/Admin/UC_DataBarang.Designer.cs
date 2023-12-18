namespace POINT_OF_SALE.Controller
{
    partial class UC_DataBarang
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
            this.dgv_barang = new System.Windows.Forms.DataGridView();
            this.txt_barangid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_barangname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_stokbarang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hargabarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_barang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_barang
            // 
            this.dgv_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_barang.Location = new System.Drawing.Point(4, 9);
            this.dgv_barang.Name = "dgv_barang";
            this.dgv_barang.Size = new System.Drawing.Size(742, 220);
            this.dgv_barang.TabIndex = 27;
            this.dgv_barang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_barang_CellContentClick);
            // 
            // txt_barangid
            // 
            this.txt_barangid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_barangid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barangid.Location = new System.Drawing.Point(182, 289);
            this.txt_barangid.Name = "txt_barangid";
            this.txt_barangid.Size = new System.Drawing.Size(355, 20);
            this.txt_barangid.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(47, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "ID Barang";
            // 
            // txt_barangname
            // 
            this.txt_barangname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_barangname.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_barangname.Location = new System.Drawing.Point(182, 321);
            this.txt_barangname.Name = "txt_barangname";
            this.txt_barangname.Size = new System.Drawing.Size(355, 20);
            this.txt_barangname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(47, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nama Barang";
            // 
            // txt_stokbarang
            // 
            this.txt_stokbarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_stokbarang.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_stokbarang.Location = new System.Drawing.Point(182, 354);
            this.txt_stokbarang.Name = "txt_stokbarang";
            this.txt_stokbarang.Size = new System.Drawing.Size(355, 20);
            this.txt_stokbarang.TabIndex = 2;
            this.txt_stokbarang.TextChanged += new System.EventHandler(this.txt_stokbarang_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(47, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "Stok Barang";
            // 
            // txt_hargabarang
            // 
            this.txt_hargabarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_hargabarang.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_hargabarang.Location = new System.Drawing.Point(182, 387);
            this.txt_hargabarang.Name = "txt_hargabarang";
            this.txt_hargabarang.Size = new System.Drawing.Size(355, 20);
            this.txt_hargabarang.TabIndex = 3;
            this.txt_hargabarang.TextChanged += new System.EventHandler(this.txt_hargabarang_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(47, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "Harga Barang";
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.Crimson;
            this.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hapus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_hapus.Location = new System.Drawing.Point(568, 399);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(140, 40);
            this.btn_hapus.TabIndex = 6;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = false;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_ubah
            // 
            this.btn_ubah.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ubah.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ubah.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ubah.Location = new System.Drawing.Point(568, 346);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(140, 40);
            this.btn_ubah.TabIndex = 5;
            this.btn_ubah.Text = "Ubah";
            this.btn_ubah.UseVisualStyleBackColor = false;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_simpan.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_simpan.Location = new System.Drawing.Point(568, 289);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(140, 40);
            this.btn_simpan.TabIndex = 4;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(178, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "_______________________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(178, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 19);
            this.label6.TabIndex = 43;
            this.label6.Text = "_______________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(177, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(360, 19);
            this.label7.TabIndex = 44;
            this.label7.Text = "_______________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(177, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(360, 19);
            this.label8.TabIndex = 45;
            this.label8.Text = "_______________________________________";
            // 
            // UC_DataBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_ubah);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.txt_hargabarang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_stokbarang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_barangname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_barangid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_barang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Name = "UC_DataBarang";
            this.Size = new System.Drawing.Size(751, 570);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_barang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_barang;
        private System.Windows.Forms.TextBox txt_barangid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_barangname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_stokbarang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hargabarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
