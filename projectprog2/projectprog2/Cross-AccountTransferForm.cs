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
    public partial class CrossAccountTransferForm : Form
    {
        Connect con = new Connect();
        DataTable dt = new DataTable();
        public CrossAccountTransferForm()
        {
            InitializeComponent();
            intialState();


            
            
        }
        //saat di klik
        private void clickedState() {
            cmb1.Items.Clear();
            cmb2.Items.Clear();
            lblbalance1.Text = "";
            lblbalance2.Text = "";
            pic1.Image = null;
            pic2.Image = null;
            numtrf1.Value = 0;
            numtrf2.Value = 0;
        }
        //kondisi awal
        private void intialState() {
            cmb1.Text = null;
            cmb2.Text = null;
            String query = "select AccountID,AccountName from msAccount";
            dt = con.openDataTableQuery(query);
            foreach (DataRow row in dt.Rows) {
                string AccountID = row["AccountID"].ToString() + "-" + row["AccountName"].ToString();
                //String AccountBalance = row["accountBalance"].ToString();
                cmb1.Items.Add(AccountID);
                cmb2.Items.Add(AccountID);
            }
        }
        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            //gett  transfer ammount
            String[] tampung = cmb1.Text.Split('-');
            double balance1=Convert.ToDouble(lblbalance1.Text);
            String test = numtrf1.Value.ToString()+"."+numtrf2.Value.ToString();
            double transfer = Convert.ToDouble(test);
            double total1 = balance1 - transfer;



            String[] tampung2 = cmb2.Text.Split('-');
            double balance2 = Convert.ToDouble(lblbalance2.Text);
            double total2 = balance2 + transfer;

            //validasi jika combobox1 = combobox2
            if (cmb1.Text == cmb2.Text) {
                MessageBox.Show("You can’t transfer to same account");
            } else if (transfer<=0) {
                //validasi jika transfer == 0 
                MessageBox.Show("Transfer amount must be greater than zero");
            } else {
                //update account balance
                String query = "update msAccount set accountBalance = '" + total1 + "' where accountID = '" + tampung[0] + "'";
                con.openDataTableQuery(query);

                String query2 = "update msAccount set accountBalance = '" + total2 + "' where accountID = '" + tampung2[0] + "'";
                con.openDataTableQuery(query2);
                clickedState();
                intialState();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            //event saat combobox dipilih
            pic1.Image = null;
            String[] tampung = cmb1.Text.Split('-');
            String query = "select accountBalance,imageLocation from msAccount where accountID = '"+tampung[0]+"'";
            dt = con.openDataTableQuery(query);
            foreach (DataRow row in dt.Rows) {
                lblbalance1.Text = row["accountBalance"].ToString();
                String directory = row["imageLocation"].ToString();
                try {
                    pic1.Image = Image.FromFile(directory);
                } catch (Exception) {
                    
                }
                
            }
            //set transfer maximum
            String[] tampung2 = lblbalance1.Text.Split('.');
            numtrf1.Maximum = int.Parse(tampung2[0]);
                


            
        }

        private void cmb2_SelectedIndexChanged(object sender, EventArgs e) {
            //event ketika combobox2 dipilih
            pic2.Image = null;
            String[] tampung = cmb2.Text.Split('-');
            String query = "select accountBalance,imageLocation from msAccount where accountID = '" + tampung[0] + "'";
            dt = con.openDataTableQuery(query);
            foreach (DataRow row in dt.Rows) {
                lblbalance2.Text = row["accountBalance"].ToString();
                String directory = row["imageLocation"].ToString();
                try {
                    pic2.Image = Image.FromFile(directory);
                } catch (Exception) {

                }
                
            }

        }

        private void numtrf1_ValueChanged(object sender, EventArgs e) {
            //menetukan numtrf maximum
            try {
                String[] tampung2 = lblbalance1.Text.Split('.');
                if (numtrf1.Value == Convert.ToDecimal(tampung2[0])) {
                    numtrf2.Maximum = int.Parse(tampung2[1]);
                } else {
                    numtrf2.Maximum = 99;
                }
            } catch (Exception) {

            }

        }
    }
}
