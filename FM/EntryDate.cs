using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FM
{
    public partial class EntryDate : Form
    {
        public EntryDate()
        {
            InitializeComponent();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime nowDateOnly = now.Date;
            DateTime trial = dateTimePicker1.Value;
            DateTime trialDateOnly = trial.Date;

            if (trialDateOnly > nowDateOnly)
            { MessageBox.Show("Date cannot be in the future. Please re-enter."); }

            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = GlobalVar.conString;
                con.Open();


                using (SqlCommand StrQuer = new SqlCommand("SELECT Date, Warehouse FROM Dates WHERE Warehouse=@warehouse AND Date=@date", con))
                {
                    StrQuer.Parameters.AddWithValue("@warehouse", (int)GlobalVar._whse);
                    StrQuer.Parameters.AddWithValue("@date", trialDateOnly);
                    SqlDataReader dr = StrQuer.ExecuteReader();


                        if (dr.HasRows)

                        {
                            MessageBox.Show("All trucks have been entered for this date. If you need to modify an entry, use 'Edit Records' instead. Otherwise, pick a different date to enter records for.");
                            con.Close();
                        }
                        else

                        {
                            GlobalVar._date = trialDateOnly;
                            con.Close();
                            this.Close();
                        // Analyzer suggesting removing this to avoid disposing
                        // more than one     this.Dispose();
                            Form inst = new Records();
                            inst.Show();
                         
                        }
                    }



                    
                }





            }
        }
    }
