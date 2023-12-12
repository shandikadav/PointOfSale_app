namespace POINT_OF_SALE.Controller
{
    partial class UC_DataUser
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
            this.components = new System.ComponentModel.Container();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.cmb_nama = new System.Windows.Forms.ComboBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.tbluserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_employeeid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbluserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.Crimson;
            this.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hapus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_hapus.Location = new System.Drawing.Point(395, 431);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(140, 40);
            this.btn_hapus.TabIndex = 51;
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
            this.btn_ubah.Location = new System.Drawing.Point(219, 431);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(140, 40);
            this.btn_ubah.TabIndex = 50;
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
            this.btn_simpan.Location = new System.Drawing.Point(47, 431);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(140, 40);
            this.btn_simpan.TabIndex = 49;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // cmb_nama
            // 
            this.cmb_nama.FormattingEnabled = true;
            this.cmb_nama.Items.AddRange(new object[] {
            "Administrator",
            "Cashier"});
            this.cmb_nama.Location = new System.Drawing.Point(180, 380);
            this.cmb_nama.Name = "cmb_nama";
            this.cmb_nama.Size = new System.Drawing.Size(355, 21);
            this.cmb_nama.TabIndex = 48;
            this.cmb_nama.SelectedIndexChanged += new System.EventHandler(this.cmb_nama_SelectedIndexChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(180, 347);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(355, 20);
            this.txt_password.TabIndex = 47;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(180, 315);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(355, 20);
            this.txt_username.TabIndex = 46;
            // 
            // txt_userid
            // 
            this.txt_userid.Location = new System.Drawing.Point(180, 283);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(355, 20);
            this.txt_userid.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 19);
            this.label8.TabIndex = 44;
            this.label8.Text = "Nama Karyawan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 43;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 42;
            this.label5.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "ID User";
            // 
            // dgv_user
            // 
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Location = new System.Drawing.Point(4, 9);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.Size = new System.Drawing.Size(742, 220);
            this.dgv_user.TabIndex = 40;
            // 
            // tbluserBindingSource
            // 
            this.tbluserBindingSource.DataMember = "tbl_user";
            // 
            // txt_employeeid
            // 
            this.txt_employeeid.Enabled = false;
            this.txt_employeeid.Location = new System.Drawing.Point(610, 285);
            this.txt_employeeid.Name = "txt_employeeid";
            this.txt_employeeid.Size = new System.Drawing.Size(100, 20);
            this.txt_employeeid.TabIndex = 52;
            // 
            // UC_DataUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_employeeid);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_ubah);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.cmb_nama);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_userid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_user);
            this.Name = "UC_DataUser";
            this.Size = new System.Drawing.Size(751, 570);
            this.Load += new System.EventHandler(this.UC_DataUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbluserBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.ComboBox cmb_nama;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.BindingSource tbluserBindingSource;
        private System.Windows.Forms.TextBox txt_employeeid;
    }
}
