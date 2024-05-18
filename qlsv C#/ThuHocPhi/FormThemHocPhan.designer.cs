namespace btcuoiki
{
    partial class FormThemHocPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemHocPhan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMamh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenmh = new System.Windows.Forms.TextBox();
            this.txtSotin = new System.Windows.Forms.TextBox();
            this.btn_Thêm = new System.Windows.Forms.Button();
            this.btn_Thoát = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNganh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(379, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Học Phần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Học phần";
            // 
            // txtMamh
            // 
            this.txtMamh.Location = new System.Drawing.Point(212, 63);
            this.txtMamh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMamh.Name = "txtMamh";
            this.txtMamh.Size = new System.Drawing.Size(220, 34);
            this.txtMamh.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số tín chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Học kỳ";
            // 
            // txtTenmh
            // 
            this.txtTenmh.Location = new System.Drawing.Point(212, 146);
            this.txtTenmh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenmh.Name = "txtTenmh";
            this.txtTenmh.Size = new System.Drawing.Size(220, 34);
            this.txtTenmh.TabIndex = 8;
            // 
            // txtSotin
            // 
            this.txtSotin.Location = new System.Drawing.Point(705, 68);
            this.txtSotin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSotin.Name = "txtSotin";
            this.txtSotin.Size = new System.Drawing.Size(219, 34);
            this.txtSotin.TabIndex = 9;
            // 
            // btn_Thêm
            // 
            this.btn_Thêm.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Thêm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Thêm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thêm.Image = global::ThuHocPhi.Properties.Resources.them_20;
            this.btn_Thêm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thêm.Location = new System.Drawing.Point(296, 508);
            this.btn_Thêm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thêm.Name = "btn_Thêm";
            this.btn_Thêm.Size = new System.Drawing.Size(100, 50);
            this.btn_Thêm.TabIndex = 13;
            this.btn_Thêm.Text = " Thêm";
            this.btn_Thêm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thêm.UseVisualStyleBackColor = false;
            this.btn_Thêm.Click += new System.EventHandler(this.btn_Thêm_Click);
            // 
            // btn_Thoát
            // 
            this.btn_Thoát.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Thoát.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Thoát.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoát.Image = global::ThuHocPhi.Properties.Resources.thoat_25;
            this.btn_Thoát.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoát.Location = new System.Drawing.Point(706, 508);
            this.btn_Thoát.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoát.Name = "btn_Thoát";
            this.btn_Thoát.Size = new System.Drawing.Size(105, 50);
            this.btn_Thoát.TabIndex = 14;
            this.btn_Thoát.Text = "Thoát";
            this.btn_Thoát.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoát.UseVisualStyleBackColor = false;
            this.btn_Thoát.Click += new System.EventHandler(this.btn_Thoát_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNganh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbHocKy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSotin);
            this.groupBox1.Controls.Add(this.txtTenmh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMamh);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(967, 311);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN THÊM";
            // 
            // cbNganh
            // 
            this.cbNganh.FormattingEnabled = true;
            this.cbNganh.Location = new System.Drawing.Point(212, 235);
            this.cbNganh.Margin = new System.Windows.Forms.Padding(4);
            this.cbNganh.Name = "cbNganh";
            this.cbNganh.Size = new System.Drawing.Size(220, 34);
            this.cbNganh.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ngành";
            // 
            // cbHocKy
            // 
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(706, 158);
            this.cbHocKy.Margin = new System.Windows.Forms.Padding(4);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(218, 34);
            this.cbHocKy.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên Học phần";
            // 
            // FormThemHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Thoát);
            this.Controls.Add(this.btn_Thêm);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormThemHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemHocPhan";
            this.Load += new System.EventHandler(this.FormThemHocPhan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMamh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenmh;
        private System.Windows.Forms.TextBox txtSotin;
        private System.Windows.Forms.Button btn_Thêm;
        private System.Windows.Forms.Button btn_Thoát;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNganh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbHocKy;
    }
}