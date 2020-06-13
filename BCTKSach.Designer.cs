namespace QUANLYTHUVIEN
{
    partial class BCTKSach
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
            this.dataGridView_SachKhaDung = new System.Windows.Forms.DataGridView();
            this.dataGridView_TopSach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SachKhaDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TopSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_SachKhaDung
            // 
            this.dataGridView_SachKhaDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SachKhaDung.Location = new System.Drawing.Point(60, 63);
            this.dataGridView_SachKhaDung.Name = "dataGridView_SachKhaDung";
            this.dataGridView_SachKhaDung.Size = new System.Drawing.Size(313, 150);
            this.dataGridView_SachKhaDung.TabIndex = 0;
            // 
            // dataGridView_TopSach
            // 
            this.dataGridView_TopSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TopSach.Location = new System.Drawing.Point(456, 63);
            this.dataGridView_TopSach.Name = "dataGridView_TopSach";
            this.dataGridView_TopSach.Size = new System.Drawing.Size(288, 150);
            this.dataGridView_TopSach.TabIndex = 1;
            // 
            // BCTKSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_TopSach);
            this.Controls.Add(this.dataGridView_SachKhaDung);
            this.Name = "BCTKSach";
            this.Text = "BCTKSach";
            this.Load += new System.EventHandler(this.BCTKSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SachKhaDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TopSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_SachKhaDung;
        private System.Windows.Forms.DataGridView dataGridView_TopSach;
    }
}