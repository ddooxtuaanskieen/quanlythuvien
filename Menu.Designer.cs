﻿namespace QUANLYTHUVIEN
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
            this.SuspendLayout();
            // 
            // button_NhanVien
            // 
            this.button_NhanVien.Location = new System.Drawing.Point(380, 145);
            this.button_NhanVien.Name = "button_NhanVien";
            this.button_NhanVien.Size = new System.Drawing.Size(75, 23);
            this.button_NhanVien.TabIndex = 0;
            this.button_NhanVien.Text = "Nhân viên";
            this.button_NhanVien.UseVisualStyleBackColor = true;
            this.button_NhanVien.Click += new System.EventHandler(this.button_NhanVien_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_NhanVien);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_NhanVien;
    }
}