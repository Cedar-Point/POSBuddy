namespace POSBuddy
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
            this.btnHome = new System.Windows.Forms.Button();
            this.lboxHelp = new System.Windows.Forms.ListBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHelpTopic = new System.Windows.Forms.Label();
            this.BottomTable = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.MainTable.SuspendLayout();
            this.BottomTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Controls.Add(this.lblHelpTopic, 0, 0);
            this.MainTable.Controls.Add(this.lblTitle, 1, 0);
            this.MainTable.Controls.Add(this.btnHome, 0, 2);
            this.MainTable.Controls.Add(this.lboxHelp, 0, 1);
            this.MainTable.Controls.Add(this.MainPanel, 1, 1);
            this.MainTable.Controls.Add(this.BottomTable, 1, 2);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 3;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.Size = new System.Drawing.Size(1152, 655);
            this.MainTable.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(0, 580);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(300, 75);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Exit";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lboxHelp
            // 
            this.lboxHelp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lboxHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboxHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxHelp.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxHelp.FormattingEnabled = true;
            this.lboxHelp.IntegralHeight = false;
            this.lboxHelp.ItemHeight = 37;
            this.lboxHelp.Items.AddRange(new object[] {
            "Please wait..."});
            this.lboxHelp.Location = new System.Drawing.Point(0, 75);
            this.lboxHelp.Margin = new System.Windows.Forms.Padding(0);
            this.lboxHelp.Name = "lboxHelp";
            this.lboxHelp.Size = new System.Drawing.Size(300, 505);
            this.lboxHelp.TabIndex = 1;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(300, 75);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(852, 505);
            this.MainPanel.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(303, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(846, 75);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Micros Help";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHelpTopic
            // 
            this.lblHelpTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHelpTopic.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpTopic.Location = new System.Drawing.Point(3, 0);
            this.lblHelpTopic.Name = "lblHelpTopic";
            this.lblHelpTopic.Size = new System.Drawing.Size(294, 75);
            this.lblHelpTopic.TabIndex = 5;
            this.lblHelpTopic.Text = "Help Topics";
            this.lblHelpTopic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BottomTable
            // 
            this.BottomTable.ColumnCount = 3;
            this.BottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BottomTable.Controls.Add(this.button3, 0, 0);
            this.BottomTable.Controls.Add(this.button2, 2, 0);
            this.BottomTable.Controls.Add(this.button1, 1, 0);
            this.BottomTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomTable.Location = new System.Drawing.Point(300, 580);
            this.BottomTable.Margin = new System.Windows.Forms.Padding(0);
            this.BottomTable.Name = "BottomTable";
            this.BottomTable.RowCount = 1;
            this.BottomTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomTable.Size = new System.Drawing.Size(852, 75);
            this.BottomTable.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(283, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 75);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(566, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(286, 75);
            this.button2.TabIndex = 4;
            this.button2.Text = "Forward";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(283, 75);
            this.button3.TabIndex = 5;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1152, 655);
            this.Controls.Add(this.MainTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "MicrosBuddy";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainTable.ResumeLayout(false);
            this.BottomTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.ListBox lboxHelp;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHelpTopic;
        private System.Windows.Forms.TableLayoutPanel BottomTable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

