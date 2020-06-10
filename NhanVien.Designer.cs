namespace QUANLYTHUVIEN
{
    partial class NhanVien
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
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Luu = new System.Windows.Forms.Button();
            this.button_CapNhat = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.textBox_TimKiem = new System.Windows.Forms.TextBox();
            this.dataGridView_NhanVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_HoVaTen = new System.Windows.Forms.TextBox();
            this.textBox_SoCMT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_DiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_SoDienThoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker_NgaySinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(70, 8);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(75, 23);
            this.button_Them.TabIndex = 0;
            this.button_Them.Text = "Thêm mới";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Luu
            // 
            this.button_Luu.Location = new System.Drawing.Point(70, 51);
            this.button_Luu.Name = "button_Luu";
            this.button_Luu.Size = new System.Drawing.Size(75, 23);
            this.button_Luu.TabIndex = 1;
            this.button_Luu.Text = "Lưu";
            this.button_Luu.UseVisualStyleBackColor = true;
            this.button_Luu.Click += new System.EventHandler(this.button_Luu_Click);
            // 
            // button_CapNhat
            // 
            this.button_CapNhat.Location = new System.Drawing.Point(220, 25);
            this.button_CapNhat.Name = "button_CapNhat";
            this.button_CapNhat.Size = new System.Drawing.Size(75, 23);
            this.button_CapNhat.TabIndex = 2;
            this.button_CapNhat.Text = "Cập nhật";
            this.button_CapNhat.UseVisualStyleBackColor = true;
            this.button_CapNhat.Click += new System.EventHandler(this.button_CapNhat_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(368, 25);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(75, 23);
            this.button_Xoa.TabIndex = 3;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.Location = new System.Drawing.Point(568, 27);
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(100, 20);
            this.textBox_TimKiem.TabIndex = 4;
            this.textBox_TimKiem.TextChanged += new System.EventHandler(this.textBox_TimKiem_TextChanged);
            // 
            // dataGridView_NhanVien
            // 
            this.dataGridView_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NhanVien.Location = new System.Drawing.Point(98, 89);
            this.dataGridView_NhanVien.Name = "dataGridView_NhanVien";
            this.dataGridView_NhanVien.Size = new System.Drawing.Size(610, 150);
            this.dataGridView_NhanVien.TabIndex = 5;
            this.dataGridView_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_NhanVien_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Họ và tên";
            // 
            // textBox_HoVaTen
            // 
            this.textBox_HoVaTen.Location = new System.Drawing.Point(198, 275);
            this.textBox_HoVaTen.Name = "textBox_HoVaTen";
            this.textBox_HoVaTen.Size = new System.Drawing.Size(100, 20);
            this.textBox_HoVaTen.TabIndex = 7;
            // 
            // textBox_SoCMT
            // 
            this.textBox_SoCMT.Location = new System.Drawing.Point(198, 316);
            this.textBox_SoCMT.Name = "textBox_SoCMT";
            this.textBox_SoCMT.Size = new System.Drawing.Size(100, 20);
            this.textBox_SoCMT.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số CMT";
            // 
            // textBox_DiaChi
            // 
            this.textBox_DiaChi.Location = new System.Drawing.Point(198, 408);
            this.textBox_DiaChi.Name = "textBox_DiaChi";
            this.textBox_DiaChi.Size = new System.Drawing.Size(232, 20);
            this.textBox_DiaChi.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Địa chỉ";
            // 
            // textBox_SoDienThoai
            // 
            this.textBox_SoDienThoai.Location = new System.Drawing.Point(597, 300);
            this.textBox_SoDienThoai.Name = "textBox_SoDienThoai";
            this.textBox_SoDienThoai.Size = new System.Drawing.Size(100, 20);
            this.textBox_SoDienThoai.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Số điện thoại";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(597, 345);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(100, 20);
            this.textBox_Email.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email";
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Location = new System.Drawing.Point(597, 386);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(100, 20);
            this.textBox_MatKhau.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mật khẩu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ngày sinh";
            // 
            // dateTimePicker_NgaySinh
            // 
            this.dateTimePicker_NgaySinh.Location = new System.Drawing.Point(198, 364);
            this.dateTimePicker_NgaySinh.Name = "dateTimePicker_NgaySinh";
            this.dateTimePicker_NgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_NgaySinh.TabIndex = 21;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker_NgaySinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_SoDienThoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_DiaChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_SoCMT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_HoVaTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_NhanVien);
            this.Controls.Add(this.textBox_TimKiem);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_CapNhat);
            this.Controls.Add(this.button_Luu);
            this.Controls.Add(this.button_Them);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Luu;
        private System.Windows.Forms.Button button_CapNhat;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.TextBox textBox_TimKiem;
        private System.Windows.Forms.DataGridView dataGridView_NhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_HoVaTen;
        private System.Windows.Forms.TextBox textBox_SoCMT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_DiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_SoDienThoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgaySinh;
    }
}