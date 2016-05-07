namespace WindowsFormsApplication1
{
    partial class ViewDeleteTransactionForm
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
            this.dataGridTransaction = new System.Windows.Forms.DataGridView();
            this.dateTime2 = new System.Windows.Forms.DateTimePicker();
            this.dateTime1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTransaction
            // 
            this.dataGridTransaction.AllowUserToAddRows = false;
            this.dataGridTransaction.AllowUserToDeleteRows = false;
            this.dataGridTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTransaction.Location = new System.Drawing.Point(12, 40);
            this.dataGridTransaction.Name = "dataGridTransaction";
            this.dataGridTransaction.ReadOnly = true;
            this.dataGridTransaction.Size = new System.Drawing.Size(557, 150);
            this.dataGridTransaction.TabIndex = 0;
            this.dataGridTransaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTransaction_CellClick);
            this.dataGridTransaction.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTransaction_CellEnter);
            this.dataGridTransaction.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridTransaction_CellMouseClick);
            // 
            // dateTime2
            // 
            this.dateTime2.Location = new System.Drawing.Point(203, 15);
            this.dateTime2.Name = "dateTime2";
            this.dateTime2.Size = new System.Drawing.Size(119, 20);
            this.dateTime2.TabIndex = 2;
            this.dateTime2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTime1
            // 
            this.dateTime1.Location = new System.Drawing.Point(52, 14);
            this.dateTime1.Name = "dateTime1";
            this.dateTime1.Size = new System.Drawing.Size(119, 20);
            this.dateTime1.TabIndex = 3;
            this.dateTime1.Value = new System.DateTime(2014, 12, 26, 0, 0, 0, 0);
            this.dateTime1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "To";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(338, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 19);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(12, 196);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(557, 95);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ViewDeleteTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 295);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTime1);
            this.Controls.Add(this.dateTime2);
            this.Controls.Add(this.dataGridTransaction);
            this.Name = "ViewDeleteTransactionForm";
            this.Text = "View/Delete Transaction Form";
            this.Load += new System.EventHandler(this.ViewDeleteTransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTransaction;
        private System.Windows.Forms.DateTimePicker dateTime2;
        private System.Windows.Forms.DateTimePicker dateTime1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
    }
}