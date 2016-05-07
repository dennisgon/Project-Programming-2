using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class Main : Form {
        MasterAccount ma;
        TransactionTypeForm tr;
        CrossAccountTransferForm ca;
        InsertTransactionForm iT;
        ViewDeleteTransactionForm vd;
        public Main() {

            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void accoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //menampilkan form master account
            if (ma== null ||ma.IsDisposed) {
                ma = new MasterAccount();
                ma.MdiParent = this;
                ma.Show();
            }


        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Hide();
            Login lg = new Login();
            lg.Show();
            
        }

        private void transactionTypeToolStripMenuItem_Click(object sender, EventArgs e) {
            //menampilkan transaction type
            if (tr == null||tr.IsDisposed) {
                tr = new TransactionTypeForm();
                tr.MdiParent = this;
                tr.Show();
            }

        }

        private void crossAccountTransferToolStripMenuItem_Click(object sender, EventArgs e) {
            //menampilkan cross account transfer
            if (ca == null || ca.IsDisposed) {
                ca = new CrossAccountTransferForm();
                ca.MdiParent = this;
                ca.Show();
            }

        }

        private void insertTransactionToolStripMenuItem_Click(object sender, EventArgs e) {
            if (iT == null || iT.IsDisposed) {
                iT = new InsertTransactionForm();
                iT.MdiParent = this;
                iT.Show();
            }

        }

        private void viewDeleteTransactionToolStripMenuItem_Click(object sender, EventArgs e) {
            //menampilkan view delete transaction
            if (vd == null || vd.IsDisposed) {
                vd = new ViewDeleteTransactionForm();
                vd.MdiParent = this;
                vd.Show();
            }

        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e) {

        }
    }
}
