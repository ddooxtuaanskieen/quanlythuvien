namespace QUANLYTHUVIEN
{
    partial class DangNhap
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
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_DangNhap = new System.Windows.Forms.Button();
            this.button_QuenMatKhau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // textBox_MaNhanVien
            // 
            this.textBox_MaNhanVien.Location = new System.Drawing.Point(329, 91);
            this.textBox_MaNhanVien.Name = "textBox_MaNhanVien";
            this.textBox_MaNhanVien.Size = new System.Drawing.Size(100, 20);
            this.textBox_MaNhanVien.TabIndex = 1;
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Location = new System.Drawing.Point(329, 152);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(100, 20);
            this.textBox_MatKhau.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // button_DangNhap
            // 
            this.button_DangNhap.Location = new System.Drawing.Point(230, 230);
            this.button_DangNhap.Name = "button_DangNhap";
            this.button_DangNhap.Size = new System.Drawing.Size(75, 23);
            this.button_DangNhap.TabIndex = 4;
            this.button_DangNhap.Text = "Đăng nhập";
            this.button_DangNhap.UseVisualStyleBackColor = true;
            this.button_DangNhap.Click += new System.EventHandler(this.button_DangNhap_Click);
            // 
            // button_QuenMatKhau
            // 
            this.button_QuenMatKhau.Location = new System.Drawing.Point(374, 230);
            this.button_QuenMatKhau.Name = "button_QuenMatKhau";
            this.button_QuenMatKhau.Size = new System.Drawing.Size(75, 23);
            this.button_QuenMatKhau.TabIndex = 5;
            this.button_QuenMatKhau.Text = "Quên mật khẩu";
            this.button_QuenMatKhau.UseVisualStyleBackColor = true;
            this.button_QuenMatKhau.Click += new System.EventHandler(this.button_QuenMatKhau_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_QuenMatKhau);
            this.Controls.Add(this.button_DangNhap);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_MaNhanVien);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MaNhanVien;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_DangNhap;
        private System.Windows.Forms.Button button_QuenMatKhau;
    }
}