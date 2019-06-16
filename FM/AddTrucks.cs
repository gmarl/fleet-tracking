using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FM
{
    public partial class AddTrucks : Form
    {
        public AddTrucks()
        {
            InitializeComponent();
        }

        private void AddTrucks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gHBWFMDataSet.Truck' table. You can move, or remove it, as needed.
            this.truckTableAdapter.Fill(this.gHBWFMDataSet.Truck);
            // TODO: This line of code loads data into the 'gHBWFMDataSet.Warehouse' table. You can move, or remove it, as needed.
            this.warehouseTableAdapter.Fill(this.gHBWFMDataSet.Warehouse);
            // TODO: This line of code loads data into the 'gHBWFMDataSet.Duty' table. You can move, or remove it, as needed.
            this.dutyTableAdapter.Fill(this.gHBWFMDataSet.Duty);
            // TODO: This line of code loads data into the 'gHBWFMDataSet.Type' table. You can move, or remove it, as needed.
            this.typeTableAdapter.Fill(this.gHBWFMDataSet.Type);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void typeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeListBox.GetItemText(typeListBox.SelectedItem).Trim() == "Package" || typeListBox.GetItemText(typeListBox.SelectedItem).Trim() == "Hybrid")
            { capacityTextBox.Text = "n/a";
                capacityTextBox.Enabled = false;
                odometerTextBox.Enabled = true;
            }
            else { capacityTextBox.Enabled = true;
                capacityTextBox.Text = "0";
                odometerTextBox.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string _rental = "";
            string _odometer = odometerTextBox.Text.ToString().Trim();
            string _capacity = capacityTextBox.Text.ToString().Trim();
            int _type = int.Parse(typeListBox.SelectedValue.ToString());
            

            if (this.checkBox1.Checked == true)
            {
                _rental = "Y";
                _odometer = "0";
                odometerTextBox.Text = "0";
                odometerTextBox.Enabled = false;

            }

            else
            {
                _rental = "N";

            }

            if ((_capacity == "" || _capacity == "0" || _capacity == "n/a") && _type == 1)

            {
                MessageBox.Show("You must enter the bulk truck capacity.");
            }

            else
            {

                if ((_odometer == "" || _odometer == "0") && _rental == "N")
                {
                    MessageBox.Show("You must enter the odometer reading.");
                }

                else
                {

                    if (numTextBox.Text.Length > 10)
                    {
                        MessageBox.Show("Truck Number cannot exceed 10 characters.");
                    }



                    else
                    {
                        
                        int _duty = int.Parse(dutyListBox.SelectedValue.ToString());
                        int _user = GlobalVar._userid;
                        int _whse = int.Parse(whseListBox.SelectedValue.ToString());
                        string _date = System.DateTime.Now.ToShortDateString();
                        string _num = numTextBox.Text.ToString().Trim();
                        int _odom = int.Parse(this.odometerTextBox.Text.ToString().Trim());


                        if (MessageBox.Show("Add Truck number " + _num + " as duty " + dutyListBox.GetItemText(dutyListBox.SelectedItem).Trim() + " and type " + typeListBox.GetItemText(typeListBox.SelectedItem).Trim() + " with capacity of " + _capacity + " and Rental = " + _rental + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // user clicked yes
                            var connString = GlobalVar.conString;
                            SqlConnection cn = new SqlConnection(connString);
                            SqlCommand cmd = new SqlCommand
                            {
                                Connection = cn
                            };
                            cn.Open();
                            cmd.CommandText = "Insert into Truck (Num, Type, Duty, Warehouse, Capacity, LastChangedBy, LastChangeDate, Rental, Odometer) Values(@Num, @Type, @Duty, @Warehouse, @Capacity, @LastChangedBy, @LastChangeDate, @Rental, @Odometer)";
                            cmd.Parameters.AddWithValue("@Num", _num);
                            cmd.Parameters.AddWithValue("@Type", _type);
                            cmd.Parameters.AddWithValue("@Duty", _duty);
                            cmd.Parameters.AddWithValue("@Warehouse", _whse);
                            cmd.Parameters.AddWithValue("@Capacity", _capacity);
                            cmd.Parameters.AddWithValue("@LastChangedBy", _user);
                            cmd.Parameters.AddWithValue("@LastChangeDate", _date);
                            cmd.Parameters.AddWithValue("@Rental", _rental);
                            cmd.Parameters.AddWithValue("@Odometer", _odom);



                            try
                            {

                                cmd.ExecuteNonQuery();

                                //cn.Close();

                                MessageBox.Show("Record added");
                                numTextBox.Text = "";
                                capacityTextBox.Text = "";
                                odometerTextBox.Text = "";

                            }

                            catch (SqlException se)
                            {
                                MessageBox.Show("This truck number already exists. Truck numbers must be unique." + se.Message);
                                //cn.Close();
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
                }

        }
    }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                
                odometerTextBox.Text = "0";
                odometerTextBox.Enabled = false;

            }

            else
            {
                odometerTextBox.Enabled = true;

            }
        }
    }
    }

