namespace QUANLYTHUVIEN
{
    partial class QuenMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MaNhanVien = new System.Windows.Forms.TextBox();
            this.textBox_SoCMT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_MatKhauMoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_NhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_DoiMatKhau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // textBox_MaNhanVien
            // 
            this.textBox_MaNhanVien.Location = new System.Drawing.Point(310, 40);
            this.textBox_MaNhanVien.Name = "textBox_MaNhanVien";
            this.textBox_MaNhanVien.Size = new System.Drawing.Size(100, 20);
            this.textBox_MaNhanVien.TabIndex = 1;
            // 
            // textBox_SoCMT
            // 
            this.textBox_SoCMT.Location = new System.Drawing.Point(310, 108);
            this.textBox_SoCMT.Name = "textBox_SoCMT";
            this.textBox_SoCMT.Size = new System.Drawing.Size(100, 20);
            this.textBox_SoCMT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số CMT";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(310, 163);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(100, 20);
            this.textBox_Email.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // textBox_MatKhauMoi
            // 
            this.textBox_MatKhauMoi.Location = new System.Drawing.Point(310, 209);
            this.textBox_MatKhauMoi.Name = "textBox_MatKhauMoi";
            this.textBox_MatKhauMoi.Size = new System.Drawing.Size(100, 20);
            this.textBox_MatKhauMoi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mật khẩu mới";
            // 
            // textBox_NhapLaiMatKhau
            // 
            this.textBox_NhapLaiMatKhau.Location = new System.Drawing.Point(310, 255);
            this.textBox_NhapLaiMatKhau.Name = "textBox_NhapLaiMatKhau";
            this.textBox_NhapLaiMatKhau.Size = new System.Drawing.Size(100, 20);
            this.textBox_NhapLaiMatKhau.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nhập lại mật khẩu";
            // 
            // button_DoiMatKhau
            // 
            this.button_DoiMatKhau.Location = new System.Drawing.Point(273, 321);
            this.button_DoiMatKhau.Name = "button_DoiMatKhau";
            this.button_DoiMatKhau.Size = new System.Drawing.Size(75, 23);
            this.button_DoiMatKhau.TabIndex = 10;
            this.button_DoiMatKhau.Text = "Lấy lại mật khẩu";
            this.button_DoiMatKhau.UseVisualStyleBackColor = true;
            this.button_DoiMatKhau.Click += new System.EventHandler(this.button_DoiMatKhau_Click);
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_DoiMatKhau);
            this.Controls.Add(this.textBox_NhapLaiMatKhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_MatKhauMoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_SoCMT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_MaNhanVien);
            this.Controls.Add(this.label1);
            this.Name = "QuenMatKhau";
            this.Text = "QuenMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MaNhanVien;
        private System.Windows.Forms.TextBox textBox_SoCMT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_MatKhauMoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_NhapLaiMatKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_DoiMatKhau;
    }
}