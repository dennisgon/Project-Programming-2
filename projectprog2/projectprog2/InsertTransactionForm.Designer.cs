namespace WindowsFormsApplication1
{
    partial class InsertTransactionForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cmbaccount = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.numAmmount1 = new System.Windows.Forms.NumericUpDown();
            this.numAmmount2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAmmount1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmmount2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Balance";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ammount";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(26, 157);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(229, 60);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbaccount
            // 
            this.cmbaccount.FormattingEnabled = true;
            this.cmbaccount.Location = new System.Drawing.Point(95, 34);
            this.cmbaccount.Name = "cmbaccount";
            this.cmbaccount.Size = new System.Drawing.Size(193, 21);
            this.cmbaccount.TabIndex = 5;
            this.cmbaccount.SelectedIndexChanged += new System.EventHandler(this.cmbaccount_SelectedIndexChanged);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(95, 89);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(193, 21);
            this.cmbType.TabIndex = 6;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(95, 64);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 13);
            this.lblBalance.TabIndex = 7;
            // 
            // numAmmount1
            // 
            this.numAmmount1.Location = new System.Drawing.Point(98, 120);
            this.numAmmount1.Name = "numAmmount1";
            this.numAmmount1.Size = new System.Drawing.Size(105, 20);
            this.numAmmount1.TabIndex = 8;
            this.numAmmount1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numAmmount2
            // 
            this.numAmmount2.Location = new System.Drawing.Point(224, 120);
            this.numAmmount2.Name = "numAmmount2";
            this.numAmmount2.Size = new System.Drawing.Size(64, 20);
            this.numAmmount2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = ",";
            // 
            // InsertTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 227);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numAmmount2);
            this.Controls.Add(this.numAmmount1);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbaccount);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertTransactionForm";
            this.Text = "Insert Transaction";
            this.Load += new System.EventHandler(this.InsertTransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAmmount1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmmount2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox cmbaccount;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.NumericUpDown numAmmount1;
        private System.Windows.Forms.NumericUpDown numAmmount2;
        private System.Windows.Forms.Label label6;
    }
}