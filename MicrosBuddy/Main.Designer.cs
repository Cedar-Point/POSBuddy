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
            this.lblHelpTopic = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.lboxHelp = new System.Windows.Forms.ListBox();
            this.BottomTable = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.Browser = new System.Windows.Forms.WebBrowser();
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
            this.MainTable.Controls.Add(this.BottomTable, 1, 2);
            this.MainTable.Controls.Add(this.Browser, 1, 1);
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
            // lblHelpTopic
            // 
            this.lblHelpTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHelpTopic.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpTopic.Location = new System.Drawing.Point(3, 0);
            this.lblHelpTopic.Name = "lblHelpTopic";
            this.lblHelpTopic.Size = new System.Drawing.Size(294, 75);
            this.lblHelpTopic.TabIndex = 5;
            this.lblHelpTopic.Text = "Menu";
            this.lblHelpTopic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(303, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(846, 75);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Please wait...";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lboxHelp.Click += new System.EventHandler(this.LboxHelp_Click);
            // 
            // BottomTable
            // 
            this.BottomTable.ColumnCount = 3;
            this.BottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BottomTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BottomTable.Controls.Add(this.btnBack, 0, 0);
            this.BottomTable.Controls.Add(this.btnForward, 2, 0);
            this.BottomTable.Controls.Add(this.btnCustom, 1, 0);
            this.BottomTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomTable.Location = new System.Drawing.Point(300, 580);
            this.BottomTable.Margin = new System.Windows.Forms.Padding(0);
            this.BottomTable.Name = "BottomTable";
            this.BottomTable.RowCount = 1;
            this.BottomTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomTable.Size = new System.Drawing.Size(852, 75);
            this.BottomTable.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(284, 75);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnForward.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.Location = new System.Drawing.Point(568, 0);
            this.btnForward.Margin = new System.Windows.Forms.Padding(0);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(284, 75);
            this.btnForward.TabIndex = 4;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.BtnForward_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCustom.Enabled = false;
            this.btnCustom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCustom.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustom.Location = new System.Drawing.Point(284, 0);
            this.btnCustom.Margin = new System.Windows.Forms.Padding(0);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(284, 75);
            this.btnCustom.TabIndex = 3;
            this.btnCustom.UseVisualStyleBackColor = false;
            // 
            // Browser
            // 
            this.Browser.AllowWebBrowserDrop = false;
            this.Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browser.IsWebBrowserContextMenuEnabled = false;
            this.Browser.Location = new System.Drawing.Point(300, 75);
            this.Browser.Margin = new System.Windows.Forms.Padding(0);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(852, 505);
            this.Browser.TabIndex = 7;
            this.Browser.Url = new System.Uri("", System.UriKind.Relative);
            this.Browser.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.Browser_ProgressChanged);
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHelpTopic;
        private System.Windows.Forms.TableLayoutPanel BottomTable;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.WebBrowser Browser;
    }
}

