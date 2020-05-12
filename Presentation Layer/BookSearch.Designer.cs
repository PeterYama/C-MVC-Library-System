using System;
using System.Windows.Forms;

namespace Presentation_Layer
{
    partial class BookSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.myCombo = new System.Windows.Forms.ComboBox();
            this.ComboTesst_btn = new System.Windows.Forms.Button();
            this.resultGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "You can search for a book";
            // 
            // myCombo
            // 
            this.myCombo.FormattingEnabled = true;
            this.myCombo.Location = new System.Drawing.Point(173, 129);
            this.myCombo.Name = "myCombo";
            this.myCombo.Size = new System.Drawing.Size(250, 21);
            this.myCombo.TabIndex = 2;
            // 
            // ComboTesst_btn
            // 
            this.ComboTesst_btn.AutoSize = true;
            this.ComboTesst_btn.Location = new System.Drawing.Point(499, 127);
            this.ComboTesst_btn.Name = "ComboTesst_btn";
            this.ComboTesst_btn.Size = new System.Drawing.Size(93, 23);
            this.ComboTesst_btn.TabIndex = 3;
            this.ComboTesst_btn.Text = "Search";
            this.ComboTesst_btn.UseVisualStyleBackColor = true;
            this.ComboTesst_btn.Click += new System.EventHandler(this.ComboTesst_btn_Click);
            // 
            // resultGridView
            // 
            this.resultGridView.AllowUserToOrderColumns = true;
            this.resultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGridView.Location = new System.Drawing.Point(136, 193);
            this.resultGridView.Name = "result_tbl";
            this.resultGridView.Size = new System.Drawing.Size(509, 150);
            this.resultGridView.TabIndex = 6;
            // 
            // BookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 447);
            this.Controls.Add(this.resultGridView);
            this.Controls.Add(this.ComboTesst_btn);
            this.Controls.Add(this.myCombo);
            this.Controls.Add(this.label1);
            this.Name = "BookSearch";
            this.Text = "BookSearch";
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox myCombo;
        private Button ComboTesst_btn;
        private DataGridView resultGridView;
    }
}