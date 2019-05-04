using System;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace FM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length > 10 || this.textBox2.Text.Length > 10)
            {
                MessageBox.Show("Login ID and/or password cannot exceed 10 characters each. Please re-enter.");

            }

            else
            {

                string LoginID = textBox1.Text;
                string Password = textBox2.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = GlobalVar.conString;
                con.Open();


                using (SqlCommand StrQuer = new SqlCommand("SELECT ID, Security, Warehouse FROM Users WHERE Login=@userid AND Password=@password", con))
                {
                    StrQuer.Parameters.AddWithValue("@userid", LoginID);
                    StrQuer.Parameters.AddWithValue("@password", Password);
                    SqlDataReader dr = StrQuer.ExecuteReader();


                    while (dr.Read())
                    {
                        GlobalVar._userid = (int)dr.GetValue(0);
                        GlobalVar._security = (int)dr.GetValue(1);
                        GlobalVar._whse = (int)dr.GetValue(2);


                    }

                        //   SqlCommand cmd = new SqlCommand("select Loginid, Password from Users where LoginID='" + textBox1.Text + "'and password='" + textBox2.Text + "'", con);
                        //    SqlDataAdapter da  (int)= new SqlDataAdapter(cmd);
                        //   DataTable dt = new DataTable();
                        //    da.Fill(dt);
                        if (dr.HasRows)
                        //     if (dt.Rows.Count > 0)
                        {
                        // MessageBox.Show("     Login sucess     ");

                        if (GlobalVar._whse == 0)
                        {
                            con.Close();
                            this.Hide();
                            SelectWarehouse slctwrhse = new SelectWarehouse();
                            slctwrhse.Show();
                        }

                        else
                        {
                            con.Close();
                            this.Hide();
                            
                            MainPage frm = new MainPage();
                            frm.Show();
                        }
                    }
                        else
                        {
                            MessageBox.Show("Invalid Login: Please check Login ID and Password");
                        con.Close();
                    }
                        
                    }
               

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

       
    }
}
