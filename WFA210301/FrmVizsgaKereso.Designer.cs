﻿
namespace WFA210301
{
    partial class FrmVizsgaKereso
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
            this.dgvVizsgak = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbKereso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVizsgak)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVizsgak
            // 
            this.dgvVizsgak.AllowUserToAddRows = false;
            this.dgvVizsgak.AllowUserToDeleteRows = false;
            this.dgvVizsgak.AllowUserToResizeColumns = false;
            this.dgvVizsgak.AllowUserToResizeRows = false;
            this.dgvVizsgak.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVizsgak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVizsgak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvVizsgak.Location = new System.Drawing.Point(12, 66);
            this.dgvVizsgak.Name = "dgvVizsgak";
            this.dgvVizsgak.RowHeadersVisible = false;
            this.dgvVizsgak.RowHeadersWidth = 51;
            this.dgvVizsgak.RowTemplate.Height = 24;
            this.dgvVizsgak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVizsgak.Size = new System.Drawing.Size(600, 328);
            this.dgvVizsgak.TabIndex = 2;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "időpont";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "nyelv";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "szint";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // tbKereso
            // 
            this.tbKereso.Location = new System.Drawing.Point(12, 38);
            this.tbKereso.Name = "tbKereso";
            this.tbKereso.Size = new System.Drawing.Size(600, 22);
            this.tbKereso.TabIndex = 3;
            this.tbKereso.TextChanged += new System.EventHandler(this.TbKereso_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "keresés nyelv alapján:";
            // 
            // FrmVizsgaKereso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 406);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKereso);
            this.Controls.Add(this.dgvVizsgak);
            this.Name = "FrmVizsgaKereso";
            this.Text = "FrmVizsgaKereso";
            this.Load += new System.EventHandler(this.FrmVizsgaKereso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVizsgak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVizsgak;
        private System.Windows.Forms.TextBox tbKereso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}