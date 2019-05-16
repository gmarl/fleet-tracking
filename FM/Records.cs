using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FM
{
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
            this.textBox1.Text = GlobalVar._date.ToShortDateString();
            setwhse();
            this.userTextBox.Text = GlobalVar._userid.ToString();
      
        }

        


        private void recordsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.recordsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gHBWFMDataSet);

        }

        private void Records_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gHBWFMDataSet.Truck' table. You can move, or remove it, as needed.
            this.truckTableAdapter.Fill(this.gHBWFMDataSet.Truck);
            // TODO: This line of code loads data into the 'gHBWFMDataSet.OOS' table. You can move, or remove it, as needed.
            this.oOSTableAdapter.Fill(this.gHBWFMDataSet.OOS);
            // TODO: This line of code loads data into the 'gHBWFMDataSet.Type' table. You can move, or remove it, as needed.
            this.typeTableAdapter.Fill(this.gHBWFMDataSet.Type);
            // TODO: This line of code loads data into the 'gHBWFMDataSet.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.gHBWFMDataSet.Status);

            fillTrucks();

            // TODO: This line of code loads data into the 'gHBWFMDataSet.Records' table. You can move, or remove it, as needed.
            this.recordsTableAdapter.Fill(this.gHBWFMDataSet.Records);



        }

        public void setwhse()
        {
            if (GlobalVar._whse == 1)
            { this.warehouseTextBox.Text = "Canterbury"; }

            else if (GlobalVar._whse == 2)
            { this.warehouseTextBox.Text = "Dover"; }

            else if (GlobalVar._whse == 3)
            { this.warehouseTextBox.Text = "Hampden"; }

            else if (GlobalVar._whse == 4)
            { this.warehouseTextBox.Text = "Hartford"; }

            else if (GlobalVar._whse == 5)
            { this.warehouseTextBox.Text = "Manchester"; }

            else if (GlobalVar._whse == 6)
            { this.warehouseTextBox.Text = "Rutland"; }

            else if (GlobalVar._whse == 7)
            { this.warehouseTextBox.Text = "STJ"; }

            else if (GlobalVar._whse == 8)
            { this.warehouseTextBox.Text = "Syracuse"; }

            else if (GlobalVar._whse == 9)
            { this.warehouseTextBox.Text = "Westbrook"; }

            else if (GlobalVar._whse == 10)
            { this.warehouseTextBox.Text = "Wilton"; }

            else if (GlobalVar._whse == 11)
            { this.warehouseTextBox.Text = "Liverpool"; }

            else if (GlobalVar._whse == 12)
            { this.warehouseTextBox.Text = "Kingston"; }

            else if (GlobalVar._whse == 13)
            { this.warehouseTextBox.Text = "Tonawanda"; }

            else if (GlobalVar._whse == 14)
            { this.warehouseTextBox.Text = "Youngwood"; }
        }


        void fillTrucks()
        {
            var connString = GlobalVar.conString;

            using (SqlConnection c = new SqlConnection(connString))
            {
                c.Open();

                // use a SqlAdapter to execute the query
                using (SqlDataAdapter a = new SqlDataAdapter("DECLARE @warehouse int, @date datetime SET @warehouse = " + GlobalVar._whse + " SET @date = '" + GlobalVar._date.ToShortDateString() + "' Select Truck.Num From Truck Where Truck.Warehouse = @warehouse AND Truck.Num NOT IN (Select Records.Truck From Records Where Records.Date = @date and Records.Warehouse = @warehouse) ORDER BY Truck.Num", c))
                {
                    // fill a data table
                    var t = new DataTable();
                    a.Fill(t);

                    if (t.Rows.Count == 0)
                    {
                        int _whse = GlobalVar._whse;
                        string _date = GlobalVar._date.ToShortDateString();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = c;
                        cmd.CommandText = "Insert into Dates (Date, Warehouse) Values(@Date, @Warehouse)";
                        cmd.Parameters.AddWithValue("@Date", _date);
                        cmd.Parameters.AddWithValue("@Warehouse", _whse);

                        try
                        {

                            cmd.ExecuteNonQuery();

                            //c.Close();

                            MessageBox.Show("This completes the entries for this date.");
                           this.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex.Message);
                           // c.Close();
                        }
                        
                    }

                    else
                    { // Bind the table to the list box
                        listBox1.DisplayMember = "Num";
                        listBox1.ValueMember = "Num";
                        listBox1.DataSource = t;
                       // c.Close();

                        //Prepare remaining text boxes

                        this.galsTextBox.Text = "0";
                        this.mileTextBox.Text = "0";
                        this.fueltextBox.Text = "0";
                        
                        if (this.statusListBox.SelectedValue == null)
                        {
                            this.galsTextBox.Text = "0";
                            this.mileTextBox.Text = "0";
                            this.galsTextBox.Enabled = false;
                            this.fueltextBox.Text = "0";
                            this.mileTextBox.Enabled = false;
                            this.oOSListBox.Enabled = false;
                            this.fueltextBox.Enabled = false;

                        }
                        else
                        { string _status = this.statusListBox.SelectedValue.ToString();

                            if (_status == "0")
                            {
                                this.galsTextBox.Enabled = false;
                                this.mileTextBox.Enabled = false;
                                this.oOSListBox.Enabled = true;
                                this.fueltextBox.Enabled = false;

                            }

                            else if ( _status == "S")
                            {
                                this.galsTextBox.Enabled = false;
                                this.mileTextBox.Enabled = false;
                                this.oOSListBox.Enabled = true;
                                this.fueltextBox.Enabled = false;

                            }

                            else
                            {
                                this.galsTextBox.Enabled = true;
                                this.mileTextBox.Enabled = true;
                                this.oOSListBox.Enabled = false;
                                this.fueltextBox.Enabled = true;

                                if (capacityTextBox.Text.ToString() == "n/a" || capacityTextBox.Text.ToString() == "0")
                                {
                                    galsTextBox.Enabled = false;
                                }
                            }
                        }

                    }


                   




                }

                c.Close();
            }
        }

         void fillRemainder()
        {
            string _num = this.listBox1.SelectedValue.ToString();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = GlobalVar.conString;
            con.Open();


            using (SqlCommand StrQuer = new SqlCommand("Select Type.Description, Duty.Description, Truck.Capacity From Type, Duty, Truck Where Duty.ID = Truck.Duty AND Type.ID = Truck.Type AND Truck.Num = @Num", con))
            {
                StrQuer.Parameters.AddWithValue("@Num", _num);
                SqlDataReader dr = StrQuer.ExecuteReader();


                while (dr.Read())
                {
                    this.typeTextBox.Text = dr.GetValue(0).ToString();
                    this.dutyTextBox.Text = dr.GetValue(1).ToString();
                    this.capacityTextBox.Text = dr.GetValue(2).ToString();
                     }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                        fillRemainder();
            statusListBox_SelectedIndexChanged(sender, e);
                    }

                

            
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {


            if ((statusListBox.GetItemText(statusListBox.SelectedItem).Trim() == "Full Run" || statusListBox.GetItemText(statusListBox.SelectedItem).Trim() == "Partial Run") && (this.mileTextBox.Text.Trim() == "" || this.mileTextBox.Text.Trim() == "0"))
            {
                MessageBox.Show("You must enter the odometer reading.");
                this.mileTextBox.Select();
            }

            else if ((statusListBox.GetItemText(statusListBox.SelectedItem).Trim() == "Full Run" || statusListBox.GetItemText(statusListBox.SelectedItem).Trim() == "Partial Run") && (int.Parse(galsTextBox.Text)) < 1 && (this.typeTextBox.Text.Trim() == "Bulk" ))
            {
                MessageBox.Show("You must enter the gallons delivered");
                this.galsTextBox.Select();
            }

            else if ((statusListBox.GetItemText(statusListBox.SelectedItem).Trim() == "Not Used" ) && (oOSListBox.SelectedValue == null))
            {
                this.oOSListBox.Enabled = true;
                MessageBox.Show("You must select the reason the truck was not used.");
                this.oOSListBox.Select();
            }

            else
            {
                string _status = this.statusListBox.SelectedValue.ToString();
                int _type = 0;

                if (typeTextBox.Text.Trim() == "Bulk")
                { _type = 1; }
                else if (typeTextBox.Text.Trim() == "Package")
                { _type = 2; }
                else if (typeTextBox.Text.Trim() == "Hybrid")
                { _type = 3; }
                else { _type = 4; }
                int _miles = int.Parse(mileTextBox.Text);
                int _gals = int.Parse(galsTextBox.Text);
                int _fuel = int.Parse(fueltextBox.Text);
                int _duty = 0;
                if (dutyTextBox.Text.Trim() == "Frontline")
                { _duty = 1; }
                else { _duty = 2; }
                int _user = GlobalVar._userid;
                int _whse = GlobalVar._whse;
                string _date = GlobalVar._date.ToShortDateString();
                string _num = this.listBox1.SelectedValue.ToString().Trim();
                string _capacity = this.capacityTextBox.Text.Trim();
                

                if ((_type == 1 || _type == 4) && (_status == "1" || _status == "P"))
                     { if (MessageBox.Show("Truck " + _num + " has odometer reading of " + _miles + " , delivered " + _gals + " gallons and used "+ _fuel +" gallons of fuel on " + _date + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // user clicked yes
                        var connString = GlobalVar.conString;
                        SqlConnection cn = new SqlConnection(connString);
                        SqlCommand cmd = new SqlCommand();


                        cmd.Connection = cn;
                        cn.Open();
                        cmd.CommandText = "Insert into Records (Date, Warehouse, Truck, Status, Miles, Gallons, Type, UserID, Duty, Capacity, Fuel) Values(@Date, @Warehouse, @Truck, @Status, @Miles, @Gallons, @Type, @UserID, @Duty, @Capacity, @Fuel)";
                        cmd.Parameters.AddWithValue("@Date", _date);
                        cmd.Parameters.AddWithValue("@Warehouse", _whse);
                        cmd.Parameters.AddWithValue("@Truck", _num);
                        cmd.Parameters.AddWithValue("@Status", _status);
                        cmd.Parameters.AddWithValue("@Miles", _miles);
                        cmd.Parameters.AddWithValue("@Gallons", _gals);
                        cmd.Parameters.AddWithValue("@Type", _type);
                        cmd.Parameters.AddWithValue("@UserID", _user);
                        cmd.Parameters.AddWithValue("@Duty", _duty);
                        cmd.Parameters.AddWithValue("@Capacity", _capacity);
                        cmd.Parameters.AddWithValue("@Fuel", _fuel);



                        try
                        {

                            cmd.ExecuteNonQuery();

                            //cn.Close();

                            
                            fillTrucks();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex.Message);
                           // cn.Close();
                        }
                        cn.Close();
                    }
                    else
                    {
                        // user clicked no
                    }

                    
                }

                else if ((_type == 2 || _type == 3) && (_status == "1" || _status == "P"))
                {  if (MessageBox.Show("Truck " + _num + " has odometer reading of " + _miles + " , used " + _fuel + " gallons of fuel on " + _date + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // user clicked yes
                        var connString = GlobalVar.conString;
                        SqlConnection cn = new SqlConnection(connString);
                        SqlCommand cmd = new SqlCommand();


                        cmd.Connection = cn;
                        cn.Open();
                        cmd.CommandText = "Insert into Records (Date, Warehouse, Truck, Status, Miles, Gallons, Type, UserID, Duty, Capacity, Fuel) Values(@Date, @Warehouse, @Truck, @Status, @Miles, @Gallons, @Type, @UserID, @Duty, @Capacity, @Fuel)";
                        cmd.Parameters.AddWithValue("@Date", _date);
                        cmd.Parameters.AddWithValue("@Warehouse", _whse);
                        cmd.Parameters.AddWithValue("@Truck", _num);
                        cmd.Parameters.AddWithValue("@Status", _status);
                        cmd.Parameters.AddWithValue("@Miles", _miles);
                        cmd.Parameters.AddWithValue("@Gallons", 0);
                        cmd.Parameters.AddWithValue("@Type", _type);
                        cmd.Parameters.AddWithValue("@UserID", _user);
                        cmd.Parameters.AddWithValue("@Duty", _duty);
                        cmd.Parameters.AddWithValue("@Capacity", _capacity);
                        cmd.Parameters.AddWithValue("@Fuel", _fuel);



                        try
                        {

                            cmd.ExecuteNonQuery();

                            //cn.Close();

                            
                            fillTrucks();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex.Message);
                            //cn.Close();
                        }
                        cn.Close();

                    }
                    else
                    {
                        // user clicked no
                    }


                }


                else if ( _status == "0")
                {
                    if (MessageBox.Show("Truck " + _num + " was not used on " + _date + " because: "+oOSListBox.Text.TrimEnd()+"?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // user clicked yes
                        var connString = GlobalVar.conString;
                        SqlConnection cn = new SqlConnection(connString);
                        SqlCommand cmd = new SqlCommand();


                        cmd.Connection = cn;
                        cn.Open();
                        cmd.CommandText = "Insert into Records (Date, Warehouse, Truck, Status, Miles, Gallons, Type, UserID, Duty, OOS, Capacity) Values(@Date, @Warehouse, @Truck, @Status, @Miles, @Gallons, @Type, @UserID, @Duty, @OOS, @Capacity)";
                        cmd.Parameters.AddWithValue("@Date", _date);
                        cmd.Parameters.AddWithValue("@Warehouse", _whse);
                        cmd.Parameters.AddWithValue("@Truck", _num);
                        cmd.Parameters.AddWithValue("@Status", _status);
                        cmd.Parameters.AddWithValue("@Miles", _miles);
                        cmd.Parameters.AddWithValue("@Gallons", _gals);
                        cmd.Parameters.AddWithValue("@Type", _type);
                        cmd.Parameters.AddWithValue("@UserID", _user);
                        cmd.Parameters.AddWithValue("@Duty", _duty);
                        cmd.Parameters.AddWithValue("@OOS", oOSListBox.SelectedValue);
                        cmd.Parameters.AddWithValue("@Capacity", _capacity);



                        try
                        {

                            cmd.ExecuteNonQuery();

                            //cn.Close();

                           
                            fillTrucks();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex.Message);
                            //cn.Close();
                        }

                        cn.Close();
                    }
                    else
                    {
                        // user clicked no
                    }


                }


                else
                {
                    if (MessageBox.Show("Truck " + _num + " was not used on " + _date + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // user clicked yes
                        var connString = GlobalVar.conString;
                        SqlConnection cn = new SqlConnection(connString);
                        SqlCommand cmd = new SqlCommand();


                        cmd.Connection = cn;
                        cn.Open();
                        cmd.CommandText = "Insert into Records (Date, Warehouse, Truck, Status, Miles, Gallons, Type, UserID, Duty,  Capacity) Values(@Date, @Warehouse, @Truck, @Status, @Miles, @Gallons, @Type, @UserID, @Duty,  @Capacity)";
                        cmd.Parameters.AddWithValue("@Date", _date);
                        cmd.Parameters.AddWithValue("@Warehouse", _whse);
                        cmd.Parameters.AddWithValue("@Truck", _num);
                        cmd.Parameters.AddWithValue("@Status", _status);
                        cmd.Parameters.AddWithValue("@Miles", _miles);
                        cmd.Parameters.AddWithValue("@Gallons", _gals);
                        cmd.Parameters.AddWithValue("@Type", _type);
                        cmd.Parameters.AddWithValue("@UserID", _user);
                        cmd.Parameters.AddWithValue("@Duty", _duty);
                        cmd.Parameters.AddWithValue("@Capacity", _capacity);



                        try
                        {

                            cmd.ExecuteNonQuery();

                            // cn.Close();


                            fillTrucks();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex.Message);
                            // cn.Close();
                        }

                        cn.Close();
                    }
                    else
                    {
                        // user clicked no
                    }


                }
            }
        }

        private void statusListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.statusListBox.SelectedValue == null)
            {

            }

            else
            {
                string _status = this.statusListBox.SelectedValue.ToString();
                this.galsTextBox.Text = "0";
                this.mileTextBox.Text = "0";
                this.fueltextBox.Text = "0";

                if (_status == "S")
                {
                    this.oOSListBox.Enabled = true;
                    this.galsTextBox.Enabled = false;
                    this.mileTextBox.Enabled = false;
                    this.fueltextBox.Enabled = false;

                }
                else if (_status == "0" )
                {
                    this.oOSListBox.Enabled = true;
                    this.galsTextBox.Enabled = false;
                    this.mileTextBox.Enabled = false;
                    this.fueltextBox.Enabled = false;

                }
                else
                {
                    this.oOSListBox.Enabled = false;
                    this.galsTextBox.Enabled = true;
                    this.mileTextBox.Enabled = true;
                    this.fueltextBox.Enabled = true;

                    if (capacityTextBox.Text.ToString().Trim() == "n/a" || capacityTextBox.Text.ToString().Trim() == "0")
                    {
                        galsTextBox.Enabled = false;
                    }

                }
            }          

        }

        private void galsTextBox_Validating(object sender, CancelEventArgs e)
        {
            int numberEntered;

            if (int.TryParse(galsTextBox.Text, out numberEntered))
            {
                if (numberEntered < 0)
                {
                    MessageBox.Show("You cannot enter negative gallons");
                    galsTextBox.Select();
                }
            }
            else 
            {
                MessageBox.Show("You need to enter a valid number");
                galsTextBox.Select();
            }

        }

        private void mileTextBox_Validating(object sender, CancelEventArgs e)
        {
            int numberEntered;

            if (int.TryParse(mileTextBox.Text, out numberEntered))
            {
                if (numberEntered < 0)
                {
                    MessageBox.Show("You cannot enter negative odometer readings");
                    mileTextBox.Select();
                }
            }
            else
            {
                MessageBox.Show("You need to enter a valid number");
                mileTextBox.Select();
            }
        }


        private void fueltextBox_Validating(object sender, CancelEventArgs e)
        {
            int numberEntered;

            if (int.TryParse(fueltextBox.Text, out numberEntered))
            {
                if (numberEntered < 0)
                {
                    MessageBox.Show("You cannot enter negative fuel gallons");
                    fueltextBox.Select();
                }
            }
            else
            {
                MessageBox.Show("You need to enter a valid number");
                fueltextBox.Select();
            }
        }

        









    }
}

