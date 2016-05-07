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
    public partial class ViewDeleteTransactionForm : Form
    {
        Connect con = new Connect();
        DataTable dt = new DataTable();
        String tampung = "";
        String tampung2 = "";
        String tampung3 = "";
        String tampung4 = "";
        public ViewDeleteTransactionForm()
        {
            InitializeComponent();
            dataGridTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //merubah format datetime1 dan datetime2
            dateTime1.Format = DateTimePickerFormat.Custom;
            dateTime1.CustomFormat = "d/M/yyyy";
            dateTime2.Format = DateTimePickerFormat.Custom;
            dateTime2.CustomFormat = "d/M/yyyy";

        }
        //mencetak table
        private void cetakTable(){
            String query = "select a.headerID,detailID ,b.accountID,accountName,type,[transactionDate]=convert(varchar(2), day(transactionDate)) + '/' + convert(varchar(2), month(transactionDate)) + '/' + convert(varchar(4), year(transactionDate)),ammount from TransactionHeader a join MsAccount b on a.accountID = b.accountID join MsTransactionType c on a.transactionTypeID = c.transactionTypeID join TransactionDetail d on a.headerID = d.headerID where transactiondate >= '" + dateTime1.Value.ToString() + "' and transactiondate <='" + dateTime2.Value.ToString() + "'";
            dt = con.openDataTableQuery(query);
            DataView dv = dt.DefaultView;
            dv.Sort = "accountID";
            dt = dv.ToTable(); 
            dataGridTransaction.DataSource = dt;
            dataGridTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTransaction.Columns[0].Visible = false;
            this.dataGridTransaction.Columns[1].Visible = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
 
            cetakTable();
        }

        private void ViewDeleteTransactionForm_Load(object sender, EventArgs e) {

        }

        private void btnDelete_Click(object sender, EventArgs e) {
            //jika data gridview = 0
            if (dataGridTransaction.Rows.Count == 0) {
                
            }else{
                //verivikaso delete 
                DialogResult hasil = MessageBox.Show("All transactions related to this account will be deleted. Are you sure to delete this account?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (hasil == DialogResult.OK) {
                    //jika ok
                    

                    if (tampung != ""&& tampung2 !="" && tampung3 !="" &&tampung4 !="") {
                        //delete transaction header
                        String query = "Delete from TransactionHeader where headerID = '" + tampung + "'";
                        con.openDataTableQuery(query);
                        //mengambil accountbalance
                        String query3 = "select accountBalance from MsAccount where accountID = '" + tampung4 + "'";

                        DataTable dt = con.openDataTableQuery(query3);
                        double accountBalance = double.Parse(dt.Rows[0].ItemArray[0].ToString());
                        double penambah = double.Parse(tampung3);
                        String total = (accountBalance + penambah).ToString();
                        //update msaccount
                        String query4 = "update MsAccount set accountBalance = '" + total + "' where accountID = '" + tampung4 + "'";
                        con.openDataTableQuery(query4);
                        //delete transaction detail
                        String query2 = "Delete from TransactionDetail where detailID = '" + tampung2 + "' and headerID = '" + tampung + "'";

                        con.openDataTableQuery(query2);
                        cetakTable();
                        tampung = "";
                        tampung2 = "";
                        tampung3 = "";
                        tampung4 = "";
                    } else {
                        //jika no
                        
                    }

                }

            } 
        }

        private void dataGridTransaction_CellClick(object sender, DataGridViewCellEventArgs e) {
            //menampung varible sesuai dengan datagridview yang di klik
            try {
                int index = e.RowIndex;
                tampung = dataGridTransaction.Rows[index].Cells[0].Value.ToString();
                tampung2 = dataGridTransaction.Rows[index].Cells[1].Value.ToString();
                tampung3 = dataGridTransaction.Rows[index].Cells[6].Value.ToString();
                tampung4 = dataGridTransaction.Rows[index].Cells[2].Value.ToString();

            } catch (Exception) {

            }

        }

        private void dataGridTransaction_CellEnter(object sender, DataGridViewCellEventArgs e) {

        }

        private void dataGridTransaction_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {

        }

    }
}
