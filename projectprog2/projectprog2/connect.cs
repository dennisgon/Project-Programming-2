using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApplication1 {
            class Connect {
            private SqlConnection con;
            private String constr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + Application.StartupPath + @"\Database1.mdf;Integrated Security=True;User Instance=True";
            private SqlDataAdapter adapter;
            private SqlDataReader reader;
            private SqlCommand cmd;
            private DataTable dt;
            private SqlTransaction transaction;
                

            public void openConnection() {
                con = new SqlConnection(constr);
                if (con.State != ConnectionState.Closed) {
                    con.Close();
                }
            }

            public void openReaderQuery(String query) {
                try {
                    openConnection();
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = query;
                    reader = cmd.ExecuteReader();
                } catch (Exception e) {
                    MessageBox.Show(e.Message);
                }
                con.Close();
            }

            public DataTable openDataTableQuery(String query) {

                try {
                    openConnection();
                    con.Open();
                    dt = new DataTable();
                    dt.Clear();
                    adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(dt);
                } catch (Exception e) {
                    MessageBox.Show(e.Message);
                }
                con.Close();
                return dt;
            }
            public void exec(String query) {
                openConnection();
                con.Open();
                using (SqlCommand record = new SqlCommand(query, con)) {
                    record.CommandText = query;
                    record.ExecuteNonQuery();

                }
                con.Close();
            }
            public void addUser(string a, string b, string c) {

                openConnection();
                con.Open();
                transaction = con.BeginTransaction("");
                using (SqlCommand record = new SqlCommand("INSERT INTO MsUser VALUES(@id,@name,@pass)", con)) {
                    record.Parameters.AddWithValue("@id", a);
                    record.Parameters.AddWithValue("@name", b);
                    record.Parameters.AddWithValue("@pass", c);
                    record.Transaction = transaction;
                    record.ExecuteNonQuery();
                    transaction.Commit();
                }
            }
        }


    }

