using System.ComponentModel;

namespace QUANLYTHUVIEN
{
    partial class QuanLyQuy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_Quy = new System.Windows.Forms.DataGridView();
            this.DinhDanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ThongKe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_BienDong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Quy)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Quy
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Crimson;
            this.dataGridView_Quy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Quy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Quy.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Quy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Quy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Quy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Quy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Quy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Quy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DinhDanh,
            this.Ngay,
            this.BienDong,
            this.GhiChu});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Quy.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Quy.EnableHeadersVisualStyles = false;
            this.dataGridView_Quy.Location = new System.Drawing.Point(12, 76);
            this.dataGridView_Quy.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Quy.Name = "dataGridView_Quy";
            this.dataGridView_Quy.RowTemplate.Height = 25;
            this.dataGridView_Quy.Size = new System.Drawing.Size(860, 416);
            this.dataGridView_Quy.TabIndex = 0;
            // 
            // DinhDanh
            // 
            this.DinhDanh.HeaderText = "Định danh";
            this.DinhDanh.Name = "DinhDanh";
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            // 
            // BienDong
            // 
            this.BienDong.HeaderText = "Biến động";
            this.BienDong.Name = "BienDong";
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Nội dung";
            this.GhiChu.Name = "GhiChu";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.panel4.Location = new System.Drawing.Point(126, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 4);
            this.panel4.TabIndex = 66;
            // 
            // dateTimePicker_TuNgay
            // 
            this.dateTimePicker_TuNgay.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_TuNgay.Location = new System.Drawing.Point(126, 26);
            this.dateTimePicker_TuNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_TuNgay.MinDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_TuNgay.Name = "dateTimePicker_TuNgay";
            this.dateTimePicker_TuNgay.Size = new System.Drawing.Size(150, 26);
            this.dateTimePicker_TuNgay.TabIndex = 65;
            this.dateTimePicker_TuNgay.Value = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 64;
            this.label8.Text = "Từ ngày";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.panel1.Location = new System.Drawing.Point(463, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 4);
            this.panel1.TabIndex = 69;
            // 
            // dateTimePicker_DenNgay
            // 
            this.dateTimePicker_DenNgay.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_DenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DenNgay.Location = new System.Drawing.Point(463, 26);
            this.dateTimePicker_DenNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_DenNgay.MinDate = new System.DateTime(2020, 1, 2, 0, 0, 0, 0);
            this.dateTimePicker_DenNgay.Name = "dateTimePicker_DenNgay";
            this.dateTimePicker_DenNgay.Size = new System.Drawing.Size(150, 26);
            this.dateTimePicker_DenNgay.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 67;
            this.label1.Text = "Đến ngày";
            // 
            // button_ThongKe
            // 
            this.button_ThongKe.FlatAppearance.BorderSize = 2;
            this.button_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ThongKe.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThongKe.Image = global::QUANLYTHUVIEN.Properties.Resources.analysis;
            this.button_ThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ThongKe.Location = new System.Drawing.Point(702, 19);
            this.button_ThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.button_ThongKe.Name = "button_ThongKe";
            this.button_ThongKe.Size = new System.Drawing.Size(170, 40);
            this.button_ThongKe.TabIndex = 70;
            this.button_ThongKe.Text = "Thống kê";
            this.button_ThongKe.UseVisualStyleBackColor = true;
            this.button_ThongKe.Click += new System.EventHandler(this.button_ThongKe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(606, 507);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 71;
            this.label2.Text = "Biến động: ";
            // 
            // label_BienDong
            // 
            this.label_BienDong.AutoSize = true;
            this.label_BienDong.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BienDong.Location = new System.Drawing.Point(741, 507);
            this.label_BienDong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BienDong.Name = "label_BienDong";
            this.label_BienDong.Size = new System.Drawing.Size(33, 32);
            this.label_BienDong.TabIndex = 72;
            this.label_BienDong.Text = "...";
            // 
            // QuanLyQuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label_BienDong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_ThongKe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker_DenNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dateTimePicker_TuNgay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView_Quy);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyQuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quỹ";
            this.Load += new System.EventHandler(this.QuanLyQuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Quy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Quy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DinhDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TuNgay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DenNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ThongKe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_BienDong;
    }
}