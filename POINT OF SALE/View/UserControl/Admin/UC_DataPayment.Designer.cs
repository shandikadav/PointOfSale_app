namespace POINT_OF_SALE.Controller
{
    partial class UC_DataPayment
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
            this.dgv_payment = new System.Windows.Forms.DataGridView();
            this.txt_paymentid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_method = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_payment
            // 
            this.dgv_payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_payment.Location = new System.Drawing.Point(4, 9);
            this.dgv_payment.Name = "dgv_payment";
            this.dgv_payment.Size = new System.Drawing.Size(742, 220);
            this.dgv_payment.TabIndex = 28;
            this.dgv_payment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_payment_CellContentClick);
            // 
            // txt_paymentid
            // 
            this.txt_paymentid.Location = new System.Drawing.Point(200, 309);
            this.txt_paymentid.Name = "txt_paymentid";
            this.txt_paymentid.Size = new System.Drawing.Size(355, 20);
            this.txt_paymentid.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "ID Payment";
            // 
            // cmb_method
            // 
            this.cmb_method.FormattingEnabled = true;
            this.cmb_method.Location = new System.Drawing.Point(200, 347);
            this.cmb_method.Name = "cmb_method";
            this.cmb_method.Size = new System.Drawing.Size(355, 21);
            this.cmb_method.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 19);
            this.label8.TabIndex = 37;
            this.label8.Text = "Metode Payment";
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.Crimson;
            this.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hapus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_hapus.Location = new System.Drawing.Point(415, 413);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(140, 40);
            this.btn_hapus.TabIndex = 4;
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
            this.btn_ubah.Location = new System.Drawing.Point(231, 413);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(140, 40);
            this.btn_ubah.TabIndex = 3;
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
            this.btn_simpan.Location = new System.Drawing.Point(53, 413);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(140, 40);
            this.btn_simpan.TabIndex = 2;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // UC_DataPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_ubah);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.cmb_method);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_paymentid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_payment);
            this.Name = "UC_DataPayment";
            this.Size = new System.Drawing.Size(751, 570);
            this.Load += new System.EventHandler(this.UC_DataPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_payment;
        private System.Windows.Forms.TextBox txt_paymentid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_method;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_simpan;
    }
}
