namespace MicrosBuddy
{
    partial class Main
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
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.TopTable = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lboxHelp = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.MainTable.SuspendLayout();
            this.TopTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Controls.Add(this.TopTable, 0, 0);
            this.MainTable.Controls.Add(this.lboxHelp, 0, 1);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 2;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Size = new System.Drawing.Size(1152, 655);
            this.MainTable.TabIndex = 0;
            // 
            // TopTable
            // 
            this.TopTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TopTable.ColumnCount = 3;
            this.MainTable.SetColumnSpan(this.TopTable, 2);
            this.TopTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.TopTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TopTable.Controls.Add(this.lblTitle, 0, 0);
            this.TopTable.Controls.Add(this.btnClose, 2, 0);
            this.TopTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopTable.Location = new System.Drawing.Point(0, 0);
            this.TopTable.Margin = new System.Windows.Forms.Padding(0);
            this.TopTable.Name = "TopTable";
            this.TopTable.RowCount = 1;
            this.TopTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopTable.Size = new System.Drawing.Size(1152, 50);
            this.TopTable.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(294, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Micros Help";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lboxHelp
            // 
            this.lboxHelp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lboxHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxHelp.FormattingEnabled = true;
            this.lboxHelp.IntegralHeight = false;
            this.lboxHelp.Items.AddRange(new object[] {
            "Please wait..."});
            this.lboxHelp.Location = new System.Drawing.Point(0, 50);
            this.lboxHelp.Margin = new System.Windows.Forms.Padding(0);
            this.lboxHelp.Name = "lboxHelp";
            this.lboxHelp.Size = new System.Drawing.Size(300, 605);
            this.lboxHelp.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Location = new System.Drawing.Point(1052, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1152, 655);
            this.Controls.Add(this.MainTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "MicrosBuddy";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainTable.ResumeLayout(false);
            this.TopTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.TableLayoutPanel TopTable;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lboxHelp;
        private System.Windows.Forms.Button btnClose;
    }
}

