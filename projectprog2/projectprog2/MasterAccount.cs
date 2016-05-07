using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class MasterAccount : Form
    {
        string destFile;
        int test;
        Connect con = new Connect();
        DataTable dt = new DataTable();
        Login lg = new Login();
        String directory;

        public MasterAccount()
        {
            InitializeComponent();
            //memasukan userid ke label
            lbluserid.Text = Login.usernamePassword.userid;
            intialState();
            table();
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.Fill;

        }
        //state awal
        private void intialState() {
            directory = "";
            btnImage.Enabled = false;
            txtID.Enabled = false;
            txtName.Enabled = false;
            numBalance1.Enabled = false;
            numBalance2.Enabled = false;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            BtnDelete.Enabled = true;
            
        }
        //state saat di klik
        private void clikedState() {

            btnImage.Enabled = true;
            txtID.Enabled = false;
            txtName.Enabled = true;
            numBalance1.Enabled = true;
            numBalance2.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = false;
            btnInsert.Enabled = false ;
            btnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) {
            try {
                //membuka file dialog
                openFileDialog1.ShowDialog();
                directory = openFileDialog1.FileName;
                //mendapatkan directory folder image
                String test = Environment.CurrentDirectory.Replace("projectprog2\\bin\\Debug", "");

                //mengcopy gambar
                String picturename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                string fileName = picturename;
                string sourcePath = @"" + directory;
                string targetPath = test + @"Images";
                destFile = System.IO.Path.Combine(targetPath, fileName);
                System.IO.File.Copy(sourcePath, destFile, true);

                //menampilkan gambar
                pictureAccount.Image = Image.FromFile(destFile);

            } catch (Exception) {

            }



            

        }

        private void button5_Click(object sender, EventArgs e) {
            // mengecek panjang accountname
            if (txtName.Text.Length < 3 || txtName.Text.Length > 25) {
                MessageBox.Show("Name length must be between 3 and 25");
            } else {
                switch (test) {
                    case 1:

                        //insert
                        String balance = numBalance1.Value.ToString() + "." + numBalance2.Value.ToString();
                        String query2 = "insert into msaccount values('" + lbluserid.Text + "','" + txtID.Text + "','" + txtName.Text + "','" + balance + "','" + destFile + "')";
                        con.openDataTableQuery(query2);
                        table();
                        
                        break;
                    case 2:
                        //update
                        String balance2 = numBalance1.Value.ToString() + "." + numBalance2.Value.ToString();
                        String query4 = "Update MsAccount set accountName = '" + txtName.Text + "', accountBalance = '" + balance2 + "',imageLocation = '" + destFile + "' where accountID = '" + txtID.Text + "'";
                        con.openDataTableQuery(query4);
                        table();
                        break;

                }
                intialState();
            }
            
        }

        private void btnInsert_Click(object sender, EventArgs e) {
            //kondisi saat insert
            intialState();
            txtID.Text = "";
            txtName.Text = "";
            numBalance1.Value = 0;
            numBalance2.Value = 0;
            pictureAccount.Image = null;
            test = 1;
            clikedState();
            //menggenerate accountid
            if (dataGridView1.Rows.Count == 0) {
                txtID.Text = "ACC0000001";
            }else{
                String tampung = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value.ToString().Substring(3, 7);
                int test1 = int.Parse(tampung) + 1;
                txtID.Text = "ACC" + test1.ToString().PadLeft(7, '0');
	        }


            btnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            //kondisi saat update
            test = 2;
            clikedState();
            btnInsert.Enabled = false;
            BtnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            //kondisi saat delete
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            //bila tidak ada data yang dipilih
            if (txtID.Text == "") {
                MessageBox.Show("Data must be selected");
            } else {
                //dialog result verifikasi penghapusan
                DialogResult hasil = MessageBox.Show("All transactions related to this account will be deleted. Are you sure to delete this account?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (hasil == DialogResult.OK) {
                    //menghapus baris msaccount sesuai dengan accountid
                    String query3 = "Delete from MsAccount where accountID = '" + txtID.Text + "'";
                    con.openDataTableQuery(query3);
                    table();
                    intialState();

                } else {
                    intialState();
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            //cancel 
            intialState();
            pictureAccount.Image = null;
            txtID.Text = "";
        }
        //mencetak table di datagridview
        private void table() {
            String query = "select [accountID]=accountid,[accountName]=accountname,[accountBalance]=accountbalance,[imageLocation]=imagelocation from msaccount";
            dt = con.openDataTableQuery(query);
            DataView dv = dt.DefaultView;
            dv.Sort = "accountID";
            dt = dv.ToTable(); 
            dataGridView1.DataSource = dt;



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            //menampilkan isi datagridview ke dalam textbox
            try {
                int index = e.RowIndex;
                txtID.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txtName.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                String[] tampung = dataGridView1.Rows[index].Cells[2].Value.ToString().Split('.');
                numBalance1.Value = Convert.ToDecimal(tampung[0]);
                numBalance2.Value = Convert.ToDecimal(tampung[1]);
                if (dataGridView1.Rows[index].Cells[3].Value.ToString()=="") {
                    pictureAccount.Image = null;
                }else{
                    pictureAccount.Image = Image.FromFile(dataGridView1.Rows[index].Cells[3].Value.ToString());
                    directory = dataGridView1.Rows[index].Cells[3].Value.ToString();
	            }

            } catch (Exception) {
                
            }

                   
        }
    }
}
