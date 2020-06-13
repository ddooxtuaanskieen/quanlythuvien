namespace QUANLYTHUVIEN
{
    partial class BCTKDocGia
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
            this.dataGridView_DanhSachDen = new System.Windows.Forms.DataGridView();
            this.dataGridView_TopDocGia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachDen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TopDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_DanhSachDen
            // 
            this.dataGridView_DanhSachDen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DanhSachDen.Location = new System.Drawing.Point(56, 61);
            this.dataGridView_DanhSachDen.Name = "dataGridView_DanhSachDen";
            this.dataGridView_DanhSachDen.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_DanhSachDen.TabIndex = 0;
            // 
            // dataGridView_TopDocGia
            // 
            this.dataGridView_TopDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TopDocGia.Location = new System.Drawing.Point(436, 61);
            this.dataGridView_TopDocGia.Name = "dataGridView_TopDocGia";
            this.dataGridView_TopDocGia.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_TopDocGia.TabIndex = 1;
            // 
            // BCTKDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_TopDocGia);
            this.Controls.Add(this.dataGridView_DanhSachDen);
            this.Name = "BCTKDocGia";
            this.Text = "BCTKDocGia";
            this.Load += new System.EventHandler(this.BCTKDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachDen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TopDocGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_DanhSachDen;
        private System.Windows.Forms.DataGridView dataGridView_TopDocGia;
    }
}