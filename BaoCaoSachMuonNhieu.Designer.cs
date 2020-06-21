namespace QUANLYTHUVIEN
{
    partial class BaoCaoSachMuonNhieu
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GETTOPBOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QUANLYTHUVIENDataSet = new QUANLYTHUVIEN.QUANLYTHUVIENDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GETTOPBOOKTableAdapter = new QUANLYTHUVIEN.QUANLYTHUVIENDataSetTableAdapters.GETTOPBOOKTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GETTOPBOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYTHUVIENDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GETTOPBOOKBindingSource
            // 
            this.GETTOPBOOKBindingSource.DataMember = "GETTOPBOOK";
            this.GETTOPBOOKBindingSource.DataSource = this.QUANLYTHUVIENDataSet;
            // 
            // QUANLYTHUVIENDataSet
            // 
            this.QUANLYTHUVIENDataSet.DataSetName = "QUANLYTHUVIENDataSet";
            this.QUANLYTHUVIENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GETTOPBOOKBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QUANLYTHUVIEN.SachMuonNhieu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(610, 725);
            this.reportViewer1.TabIndex = 0;
            // 
            // GETTOPBOOKTableAdapter
            // 
            this.GETTOPBOOKTableAdapter.ClearBeforeFill = true;
            // 
            // BaoCaoSachMuonNhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 749);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BaoCaoSachMuonNhieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo sách mượn nhiều";
            this.Load += new System.EventHandler(this.BaoCaoSachMuonNhieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GETTOPBOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYTHUVIENDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GETTOPBOOKBindingSource;
        private QUANLYTHUVIENDataSet QUANLYTHUVIENDataSet;
        private QUANLYTHUVIENDataSetTableAdapters.GETTOPBOOKTableAdapter GETTOPBOOKTableAdapter;
    }
}