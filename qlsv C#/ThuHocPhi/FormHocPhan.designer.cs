namespace btcuoiki
{
    partial class FormHocPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHocPhan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMamh = new System.Windows.Forms.TextBox();
            this.txtTenmh = new System.Windows.Forms.TextBox();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.grvHocPhan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSotin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_XuấtExcel = new System.Windows.Forms.Button();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_Sửa = new System.Windows.Forms.Button();
            this.btn_Xóa = new System.Windows.Forms.Button();
            this.btn_Thêm = new System.Windows.Forms.Button();
            this.cbHocky = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNganh = new System.Windows.Forms.ComboBox();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Thoát = new System.Windows.Forms.Button();
            this.mamh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvHocPhan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học phần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên học phần";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tín";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Học Kỳ";
            // 
            // txtMamh
            // 
            this.txtMamh.Location = new System.Drawing.Point(155, 53);
            this.txtMamh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMamh.Name = "txtMamh";
            this.txtMamh.Size = new System.Drawing.Size(215, 29);
            this.txtMamh.TabIndex = 7;
            // 
            // txtTenmh
            // 
            this.txtTenmh.Location = new System.Drawing.Point(155, 110);
            this.txtTenmh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenmh.Name = "txtTenmh";
            this.txtTenmh.Size = new System.Drawing.Size(215, 29);
            this.txtTenmh.TabIndex = 8;
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(155, 228);
            this.txtHocKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(215, 29);
            this.txtHocKy.TabIndex = 12;
            // 
            // grvHocPhan
            // 
            this.grvHocPhan.BackgroundColor = System.Drawing.Color.White;
            this.grvHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvHocPhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamh,
            this.tenmh,
            this.sotin,
            this.nganh});
            this.grvHocPhan.Location = new System.Drawing.Point(435, 149);
            this.grvHocPhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grvHocPhan.Name = "grvHocPhan";
            this.grvHocPhan.RowHeadersWidth = 51;
            this.grvHocPhan.RowTemplate.Height = 24;
            this.grvHocPhan.Size = new System.Drawing.Size(893, 318);
            this.grvHocPhan.TabIndex = 13;
            this.grvHocPhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvHocPhan_CellClick);
            this.grvHocPhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvHocPhan_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHocKy);
            this.groupBox1.Controls.Add(this.txtSotin);
            this.groupBox1.Controls.Add(this.txtTenmh);
            this.groupBox1.Controls.Add(this.txtMamh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 149);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(391, 318);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học phần ";
            // 
            // txtSotin
            // 
            this.txtSotin.Location = new System.Drawing.Point(155, 165);
            this.txtSotin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSotin.Name = "txtSotin";
            this.txtSotin.Size = new System.Drawing.Size(215, 29);
            this.txtSotin.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(573, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(325, 37);
            this.label7.TabIndex = 22;
            this.label7.Text = "QUẢN LÍ HỌC PHẦN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_XuấtExcel);
            this.groupBox2.Controls.Add(this.btn_Find);
            this.groupBox2.Controls.Add(this.btn_Sửa);
            this.groupBox2.Controls.Add(this.btn_Xóa);
            this.groupBox2.Controls.Add(this.btn_Thêm);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(435, 569);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(893, 185);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CHỨC NĂNG";
            // 
            // btn_XuấtExcel
            // 
            this.btn_XuấtExcel.BackColor = System.Drawing.SystemColors.Info;
            this.btn_XuấtExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_XuấtExcel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuấtExcel.Image = global::ThuHocPhi.Properties.Resources.ex_25;
            this.btn_XuấtExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XuấtExcel.Location = new System.Drawing.Point(715, 39);
            this.btn_XuấtExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_XuấtExcel.Name = "btn_XuấtExcel";
            this.btn_XuấtExcel.Size = new System.Drawing.Size(105, 50);
            this.btn_XuấtExcel.TabIndex = 21;
            this.btn_XuấtExcel.Text = "Xuất ";
            this.btn_XuấtExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XuấtExcel.UseVisualStyleBackColor = false;
            this.btn_XuấtExcel.Click += new System.EventHandler(this.btn_XuấtExcel_Click);
            // 
            // btn_Find
            // 
            this.btn_Find.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Find.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.Image = global::ThuHocPhi.Properties.Resources.Tim_25;
            this.btn_Find.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Find.Location = new System.Drawing.Point(36, 117);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(143, 50);
            this.btn_Find.TabIndex = 17;
            this.btn_Find.Text = "Tìm Kiếm ";
            this.btn_Find.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Find.UseVisualStyleBackColor = false;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // btn_Sửa
            // 
            this.btn_Sửa.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Sửa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sửa.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sửa.Image = global::ThuHocPhi.Properties.Resources.sua_20;
            this.btn_Sửa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sửa.Location = new System.Drawing.Point(513, 39);
            this.btn_Sửa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sửa.Name = "btn_Sửa";
            this.btn_Sửa.Size = new System.Drawing.Size(105, 50);
            this.btn_Sửa.TabIndex = 16;
            this.btn_Sửa.Text = "Sửa";
            this.btn_Sửa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sửa.UseVisualStyleBackColor = false;
            this.btn_Sửa.Click += new System.EventHandler(this.btn_Sửa_Click);
            // 
            // btn_Xóa
            // 
            this.btn_Xóa.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Xóa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xóa.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xóa.Image = global::ThuHocPhi.Properties.Resources.xoa_25;
            this.btn_Xóa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xóa.Location = new System.Drawing.Point(273, 39);
            this.btn_Xóa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xóa.Name = "btn_Xóa";
            this.btn_Xóa.Size = new System.Drawing.Size(105, 50);
            this.btn_Xóa.TabIndex = 15;
            this.btn_Xóa.Text = "Xóa";
            this.btn_Xóa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xóa.UseVisualStyleBackColor = false;
            this.btn_Xóa.Click += new System.EventHandler(this.btn_Xóa_Click);
            // 
            // btn_Thêm
            // 
            this.btn_Thêm.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Thêm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Thêm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thêm.Image = global::ThuHocPhi.Properties.Resources.them_20;
            this.btn_Thêm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thêm.Location = new System.Drawing.Point(36, 39);
            this.btn_Thêm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thêm.Name = "btn_Thêm";
            this.btn_Thêm.Size = new System.Drawing.Size(105, 50);
            this.btn_Thêm.TabIndex = 14;
            this.btn_Thêm.Text = "Thêm";
            this.btn_Thêm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thêm.UseVisualStyleBackColor = false;
            this.btn_Thêm.Click += new System.EventHandler(this.btn_Thêm_Click);
            // 
            // cbHocky
            // 
            this.cbHocky.FormattingEnabled = true;
            this.cbHocky.Location = new System.Drawing.Point(539, 80);
            this.cbHocky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbHocky.Name = "cbHocky";
            this.cbHocky.Size = new System.Drawing.Size(152, 24);
            this.cbHocky.TabIndex = 24;
            this.cbHocky.SelectedIndexChanged += new System.EventHandler(this.cbHocky_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(431, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Học kỳ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ngành";
            // 
            // cbNganh
            // 
            this.cbNganh.FormattingEnabled = true;
            this.cbNganh.Location = new System.Drawing.Point(173, 80);
            this.cbNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNganh.Name = "cbNganh";
            this.cbNganh.Size = new System.Drawing.Size(151, 24);
            this.cbNganh.TabIndex = 28;
            this.cbNganh.SelectedIndexChanged += new System.EventHandler(this.cbNganh_SelectedIndexChanged);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BackColor = System.Drawing.SystemColors.Info;
            this.btn_LamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LamMoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.Image = global::ThuHocPhi.Properties.Resources.reset_30;
            this.btn_LamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LamMoi.Location = new System.Drawing.Point(1150, 494);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(134, 50);
            this.btn_LamMoi.TabIndex = 29;
            this.btn_LamMoi.Text = "Làm Mới";
            this.btn_LamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_Thoát
            // 
            this.btn_Thoát.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Thoát.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Thoát.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoát.Image = global::ThuHocPhi.Properties.Resources.thoat_25;
            this.btn_Thoát.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoát.Location = new System.Drawing.Point(119, 644);
            this.btn_Thoát.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoát.Name = "btn_Thoát";
            this.btn_Thoát.Size = new System.Drawing.Size(100, 50);
            this.btn_Thoát.TabIndex = 20;
            this.btn_Thoát.Text = "Thoát\r\n";
            this.btn_Thoát.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoát.UseVisualStyleBackColor = false;
            this.btn_Thoát.Click += new System.EventHandler(this.btn_Thoát_Click);
            // 
            // mamh
            // 
            this.mamh.DataPropertyName = "mamh";
            this.mamh.HeaderText = "Mã học phần";
            this.mamh.MinimumWidth = 6;
            this.mamh.Name = "mamh";
            this.mamh.Width = 125;
            // 
            // tenmh
            // 
            this.tenmh.DataPropertyName = "tenmh";
            this.tenmh.HeaderText = "Tên học phần";
            this.tenmh.MinimumWidth = 6;
            this.tenmh.Name = "tenmh";
            this.tenmh.Width = 200;
            // 
            // sotin
            // 
            this.sotin.DataPropertyName = "sotin";
            this.sotin.HeaderText = "Số tín";
            this.sotin.MinimumWidth = 6;
            this.sotin.Name = "sotin";
            this.sotin.Width = 125;
            // 
            // nganh
            // 
            this.nganh.DataPropertyName = "nganh";
            this.nganh.HeaderText = "Ngành";
            this.nganh.MinimumWidth = 6;
            this.nganh.Name = "nganh";
            this.nganh.Width = 125;
            // 
            // FormHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1371, 750);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.cbNganh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbHocky);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Thoát);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grvHocPhan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí học phần";
            this.Load += new System.EventHandler(this.FormHocPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvHocPhan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMamh;
        private System.Windows.Forms.TextBox txtTenmh;
        private System.Windows.Forms.TextBox txtHocKy;
        private System.Windows.Forms.DataGridView grvHocPhan;
        private System.Windows.Forms.Button btn_Thêm;
        private System.Windows.Forms.Button btn_Xóa;
        private System.Windows.Forms.Button btn_Sửa;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Thoát;
        private System.Windows.Forms.Button btn_XuấtExcel;
        private System.Windows.Forms.TextBox txtSotin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbHocky;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbNganh;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotin;
        private System.Windows.Forms.DataGridViewTextBoxColumn nganh;
    }
}

