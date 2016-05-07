namespace WindowsFormsApplication1
{
    partial class CrossAccountTransferForm
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
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.btntrf = new System.Windows.Forms.Button();
            this.numtrf2 = new System.Windows.Forms.NumericUpDown();
            this.numtrf1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblbalance1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblbalance2 = new System.Windows.Forms.Label();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numtrf2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numtrf1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(13, 22);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(48, 50);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 18;
            this.pic1.TabStop = false;
            // 
            // btntrf
            // 
            this.btntrf.Location = new System.Drawing.Point(13, 197);
            this.btntrf.Name = "btntrf";
            this.btntrf.Size = new System.Drawing.Size(452, 46);
            this.btntrf.TabIndex = 17;
            this.btntrf.Text = "Transfer";
            this.btntrf.UseVisualStyleBackColor = true;
            this.btntrf.Click += new System.EventHandler(this.button1_Click);
            // 
            // numtrf2
            // 
            this.numtrf2.Location = new System.Drawing.Point(305, 166);
            this.numtrf2.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numtrf2.Name = "numtrf2";
            this.numtrf2.Size = new System.Drawing.Size(36, 20);
            this.numtrf2.TabIndex = 15;
            // 
            // numtrf1
            // 
            this.numtrf1.Location = new System.Drawing.Point(163, 166);
            this.numtrf1.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.numtrf1.Name = "numtrf1";
            this.numtrf1.Size = new System.Drawing.Size(120, 20);
            this.numtrf1.TabIndex = 16;
            this.numtrf1.ValueChanged += new System.EventHandler(this.numtrf1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Transfer Amount";
            // 
            // lblbalance1
            // 
            this.lblbalance1.AutoSize = true;
            this.lblbalance1.Location = new System.Drawing.Point(379, 30);
            this.lblbalance1.Name = "lblbalance1";
            this.lblbalance1.Size = new System.Drawing.Size(0, 13);
            this.lblbalance1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Balance :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "From";
            // 
            // cmb2
            // 
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Location = new System.Drawing.Point(163, 101);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(121, 21);
            this.cmb2.TabIndex = 5;
            this.cmb2.SelectedIndexChanged += new System.EventHandler(this.cmb2_SelectedIndexChanged);
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(163, 22);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(121, 21);
            this.cmb1.TabIndex = 6;
            this.cmb1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Balance :";
            // 
            // lblbalance2
            // 
            this.lblbalance2.AutoSize = true;
            this.lblbalance2.Location = new System.Drawing.Point(379, 109);
            this.lblbalance2.Name = "lblbalance2";
            this.lblbalance2.Size = new System.Drawing.Size(0, 13);
            this.lblbalance2.TabIndex = 9;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(12, 101);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(48, 50);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 18;
            this.pic2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rp.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rp.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = ".";
            // 
            // CrossAccountTransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 261);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.btntrf);
            this.Controls.Add(this.numtrf2);
            this.Controls.Add(this.numtrf1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblbalance2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblbalance1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb2);
            this.Controls.Add(this.cmb1);
            this.Name = "CrossAccountTransferForm";
            this.Text = "Transfer Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numtrf2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numtrf1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button btntrf;
        private System.Windows.Forms.NumericUpDown numtrf2;
        private System.Windows.Forms.NumericUpDown numtrf1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblbalance1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb2;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblbalance2;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}