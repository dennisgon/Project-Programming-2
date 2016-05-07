using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class Login : Form {
        Connect con = new Connect();
        DataTable dTable;

        public Login() {
            InitializeComponent();
            lblerror.Text = "Username and Password must be filled";
        }
        
        private void label3_Click(object sender, EventArgs e) {

        }



        private void button2_Click(object sender, EventArgs e) {
            //mereset txtpassword dan txtusername menjadi kembali seperti semula
            txtpassword.Text = "";
            txtusername.Text = "";
        }

        private void button1_Click(object sender, EventArgs e) {
                //melihat username dan password di database
                String query = "select userid  from msuser where username ='" + txtusername.Text + "' and password = '" + txtpassword.Text + "'";
                dTable = con.openDataTableQuery(query);
                //bila sesuai dengan database
                if (lblerror.Text == "") {
                    usernamePassword.userid = dTable.Rows[0].ItemArray[0].ToString();
                    //usernamePassword.password = txtpassword.Text;
                    //MessageBox.Show(dTable.Rows[0].ItemArray[0].ToString());
                    lblerror.Text = "";
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                }             
        }

        private void Login_Load(object sender, EventArgs e) {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //membuka form registration
            Registration rg = new Registration();
            rg.Show();
            this.Hide();
            
            
        }

        private void txtusername_TextChanged(object sender, EventArgs e) {
            String query = "select * from msuser where username ='" + txtusername.Text + "' and password = '" + txtpassword.Text + "'";
            dTable = con.openDataTableQuery(query);
            //validasi txtpassword dan txtusername
            if (txtpassword.Text == "" && txtusername.Text == "") {
                lblerror.Text = "Username and Password must be filled";
            }
            //validiasi txtusername
            else if (txtusername.Text == "") {
                lblerror.Text = "username must be filled";
            } 
            //validasi txtpassword
            else if (txtpassword.Text == "") {
                lblerror.Text = "Password must be filled";
            } else if (dTable.Rows.Count <= 0) {
                lblerror.Text ="Username or Password is invalid";
            }
            else {
                lblerror.Text = "";

            }
            
        }

        private void txtpassword_TextChanged(object sender, EventArgs e) {
            String query = "select * from msuser where username ='" + txtusername.Text + "' and password = '" + txtpassword.Text + "'";
            dTable = con.openDataTableQuery(query);
            //validasi txtpassword dan txtusername
            if (txtpassword.Text == "" && txtusername.Text == "") {
                lblerror.Text = "Username and Password must be filled";
            } 
            //validasi txtpassword
            else if (txtpassword.Text == "") {
                lblerror.Text = "Password must be filled";
            } 
            //validasi txtusername
            else if (txtusername.Text == "") {
                lblerror.Text = "username must be filled";
            } 
            else if (dTable.Rows.Count <= 0) {
                lblerror.Text = "Username or Password is invalid";
            }
            else {
                lblerror.Text = "";
            }
        }
        //global variable untuk username dan password
        public class usernamePassword {
            //global variable untuk userid
            static String _userid;
            public static String userid {
                set {
                    _userid = value;
                }
                get {
                    return _userid;
                }
            }
        }
    }
}
