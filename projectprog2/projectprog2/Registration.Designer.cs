namespace WindowsFormsApplication1 {
    partial class Registration {
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtconfirmpass = new System.Windows.Forms.TextBox();
            this.btnregis = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.lblerroruser = new System.Windows.Forms.Label();
            this.lblerrorpass = new System.Windows.Forms.Label();
            this.lblerrorcon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(119, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Registration Form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(83, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(83, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(200, 66);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(172, 20);
            this.txtuser.TabIndex = 14;
            this.txtuser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(200, 112);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(172, 20);
            this.txtpass.TabIndex = 15;
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtconfirmpass
            // 
            this.txtconfirmpass.Location = new System.Drawing.Point(200, 151);
            this.txtconfirmpass.Name = "txtconfirmpass";
            this.txtconfirmpass.Size = new System.Drawing.Size(172, 20);
            this.txtconfirmpass.TabIndex = 16;
            this.txtconfirmpass.UseSystemPasswordChar = true;
            this.txtconfirmpass.TextChanged += new System.EventHandler(this.txtconfirmpass_TextChanged);
            // 
            // btnregis
            // 
            this.btnregis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregis.Location = new System.Drawing.Point(13, 217);
            this.btnregis.Name = "btnregis";
            this.btnregis.Size = new System.Drawing.Size(251, 39);
            this.btnregis.TabIndex = 17;
            this.btnregis.Text = "Register (Enter)";
            this.btnregis.UseVisualStyleBackColor = true;
            this.btnregis.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(270, 216);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(210, 39);
            this.btncancel.TabIndex = 18;
            this.btncancel.Text = "Cancel (Esc)";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // lblerroruser
            // 
            this.lblerroruser.AutoSize = true;
            this.lblerroruser.BackColor = System.Drawing.Color.LightGray;
            this.lblerroruser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerroruser.ForeColor = System.Drawing.Color.DarkRed;
            this.lblerroruser.Location = new System.Drawing.Point(208, 96);
            this.lblerroruser.Name = "lblerroruser";
            this.lblerroruser.Size = new System.Drawing.Size(0, 13);
            this.lblerroruser.TabIndex = 19;
            this.lblerroruser.Click += new System.EventHandler(this.lblerroruser_Click);
            // 
            // lblerrorpass
            // 
            this.lblerrorpass.AutoSize = true;
            this.lblerrorpass.BackColor = System.Drawing.Color.LightGray;
            this.lblerrorpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrorpass.ForeColor = System.Drawing.Color.DarkRed;
            this.lblerrorpass.Location = new System.Drawing.Point(208, 135);
            this.lblerrorpass.Name = "lblerrorpass";
            this.lblerrorpass.Size = new System.Drawing.Size(0, 13);
            this.lblerrorpass.TabIndex = 20;
            this.lblerrorpass.Click += new System.EventHandler(this.lblerrorpass_Click);
            // 
            // lblerrorcon
            // 
            this.lblerrorcon.AutoSize = true;
            this.lblerrorcon.BackColor = System.Drawing.Color.LightGray;
            this.lblerrorcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrorcon.ForeColor = System.Drawing.Color.DarkRed;
            this.lblerrorcon.Location = new System.Drawing.Point(208, 174);
            this.lblerrorcon.Name = "lblerrorcon";
            this.lblerrorcon.Size = new System.Drawing.Size(0, 13);
            this.lblerrorcon.TabIndex = 22;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(515, 275);
            this.Controls.Add(this.lblerrorcon);
            this.Controls.Add(this.lblerrorpass);
            this.Controls.Add(this.lblerroruser);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnregis);
            this.Controls.Add(this.txtconfirmpass);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money Manager :: Registration Form";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtconfirmpass;
        private System.Windows.Forms.Button btnregis;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label lblerroruser;
        private System.Windows.Forms.Label lblerrorpass;
        private System.Windows.Forms.Label lblerrorcon;
    }
}