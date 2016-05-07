using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TransactionTypeForm : Form
    {
        Connect con = new Connect();
        DataTable dt = new DataTable();
        int test;
        public TransactionTypeForm()
        {
            InitializeComponent();
            //set lbluserid
            lbluserid.Text = Login.usernamePassword.userid;
            table();
            intialState();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //stateawal
        private void intialState() {

            txttrid.Enabled = false;
            txttype.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            BtnDelete.Enabled = true;
        }
        //menginput datagridview
        private void table() {
            String query = "select transactionTypeID,type from MsTransactionType";
            dt = con.openDataTableQuery(query);
            dataGridView1.DataSource = dt;
            DataView dv = dt.DefaultView;
            dv.Sort = "transactionTypeID";
            dt = dv.ToTable(); 

        }
        //state saat di klik
        private void clikedState() {

            txttrid.Enabled = false;
            txttype.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = false;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
        }
        private void btnInsert_Click(object sender, EventArgs e) {
            //kondisi saat button insert di klik
            intialState();
            txttrid.Text = "";
            txttype.Text = "";
            test = 1;
            clikedState();
            txttype.Enabled = true;
            //generate transaction typeid
            if (dataGridView1.Rows.Count == 0) {
                //bila belum ada transactiontypeid
                txttrid.Text = "TYP0000001";
            } else {
                //bila ada transactiontypeid
                String tampung = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value.ToString().Substring(3, 7);
                int test1 = int.Parse(tampung) + 1;
                txttrid.Text = "TYP" + test1.ToString().PadLeft(7, '0'); ;
            }

            btnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (txttype.Text == "") {
                MessageBox.Show("Type must be filled");
            } else {
                switch (test) {
                    case 1:
                        String query2 = "insert into MsTransactionType values('" + lbluserid.Text + "','" + txttrid.Text + "','" + txttype.Text + "')";
                        con.openDataTableQuery(query2);
                        table();
                        break;
                    case 2:
                        String query4 = "Update MsTransactionType set type = '" + txttype.Text + "' where transactionTypeID = '" + txttrid.Text + "'";
                        con.openDataTableQuery(query4);
                        table();
                        break;

                }
                intialState();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            test = 2;
            clikedState();
            txttype.Enabled = true;
            btnInsert.Enabled = false;
            BtnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            int index = e.RowIndex;
            try {
                txttrid.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txttype.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            } catch (Exception) {

            }

        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            if (txttrid.Text == "") {
                MessageBox.Show("Data must be selected");
            } else {
                DialogResult hasil = MessageBox.Show("All transactions related to this transaction type will be deleted. Are you sure to delete this account?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (hasil == DialogResult.OK) {
                    String query3 = "Delete from MsTransactionType where transactionTypeID = '" + txttrid.Text + "'";
                    //MessageBox.Show(query3);
                    con.openDataTableQuery(query3);
                    table();
                    intialState();

                } else {
                    intialState();
                }
            }
        }

        private void TransactionTypeForm_Load(object sender, EventArgs e) {

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            intialState();
            txttrid.Text = "";
        }



    }
}
