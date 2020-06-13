namespace QUANLYTHUVIEN
{
    partial class Menu
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
            this.button_NhanVien = new System.Windows.Forms.Button();
            this.button_MuonTra = new System.Windows.Forms.Button();
            this.button_DocGia = new System.Windows.Forms.Button();
            this.button_Sach = new System.Windows.Forms.Button();
            this.button_PhanQuyen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_NhanVien
            // 
            this.button_NhanVien.Location = new System.Drawing.Point(84, 83);
            this.button_NhanVien.Name = "button_NhanVien";
            this.button_NhanVien.Size = new System.Drawing.Size(75, 23);
            this.button_NhanVien.TabIndex = 0;
            this.button_NhanVien.Text = "Nhân viên";
            this.button_NhanVien.UseVisualStyleBackColor = true;
            this.button_NhanVien.Click += new System.EventHandler(this.button_NhanVien_Click);
            // 
            // button_MuonTra
            // 
            this.button_MuonTra.Location = new System.Drawing.Point(222, 83);
            this.button_MuonTra.Name = "button_MuonTra";
            this.button_MuonTra.Size = new System.Drawing.Size(75, 23);
            this.button_MuonTra.TabIndex = 1;
            this.button_MuonTra.Text = "Mượn/Trả";
            this.button_MuonTra.UseVisualStyleBackColor = true;
            this.button_MuonTra.Click += new System.EventHandler(this.button_MuonTra_Click);
            // 
            // button_DocGia
            // 
            this.button_DocGia.Location = new System.Drawing.Point(328, 83);
            this.button_DocGia.Name = "button_DocGia";
            this.button_DocGia.Size = new System.Drawing.Size(75, 23);
            this.button_DocGia.TabIndex = 2;
            this.button_DocGia.Text = "Độc giả";
            this.button_DocGia.UseVisualStyleBackColor = true;
            this.button_DocGia.Click += new System.EventHandler(this.button_DocGia_Click);
            // 
            // button_Sach
            // 
            this.button_Sach.Location = new System.Drawing.Point(454, 83);
            this.button_Sach.Name = "button_Sach";
            this.button_Sach.Size = new System.Drawing.Size(75, 23);
            this.button_Sach.TabIndex = 3;
            this.button_Sach.Text = "Sách";
            this.button_Sach.UseVisualStyleBackColor = true;
            this.button_Sach.Click += new System.EventHandler(this.button_Sach_Click);
            // 
            // button_PhanQuyen
            // 
            this.button_PhanQuyen.Location = new System.Drawing.Point(588, 83);
            this.button_PhanQuyen.Name = "button_PhanQuyen";
            this.button_PhanQuyen.Size = new System.Drawing.Size(75, 23);
            this.button_PhanQuyen.TabIndex = 4;
            this.button_PhanQuyen.Text = "Phân quyền";
            this.button_PhanQuyen.UseVisualStyleBackColor = true;
            this.button_PhanQuyen.Click += new System.EventHandler(this.button_PhanQuyen_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_PhanQuyen);
            this.Controls.Add(this.button_Sach);
            this.Controls.Add(this.button_DocGia);
            this.Controls.Add(this.button_MuonTra);
            this.Controls.Add(this.button_NhanVien);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_NhanVien;
        private System.Windows.Forms.Button button_MuonTra;
        private System.Windows.Forms.Button button_DocGia;
        private System.Windows.Forms.Button button_Sach;
        private System.Windows.Forms.Button button_PhanQuyen;
    }
}