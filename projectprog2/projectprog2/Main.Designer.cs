namespace WindowsFormsApplication1 {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crossAccountTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDeleteTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.masterToolStripMenuItem,
            this.crossAccountTransferToolStripMenuItem,
            this.transactionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accoutToolStripMenuItem,
            this.transactionTypeToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            this.masterToolStripMenuItem.Click += new System.EventHandler(this.masterToolStripMenuItem_Click);
            // 
            // accoutToolStripMenuItem
            // 
            this.accoutToolStripMenuItem.Name = "accoutToolStripMenuItem";
            this.accoutToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.accoutToolStripMenuItem.Text = "Accout";
            this.accoutToolStripMenuItem.Click += new System.EventHandler(this.accoutToolStripMenuItem_Click);
            // 
            // transactionTypeToolStripMenuItem
            // 
            this.transactionTypeToolStripMenuItem.Name = "transactionTypeToolStripMenuItem";
            this.transactionTypeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.transactionTypeToolStripMenuItem.Text = "Transaction Type";
            this.transactionTypeToolStripMenuItem.Click += new System.EventHandler(this.transactionTypeToolStripMenuItem_Click);
            // 
            // crossAccountTransferToolStripMenuItem
            // 
            this.crossAccountTransferToolStripMenuItem.Name = "crossAccountTransferToolStripMenuItem";
            this.crossAccountTransferToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.crossAccountTransferToolStripMenuItem.Text = "Cross-Account Transfer";
            this.crossAccountTransferToolStripMenuItem.Click += new System.EventHandler(this.crossAccountTransferToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertTransactionToolStripMenuItem,
            this.viewDeleteTransactionToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // insertTransactionToolStripMenuItem
            // 
            this.insertTransactionToolStripMenuItem.Name = "insertTransactionToolStripMenuItem";
            this.insertTransactionToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.insertTransactionToolStripMenuItem.Text = "Insert Transaction";
            this.insertTransactionToolStripMenuItem.Click += new System.EventHandler(this.insertTransactionToolStripMenuItem_Click);
            // 
            // viewDeleteTransactionToolStripMenuItem
            // 
            this.viewDeleteTransactionToolStripMenuItem.Name = "viewDeleteTransactionToolStripMenuItem";
            this.viewDeleteTransactionToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.viewDeleteTransactionToolStripMenuItem.Text = "View/Delete Transaction";
            this.viewDeleteTransactionToolStripMenuItem.Click += new System.EventHandler(this.viewDeleteTransactionToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 377);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Money Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crossAccountTransferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDeleteTransactionToolStripMenuItem;
    }
}