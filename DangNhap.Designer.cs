using System.Drawing;

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
            this.textBox_MaNhanVien = new System.Windows.Forms.TextBox();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.button_DangNhap = new System.Windows.Forms.Button();
            this.button_QuenMatKhau = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Instagram = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Instagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_MaNhanVien
            // 
            this.textBox_MaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_MaNhanVien.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaNhanVien.ForeColor = System.Drawing.Color.Crimson;
            this.textBox_MaNhanVien.Location = new System.Drawing.Point(403, 87);
            this.textBox_MaNhanVien.Name = "textBox_MaNhanVien";
            this.textBox_MaNhanVien.Size = new System.Drawing.Size(150, 24);
            this.textBox_MaNhanVien.TabIndex = 1;
            this.textBox_MaNhanVien.TabStop = false;
            this.textBox_MaNhanVien.Text = "Mã nhân viên";
            this.textBox_MaNhanVien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_MaNhanVien_MouseClick);
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_MatKhau.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MatKhau.ForeColor = System.Drawing.Color.Crimson;
            this.textBox_MatKhau.Location = new System.Drawing.Point(403, 147);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.PasswordChar = '*';
            this.textBox_MatKhau.Size = new System.Drawing.Size(150, 24);
            this.textBox_MatKhau.TabIndex = 3;
            this.textBox_MatKhau.TabStop = false;
            this.textBox_MatKhau.Text = "Mật khẩu";
            this.textBox_MatKhau.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_MatKhau_MouseClick);
            // 
            // button_DangNhap
            // 
            this.button_DangNhap.BackColor = System.Drawing.Color.Crimson;
            this.button_DangNhap.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.button_DangNhap.FlatAppearance.BorderSize = 2;
            this.button_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DangNhap.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DangNhap.ForeColor = System.Drawing.Color.White;
            this.button_DangNhap.Location = new System.Drawing.Point(344, 227);
            this.button_DangNhap.Name = "button_DangNhap";
            this.button_DangNhap.Size = new System.Drawing.Size(210, 35);
            this.button_DangNhap.TabIndex = 4;
            this.button_DangNhap.TabStop = false;
            this.button_DangNhap.Text = "Đăng nhập";
            this.button_DangNhap.UseVisualStyleBackColor = false;
            this.button_DangNhap.Click += new System.EventHandler(this.button_DangNhap_Click);
            // 
            // button_QuenMatKhau
            // 
            this.button_QuenMatKhau.BackColor = System.Drawing.Color.White;
            this.button_QuenMatKhau.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.button_QuenMatKhau.FlatAppearance.BorderSize = 2;
            this.button_QuenMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_QuenMatKhau.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_QuenMatKhau.Location = new System.Drawing.Point(344, 278);
            this.button_QuenMatKhau.Name = "button_QuenMatKhau";
            this.button_QuenMatKhau.Size = new System.Drawing.Size(210, 35);
            this.button_QuenMatKhau.TabIndex = 5;
            this.button_QuenMatKhau.TabStop = false;
            this.button_QuenMatKhau.Text = "Quên mật khẩu";
            this.button_QuenMatKhau.UseVisualStyleBackColor = false;
            this.button_QuenMatKhau.Click += new System.EventHandler(this.button_QuenMatKhau_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox_Instagram);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 400);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.panel2.Location = new System.Drawing.Point(403, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 4);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.panel3.Location = new System.Drawing.Point(403, 175);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 4);
            this.panel3.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QUANLYTHUVIEN.Properties.Resources.iconfinder_icons_password_1564520;
            this.pictureBox2.Location = new System.Drawing.Point(344, 139);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QUANLYTHUVIEN.Properties.Resources.iconfinder_Username_372902;
            this.pictureBox1.Location = new System.Drawing.Point(344, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::QUANLYTHUVIEN.Properties.Resources.Instagram_icon_WHITE;
            this.pictureBox6.Location = new System.Drawing.Point(130, 312);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox_Instagram
            // 
            this.pictureBox_Instagram.Location = new System.Drawing.Point(227, 312);
            this.pictureBox_Instagram.Name = "pictureBox_Instagram";
            this.pictureBox_Instagram.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_Instagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Instagram.TabIndex = 2;
            this.pictureBox_Instagram.TabStop = false;
            this.pictureBox_Instagram.Click += new System.EventHandler(this.pictureBox_Instagram_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(44, 312);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QUANLYTHUVIEN.Properties.Resources.download__1_;
            this.pictureBox3.Location = new System.Drawing.Point(90, 59);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.BackColor = System.Drawing.Color.Crimson;
            this.pictureBox_Exit.Location = new System.Drawing.Point(568, 12);
            this.pictureBox_Exit.Name = "pictureBox_Exit";
            this.pictureBox_Exit.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Exit.TabIndex = 10;
            this.pictureBox_Exit.TabStop = false;
            this.pictureBox_Exit.Click += new System.EventHandler(this.pictureBox_Exit_Click);
            // 
            // DangNhap
            // 
            this.AcceptButton = this.button_DangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.pictureBox_Exit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_QuenMatKhau);
            this.Controls.Add(this.button_DangNhap);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.textBox_MaNhanVien);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Instagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_MaNhanVien;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.Button button_DangNhap;
        private System.Windows.Forms.Button button_QuenMatKhau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox_Instagram;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox_Exit;
    }
}