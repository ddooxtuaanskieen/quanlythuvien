namespace QUANLYTHUVIEN
{
    partial class BaoCaoDocGiaMuonNhieu
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QUANLYTHUVIENDataSetDocGiaMuonNhieu = new QUANLYTHUVIEN.QUANLYTHUVIENDataSetDocGiaMuonNhieu();
            this.GETTOPMEMBERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GETTOPMEMBERTableAdapter = new QUANLYTHUVIEN.QUANLYTHUVIENDataSetDocGiaMuonNhieuTableAdapters.GETTOPMEMBERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYTHUVIENDataSetDocGiaMuonNhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GETTOPMEMBERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DocGiaMuonNhieu";
            reportDataSource2.Value = this.GETTOPMEMBERBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QUANLYTHUVIEN.DocGiaMuonNhieu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(610, 725);
            this.reportViewer1.TabIndex = 0;
            // 
            // QUANLYTHUVIENDataSetDocGiaMuonNhieu
            // 
            this.QUANLYTHUVIENDataSetDocGiaMuonNhieu.DataSetName = "QUANLYTHUVIENDataSetDocGiaMuonNhieu";
            this.QUANLYTHUVIENDataSetDocGiaMuonNhieu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GETTOPMEMBERBindingSource
            // 
            this.GETTOPMEMBERBindingSource.DataMember = "GETTOPMEMBER";
            this.GETTOPMEMBERBindingSource.DataSource = this.QUANLYTHUVIENDataSetDocGiaMuonNhieu;
            // 
            // GETTOPMEMBERTableAdapter
            // 
            this.GETTOPMEMBERTableAdapter.ClearBeforeFill = true;
            // 
            // BaoCaoDocGiaMuonNhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 749);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BaoCaoDocGiaMuonNhieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BaoCaoDocGiaMuonNhieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYTHUVIENDataSetDocGiaMuonNhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GETTOPMEMBERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GETTOPMEMBERBindingSource;
        private QUANLYTHUVIENDataSetDocGiaMuonNhieu QUANLYTHUVIENDataSetDocGiaMuonNhieu;
        private QUANLYTHUVIENDataSetDocGiaMuonNhieuTableAdapters.GETTOPMEMBERTableAdapter GETTOPMEMBERTableAdapter;
    }
}