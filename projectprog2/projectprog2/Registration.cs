using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1 {
    public partial class Registration : Form {
        int flag1 = 0;
        int flag2 = 0;
        int flag3 = 0;
        Connect con = new Connect();
        Connect con2 = new Connect();
        DataTable dt;
        Login lg = new Login();
        public Registration() {
            InitializeComponent();
            btnregis.Enabled = false;
            lblerroruser.Text = "Username must be filled";
            lblerrorpass.Text = "Password must be filled";
            txtconfirmpass.Enabled = false;
            if (flag1 == 1 && flag2 == 1 && flag3 ==1) {
                btnregis.Enabled = true;
            }
            //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + Application.StartupPath + @"\Database1.mdf;Integrated Security=True;User Instance=True");
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            Boolean error= false;
            //mengecek txtuser merupakan digit atau letter
            for (int i = 0; i < txtuser.Text.Length; i++) {
                if (char.IsDigit(txtuser.Text[i])||char.IsLetter(txtuser.Text[i])) {
                    error = false;
                } else {
                    error = true;
                    break;
                }
            }
            //validasi txtuser terisi
            if (txtuser.Text == ""){
                flag1 = 0;
                lblerroruser.Text = "Username must be filled";
            }
            //validasi txtuser lebih besar dari 3 dan lebih besar dari 12
            else if (txtuser.Text.Length<3||txtuser.Text.Length>12) {
                flag1 = 0;
                lblerroruser.Text = "Username length must be between 3 – 12 characters";
            }
            //validasi txtuser alphanumeric
            else if (error == true) {
                flag1 = 0;
                lblerroruser.Text = "Username must contain only alphanumeric characters";
            } else {
                lblerroruser.Text = "";
                flag1 = 1;
                
            }
            if (flag1 == 1 && flag2 == 1) {
                txtconfirmpass.Enabled = true;
            } else {
                txtconfirmpass.Enabled = false;
            }
            if (flag1 == 1 && flag2 == 1 && flag3 == 1) {
                btnregis.Enabled = true;
            } else {
                btnregis.Enabled = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e) {
            //generate id number
            string query2 = "select userid from msuser";
            dt = con.openDataTableQuery(query2);
            int jmlId = dt.Rows.Count+1;
            String b = jmlId.ToString().PadLeft(7, '0');
            string userID = "USR" + b;

            String query = "insert into msuser values('" +userID+ "','" +txtuser.Text+ "','" +txtpass.Text+ "')";
            //con2.openDataTableQuery(query);
            con2.exec(query);
            //con2.addUser(userID, txtuser.Text, txtpass.Text);
            lg.Show();
            this.Close();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void lblerroruser_Click(object sender, EventArgs e)
        {

        }

        private void lblerrorpass_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //validasi txtpass sudah terisi
            if (txtpass.Text == ""){
                flag2 = 0;
                lblerrorpass.Text = "Password must be filled";
            }
            //validasi txtpass lebih besar dari 5 dan lebih kecil dari 12
            else if (txtpass.Text.Length<5||txtpass.Text.Length>12) {
                flag2 = 0;
                lblerrorpass.Text = "Password length must be between 5 – 12 characters";
            } else {
                lblerrorpass.Text = "";
                flag2 = 1;
            }
            if (flag1 == 1 && flag2 == 1) {
                txtconfirmpass.Enabled = true;
            } else {
                txtconfirmpass.Enabled = false;
            }
            if (flag1 == 1 && flag2 == 1 && flag3 == 1) {
                btnregis.Enabled = true;
            } else {
                btnregis.Enabled = false;
            }
        }

        private void txtconfirmpass_TextChanged(object sender, EventArgs e) {
            //validasi txtconfirmpass == txtpass
            if (txtconfirmpass.Text != txtpass.Text) {
                flag3 = 0;
                lblerrorcon.Text = "Password and Confirm Password does not match";
            } else {
                lblerrorcon.Text = "";
                flag3 = 1;
            }
            if (flag1 == 1 && flag2 == 1 && flag3 == 1) {
                btnregis.Enabled = true;
            } else {
                btnregis.Enabled = false;
            }
        }

        private void btncancel_Click(object sender, EventArgs e) {
            lg.Show();
            this.Close();
            
        }
    }
}
