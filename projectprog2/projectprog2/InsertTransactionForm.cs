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
    public partial class InsertTransactionForm : Form
    {
        Connect con = new Connect();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable dt5 = new DataTable();
        string hValue1;
        String hValue2;
        public InsertTransactionForm()
        {
            InitializeComponent();
            //menampikan  combobox account
            String query = "select AccountID,AccountName from msAccount";
            dt = con.openDataTableQuery(query);
            foreach (DataRow row in dt.Rows) {
                //cmbaccount.Items.Add(row["AccountName"].ToString());
                cmbaccount.Items.Add(new ComboBoxItem(row["AccountName"].ToString(),row["AccountID"].ToString()));
            }
            //memasukan combobox type
            String query2 = "select transactionTypeID,type from MsTransactionType";
            dt2 = con.openDataTableQuery(query2);
            foreach (DataRow row in dt2.Rows) {
                cmbType.Items.Add(new ComboBoxItem(row["type"].ToString(), row["transactionTypeID"].ToString()));
            }
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void InsertTransactionForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double test=0;
            double test2=0;
            String tampung = numAmmount1.Value.ToString() + "." + numAmmount2.Value.ToString();
            try {
                test = Convert.ToDouble(tampung);
                test2 = Convert.ToDouble(lblBalance.Text); 
            } catch (Exception) {
                
            }
 
            //validasi combbobox udah dipilih
            if (cmbaccount.SelectedIndex == -1 || cmbType.SelectedIndex == -1) {
                MessageBox.Show("Account and Type must be selected");
            } else if (test<=0) {
                //validasi jika balance sudah lebih dari 0
                MessageBox.Show("Amount must be greater than zero");
            } else if (test>test2) {
                //validasi jika insert lebih besar dari ammount
                MessageBox.Show("The account balance is not enough for this transaction");
            } else {
                
                String headerID;
                //generate headerid
                String query4 = "select TOP 1 HeaderID from TransactionHeader ORDER BY HeaderID DESC";
                dt3 = con.openDataTableQuery(query4);
                if (dt3.Rows.Count==0) {
                    headerID = "HTR0000001";
                } else {
                    String tampung1 = dt3.Rows[0].ItemArray[0].ToString().Substring(3, 7);
                    headerID = "HTR" + (int.Parse(tampung1) + 1).ToString().PadLeft(7, '0');
                }
                
                //insert transactionheader
                String tanggal = DateTime.Now.ToString();
                String query2 = "insert into TransactionHeader values('" + Login.usernamePassword.userid + "','" + hValue1 + "','" + hValue2 + "','" + headerID + "','" + tanggal + "')";
                con.openDataTableQuery(query2);
                //generate detailid
                String detailID;
                String query5 = "select TOP 1 detailID from TransactionDetail ORDER BY detailID DESC";
                dt4 = con.openDataTableQuery(query5);
                if (dt4.Rows.Count == 0) {
                    detailID = "DTR0000001";
                } else {
                    String tampung1 = dt4.Rows[0].ItemArray[0].ToString().Substring(3, 7);
                    detailID = "DTR" + (int.Parse(tampung1) + 1).ToString().PadLeft(7, '0');
                }
                //insert transaction detail
                String query3 = "insert into TransactionDetail values('" + headerID + "','" + detailID + "','" + test + "')";
                con.openDataTableQuery(query3);
                //update msaccount
                double updateBalance = test2 - test;
                String query7 = "update MsAccount set accountBalance = '" + updateBalance + "' where accountID = '" + hValue1 + "' ";
                con.openDataTableQuery(query7);
                lblBalance.Text = updateBalance.ToString();
            }
        }

        private void cmbaccount_SelectedIndexChanged(object sender, EventArgs e) {
            //mendapatkan balance
            hValue1 = ((ComboBoxItem)cmbaccount.SelectedItem).HiddenValue;
            String query = "select accountBalance from msAccount where accountID = '"+hValue1+"' and accountName = '" + cmbaccount.Text + "'";
            dt2 = con.openDataTableQuery(query);
            foreach (DataRow row in dt2.Rows) {
                lblBalance.Text = row["accountBalance"].ToString();
            }
            String[] tampung2 = lblBalance.Text.Split('.');
            numAmmount1.Maximum = int.Parse(tampung2[0]);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            try {
                String[] tampung2 = lblBalance.Text.Split('.');
                if (numAmmount1.Value == Convert.ToDecimal(tampung2[0])) {
                    numAmmount2.Maximum = int.Parse(tampung2[1]);
                } else {
                    numAmmount2.Maximum = 99;
                }
            } catch (Exception) {

            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e) {
            hValue2 = ((ComboBoxItem)cmbType.SelectedItem).HiddenValue;
        }
    }
    public class ComboBoxItem {
        string kelihatan;
        string hiddenValue;

        public ComboBoxItem(string d, string h) {
            kelihatan = d;
            hiddenValue = h;
        }
        public string HiddenValue {
            get {
                return hiddenValue;
            }
        }
        public override string ToString() {
            return kelihatan;
        }
    }
}
