using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace FM
{
    public partial class EntryDate : Form
    {
        public EntryDate()
        {
            InitializeComponent();

        }

        //private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{
        //}

        private void OKButton_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime nowDateOnly = now.Date;
            DateTime trial = dateTimePicker1.Value;
            DateTime trialDateOnly = trial.Date;

            if (trialDateOnly > nowDateOnly)
            { MessageBox.Show("Date cannot be in the future. Please re-enter."); }



            else
            {
                var connString = GlobalVar.conString;

                using (SqlConnection c = new SqlConnection(connString))
                {
                    c.Open();

                    // use a SqlAdapter to execute the query
                    using (SqlDataAdapter a = new SqlDataAdapter("DECLARE @Whse int, @Day date SET @Whse = " + GlobalVar._whse + " SET @Day = '" + trialDateOnly.ToShortDateString() + "'  select convert(varchar, requireddate, 101) as requireddate from RequiredDates where requiredDate <@Day and RequiredDate >= getdate()-30 and RequiredDate not in (select date from dates where Warehouse = @Whse and date < @Day and date >= (getdate() - 30))", c))
                    {
                        // fill a data table
                        var t = new DataTable();
                        a.Fill(t);



                        if (t.Rows.Count > 0)
                        {

                            try
                            {

                                string output = string.Empty;
                                for (int i = 0; i < t.Rows.Count; i++)
                                {
                                    output = output + t.Rows[i]["RequiredDate"].ToString();
                                    output += (i < t.Rows.Count) ? "  -  " : string.Empty;
                                }

                                //c.Close();

                                MessageBox.Show("Entries are not yet completed for " + output);


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error" + ex.Message);
                                // c.Close();
                            }

                        }


                        SqlConnection con = new SqlConnection
                        {
                            ConnectionString = GlobalVar.conString
                        };
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

    

    private void CancelButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
    
