using System;

namespace QUANLYTHUVIEN
{
    partial class MuonTra
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
            this.dataGridView_Sach = new System.Windows.Forms.DataGridView();
            this.textBox_TimKiemDocGia = new System.Windows.Forms.TextBox();
            this.textBox_TimKiemSach = new System.Windows.Forms.TextBox();
            this.dataGridView_DocGia = new System.Windows.Forms.DataGridView();
            this.textBox_TimKiemMuonTra = new System.Windows.Forms.TextBox();
            this.dataGridView_MuonTra = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_MaDocGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_MaSach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_NgayHenTra = new System.Windows.Forms.DateTimePicker();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_TraSach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MuonTra)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Sach
            // 
            this.dataGridView_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Sach.Location = new System.Drawing.Point(475, 64);
            this.dataGridView_Sach.Name = "dataGridView_Sach";
            this.dataGridView_Sach.Size = new System.Drawing.Size(296, 150);
            this.dataGridView_Sach.TabIndex = 0;
            this.dataGridView_Sach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Sach_CellClick);
            // 
            // textBox_TimKiemDocGia
            // 
            this.textBox_TimKiemDocGia.Location = new System.Drawing.Point(132, 22);
            this.textBox_TimKiemDocGia.Name = "textBox_TimKiemDocGia";
            this.textBox_TimKiemDocGia.Size = new System.Drawing.Size(100, 20);
            this.textBox_TimKiemDocGia.TabIndex = 1;
            this.textBox_TimKiemDocGia.TextChanged += new System.EventHandler(this.textBox_TimKiemDocGia_TextChanged);
            // 
            // textBox_TimKiemSach
            // 
            this.textBox_TimKiemSach.Location = new System.Drawing.Point(564, 19);
            this.textBox_TimKiemSach.Name = "textBox_TimKiemSach";
            this.textBox_TimKiemSach.Size = new System.Drawing.Size(119, 20);
            this.textBox_TimKiemSach.TabIndex = 3;
            this.textBox_TimKiemSach.TextChanged += new System.EventHandler(this.textBox_TimKiemSach_TextChanged);
            // 
            // dataGridView_DocGia
            // 
            this.dataGridView_DocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DocGia.Location = new System.Drawing.Point(31, 64);
            this.dataGridView_DocGia.Name = "dataGridView_DocGia";
            this.dataGridView_DocGia.Size = new System.Drawing.Size(343, 150);
            this.dataGridView_DocGia.TabIndex = 2;
            this.dataGridView_DocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DocGia_CellClick);
            // 
            // textBox_TimKiemMuonTra
            // 
            this.textBox_TimKiemMuonTra.Location = new System.Drawing.Point(167, 247);
            this.textBox_TimKiemMuonTra.Name = "textBox_TimKiemMuonTra";
            this.textBox_TimKiemMuonTra.Size = new System.Drawing.Size(114, 20);
            this.textBox_TimKiemMuonTra.TabIndex = 5;
            this.textBox_TimKiemMuonTra.TextChanged += new System.EventHandler(this.textBox_TimKiemMuonTra_TextChanged);
            // 
            // dataGridView_MuonTra
            // 
            this.dataGridView_MuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MuonTra.Location = new System.Drawing.Point(31, 288);
            this.dataGridView_MuonTra.Name = "dataGridView_MuonTra";
            this.dataGridView_MuonTra.Size = new System.Drawing.Size(387, 150);
            this.dataGridView_MuonTra.TabIndex = 4;
            this.dataGridView_MuonTra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_MuonTra_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm kiếm độc giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tìm kiếm sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tìm kiếm lượt mượn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã độc giả";
            // 
            // textBox_MaDocGia
            // 
            this.textBox_MaDocGia.Location = new System.Drawing.Point(614, 288);
            this.textBox_MaDocGia.Name = "textBox_MaDocGia";
            this.textBox_MaDocGia.ReadOnly = true;
            this.textBox_MaDocGia.Size = new System.Drawing.Size(114, 20);
            this.textBox_MaDocGia.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mã sách";
            // 
            // textBox_MaSach
            // 
            this.textBox_MaSach.Location = new System.Drawing.Point(614, 333);
            this.textBox_MaSach.Name = "textBox_MaSach";
            this.textBox_MaSach.ReadOnly = true;
            this.textBox_MaSach.Size = new System.Drawing.Size(114, 20);
            this.textBox_MaSach.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ngày hẹn trả";
            // 
            // dateTimePicker_NgayHenTra
            // 
            this.dateTimePicker_NgayHenTra.Location = new System.Drawing.Point(588, 371);
            this.dateTimePicker_NgayHenTra.Name = "dateTimePicker_NgayHenTra";
            this.dateTimePicker_NgayHenTra.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_NgayHenTra.TabIndex = 15;
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(564, 415);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(105, 23);
            this.button_Them.TabIndex = 16;
            this.button_Them.Text = "Tạo lượt mượn";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(442, 415);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(105, 23);
            this.button_Xoa.TabIndex = 17;
            this.button_Xoa.Text = "Xóa lượt mượn";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_TraSach
            // 
            this.button_TraSach.Location = new System.Drawing.Point(696, 415);
            this.button_TraSach.Name = "button_TraSach";
            this.button_TraSach.Size = new System.Drawing.Size(75, 23);
            this.button_TraSach.TabIndex = 18;
            this.button_TraSach.Text = "Trả sách";
            this.button_TraSach.UseVisualStyleBackColor = true;
            this.button_TraSach.Click += new System.EventHandler(this.button_TraSach_Click);
            // 
            // Muon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_TraSach);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.dateTimePicker_NgayHenTra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_MaSach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_MaDocGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_TimKiemMuonTra);
            this.Controls.Add(this.dataGridView_MuonTra);
            this.Controls.Add(this.textBox_TimKiemSach);
            this.Controls.Add(this.dataGridView_DocGia);
            this.Controls.Add(this.textBox_TimKiemDocGia);
            this.Controls.Add(this.dataGridView_Sach);
            this.Name = "Muon";
            this.Text = "Muon";
            this.Load += new System.EventHandler(this.Muon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MuonTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Sach;
        private System.Windows.Forms.TextBox textBox_TimKiemDocGia;
        private System.Windows.Forms.TextBox textBox_TimKiemSach;
        private System.Windows.Forms.DataGridView dataGridView_DocGia;
        private System.Windows.Forms.TextBox textBox_TimKiemMuonTra;
        private System.Windows.Forms.DataGridView dataGridView_MuonTra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_MaDocGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_MaSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayHenTra;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_TraSach;
    }
}