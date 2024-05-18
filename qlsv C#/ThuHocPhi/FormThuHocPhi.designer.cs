namespace Thuhocphi
{
    partial class FormThuHocPhi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThuHocPhi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.grvSinhVien = new System.Windows.Forms.DataGridView();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbNganh = new System.Windows.Forms.ComboBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Bill = new System.Windows.Forms.Button();
            this.txtTienHocKy = new System.Windows.Forms.TextBox();
            this.txtTin = new System.Windows.Forms.TextBox();
            this.lbSUM = new System.Windows.Forms.Label();
            this.lbTongtin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_SUM = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbHocky = new System.Windows.Forms.ComboBox();
            this.grvHocPhan = new System.Windows.Forms.DataGridView();
            this.mamh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giatin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phaidong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvSinhVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvHocPhan)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(482, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "THU HỌC PHÍ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên";
            // 
            // txtMasv
            // 
            this.txtMasv.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMasv.Location = new System.Drawing.Point(94, 29);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(161, 25);
            this.txtMasv.TabIndex = 3;
            // 
            // grvSinhVien
            // 
            this.grvSinhVien.BackgroundColor = System.Drawing.Color.White;
            this.grvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masv,
            this.tensv,
            this.malop,
            this.phaidong,
            this.tongtien});
            this.grvSinhVien.Location = new System.Drawing.Point(-2, 68);
            this.grvSinhVien.Name = "grvSinhVien";
            this.grvSinhVien.ReadOnly = true;
            this.grvSinhVien.RowHeadersWidth = 51;
            this.grvSinhVien.Size = new System.Drawing.Size(536, 180);
            this.grvSinhVien.TabIndex = 5;
            this.grvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvSinhVien_CellClick);
           
            // 
            // txtHoten
            // 
            this.txtHoten.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHoten.Location = new System.Drawing.Point(94, 79);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(161, 25);
            this.txtHoten.TabIndex = 6;
            // 
            // txtMalop
            // 
            this.txtMalop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMalop.Location = new System.Drawing.Point(367, 29);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(134, 25);
            this.txtMalop.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ngành";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMalop);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.txtMasv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 110);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN SINH VIÊN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Mã lớp";
            // 
            // cbNganh
            // 
            this.cbNganh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbNganh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNganh.FormattingEnabled = true;
            this.cbNganh.Location = new System.Drawing.Point(86, 63);
            this.cbNganh.Name = "cbNganh";
            this.cbNganh.Size = new System.Drawing.Size(122, 23);
            this.cbNganh.TabIndex = 25;
            this.cbNganh.SelectedIndexChanged += new System.EventHandler(this.cbNganh_SelectedIndexChanged);
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(288, 250);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(124, 23);
            this.txtFind.TabIndex = 19;
           
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtTongtien);
            this.groupBox2.Controls.Add(this.txtNo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btn_Bill);
            this.groupBox2.Controls.Add(this.txtTienHocKy);
            this.groupBox2.Controls.Add(this.txtTin);
            this.groupBox2.Controls.Add(this.lbSUM);
            this.groupBox2.Controls.Add(this.lbTongtin);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_SUM);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(581, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 208);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THANH TOÁN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Học phí (theo học kỳ):";
            // 
            // txtTongtien
            // 
            this.txtTongtien.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTongtien.Location = new System.Drawing.Point(187, 161);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(117, 25);
            this.txtTongtien.TabIndex = 28;
            // 
            // txtNo
            // 
            this.txtNo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNo.Location = new System.Drawing.Point(187, 115);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(117, 25);
            this.txtNo.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Số tiền còn phải đóng:";
            // 
            // btn_Bill
            // 
            this.btn_Bill.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Bill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Bill.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bill.Image = global::ThuHocPhi.Properties.Resources.In_25;
            this.btn_Bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Bill.Location = new System.Drawing.Point(355, 115);
            this.btn_Bill.Name = "btn_Bill";
            this.btn_Bill.Size = new System.Drawing.Size(117, 43);
            this.btn_Bill.TabIndex = 25;
            this.btn_Bill.Text = "In hoá đơn";
            this.btn_Bill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Bill.UseVisualStyleBackColor = false;
            this.btn_Bill.Click += new System.EventHandler(this.btn_Bill_Click);
            // 
            // txtTienHocKy
            // 
            this.txtTienHocKy.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTienHocKy.Location = new System.Drawing.Point(187, 70);
            this.txtTienHocKy.Name = "txtTienHocKy";
            this.txtTienHocKy.Size = new System.Drawing.Size(117, 25);
            this.txtTienHocKy.TabIndex = 24;
            // 
            // txtTin
            // 
            this.txtTin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTin.Location = new System.Drawing.Point(187, 25);
            this.txtTin.Name = "txtTin";
            this.txtTin.Size = new System.Drawing.Size(38, 25);
            this.txtTin.TabIndex = 23;
            // 
            // lbSUM
            // 
            this.lbSUM.AutoSize = true;
            this.lbSUM.Location = new System.Drawing.Point(162, 76);
            this.lbSUM.Name = "lbSUM";
            this.lbSUM.Size = new System.Drawing.Size(0, 17);
            this.lbSUM.TabIndex = 21;
            // 
            // lbTongtin
            // 
            this.lbTongtin.AutoSize = true;
            this.lbTongtin.Location = new System.Drawing.Point(162, 28);
            this.lbTongtin.Name = "lbTongtin";
            this.lbTongtin.Size = new System.Drawing.Size(0, 17);
            this.lbTongtin.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tổng tiền phải thanh toán:";
            // 
            // btn_SUM
            // 
            this.btn_SUM.BackColor = System.Drawing.SystemColors.Info;
            this.btn_SUM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SUM.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SUM.Image = global::ThuHocPhi.Properties.Resources.atm_25;
            this.btn_SUM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SUM.Location = new System.Drawing.Point(355, 27);
            this.btn_SUM.Name = "btn_SUM";
            this.btn_SUM.Size = new System.Drawing.Size(117, 43);
            this.btn_SUM.TabIndex = 19;
            this.btn_SUM.Text = "Thanh Toán";
            this.btn_SUM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SUM.UseVisualStyleBackColor = false;
            this.btn_SUM.Click += new System.EventHandler(this.btn_SUM_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số tín chỉ đăng kí: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Học kỳ ";
            // 
            // cbHocky
            // 
            this.cbHocky.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbHocky.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHocky.FormattingEnabled = true;
            this.cbHocky.Location = new System.Drawing.Point(376, 63);
            this.cbHocky.Name = "cbHocky";
            this.cbHocky.Size = new System.Drawing.Size(128, 23);
            this.cbHocky.TabIndex = 27;
            this.cbHocky.SelectedIndexChanged += new System.EventHandler(this.cbHocky_SelectedIndexChanged);
            // 
            // grvHocPhan
            // 
            this.grvHocPhan.BackgroundColor = System.Drawing.Color.White;
            this.grvHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvHocPhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamh,
            this.tenmh,
            this.sotin,
            this.giatin});
            this.grvHocPhan.Location = new System.Drawing.Point(570, 68);
            this.grvHocPhan.Name = "grvHocPhan";
            this.grvHocPhan.RowHeadersWidth = 51;
            this.grvHocPhan.Size = new System.Drawing.Size(518, 180);
            this.grvHocPhan.TabIndex = 28;
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
            this.sotin.HeaderText = "Số tín chỉ";
            this.sotin.MinimumWidth = 6;
            this.sotin.Name = "sotin";
            this.sotin.Width = 125;
            // 
            // giatin
            // 
            this.giatin.DataPropertyName = "giatin";
            this.giatin.HeaderText = "Giá tín chỉ";
            this.giatin.MinimumWidth = 6;
            this.giatin.Name = "giatin";
            this.giatin.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grvHocPhan);
            this.groupBox3.Controls.Add(this.grvSinhVien);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1078, 274);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            // 
            // btn_Find
            // 
            this.btn_Find.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Find.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.Image = global::ThuHocPhi.Properties.Resources.Tim_25;
            this.btn_Find.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Find.Location = new System.Drawing.Point(457, 240);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(75, 41);
            this.btn_Find.TabIndex = 24;
            this.btn_Find.Text = "Tìm ";
            this.btn_Find.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Find.UseVisualStyleBackColor = false;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ThuHocPhi.Properties.Resources.thoat_25;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(987, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 41);
            this.button1.TabIndex = 22;
            this.button1.Text = "Thoát";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // masv
            // 
            this.masv.DataPropertyName = "masv";
            this.masv.HeaderText = "Mã sinh viên";
            this.masv.MinimumWidth = 6;
            this.masv.Name = "masv";
            this.masv.ReadOnly = true;
            this.masv.Width = 125;
            // 
            // tensv
            // 
            this.tensv.DataPropertyName = "tensv";
            this.tensv.HeaderText = "Họ và tên";
            this.tensv.MinimumWidth = 6;
            this.tensv.Name = "tensv";
            this.tensv.ReadOnly = true;
            this.tensv.Width = 175;
            // 
            // malop
            // 
            this.malop.DataPropertyName = "malop";
            this.malop.HeaderText = "Mã lớp";
            this.malop.MinimumWidth = 6;
            this.malop.Name = "malop";
            this.malop.ReadOnly = true;
            this.malop.Width = 125;
            // 
            // phaidong
            // 
            this.phaidong.DataPropertyName = "phaidong";
            this.phaidong.HeaderText = "Còn phải đóng";
            this.phaidong.MinimumWidth = 6;
            this.phaidong.Name = "phaidong";
            this.phaidong.ReadOnly = true;
            this.phaidong.Width = 150;
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng tiền phải thanh toán";
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
            // 
            // FormThuHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1096, 609);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbHocky);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.cbNganh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormThuHocPhi";
            this.Text = "Quản lí học phí";
            this.Load += new System.EventHandler(this.FormThuHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvSinhVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvHocPhan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.DataGridView grvSinhVien;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SUM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbSUM;
        private System.Windows.Forms.Label lbTongtin;
        private System.Windows.Forms.TextBox txtTienHocKy;
        private System.Windows.Forms.TextBox txtTin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btn_Bill;
        private System.Windows.Forms.ComboBox cbNganh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbHocky;
        private System.Windows.Forms.DataGridView grvHocPhan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotin;
        private System.Windows.Forms.DataGridViewTextBoxColumn giatin;
        private System.Windows.Forms.DataGridViewTextBoxColumn masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn phaidong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
    }
}

