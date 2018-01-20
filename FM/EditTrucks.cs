using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FM
{
    public partial class EditTrucks : Form
    {
        public EditTrucks()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _num = oldNumTextBox.Text.Trim();
            string _type = "";
            string _whse = "";
            string _cap = "";
            string _duty = "";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = GlobalVar.conString;
            con.Open();


            using (SqlCommand StrQuer = new SqlCommand("SELECT Type.Description, Duty.Description as Duty, Warehouse.Name as whse, Capacity FROM Truck, Duty, Type, Warehouse WHERE truck.duty = duty.id and truck.type = type.id and truck.warehouse = warehouse.id and Truck.Num = @Num", con))
            {
                StrQuer.Parameters.AddWithValue("@Num", _num);
                SqlDataReader dr = StrQuer.ExecuteReader();


                while (dr.Read())
                {
                    _type = dr.GetValue(0).ToString().Trim();
                    _duty = dr.GetValue(1).ToString().Trim();
                    _whse = dr.GetValue(2).ToString().Trim();
                    _cap = dr.GetValue(3).ToString().Trim();



                }

                //   SqlCommand cmd = new SqlCommand("select Loginid, Password from Users where LoginID='" + textBox1.Text + "'and password='" + textBox2.Text + "'", con);
                //    SqlDataAdapter da  (int)= new SqlDataAdapter(cmd);
                //   DataTable dt = new DataTable();
                //    da.Fill(dt);
                if (dr.HasRows)
                //     if (dt.Rows.Count > 0)
                {
                    oldCapTextBox.Text = _cap;
                    oldDutyTextBox.Text = _duty;
                    oldTypeTextBox.Text = _type;
                    oldWhseTextBox.Text = _whse;
                    con.Close();
                    newCapTextBox.Text = _cap;
                }

                else
                {
                    MessageBox.Show("Invalid Truck Number: Please Re-enter.");
                    con.Close();
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (oldDutyTextBox.Text.Trim() == "")
            {
                MessageBox.Show("You must click Retrieve first.");
            }
            else
            {
                int _type2 = int.Parse(newTypeListBox.SelectedValue.ToString());
                int _duty2 = int.Parse(newDutyListBox.SelectedValue.ToString());
                int _user = GlobalVar._userid;
                int _whse2 = int.Parse(newWhseListBox.SelectedValue.ToString());
                string _date = System.DateTime.Now.ToShortDateString();
                string _num = oldNumTextBox.Text.ToString().Trim();
                string _capacity = newCapTextBox.Text.ToString().Trim();


                if (MessageBox.Show("Change Truck Number " + _num + " from " + oldDutyTextBox.Text.ToString().Trim() + ", type " + oldTypeTextBox.Text.ToString().Trim() + " with capacity of " + _capacity + " and assigned to " + oldWhseTextBox.Text.ToString().Trim() + "    TO:     " + newDutyListBox.GetItemText(newDutyListBox.SelectedItem).ToString().Trim() + ", type " + newTypeListBox.GetItemText(newTypeListBox.SelectedItem).ToString().Trim() + " with capacity of " + newCapTextBox.Text.ToString().Trim() + " and assigned to " + newWhseListBox.GetItemText(newWhseListBox.SelectedItem).ToString().Trim() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes
                    var connString = GlobalVar.conString;
                    SqlConnection cn = new SqlConnection(connString);
                    SqlCommand cmd = new SqlCommand();


                    cmd.Connection = cn;
                    cn.Open();
                    cmd.CommandText = "Update Truck Set Type = @Type, Duty = @Duty, Warehouse = @Warehouse, Capacity = @Capacity, LastChangedBy = @LastChangedBy, LastChangeDate = @LastChangeDate Where (Num = @Num)";// Values(@Type, @Duty, @Warehouse, @Capacity, @LastChangedBy, @LastChangeDate, @Num)";
                    cmd.Parameters.AddWithValue("@Num", _num);
                    cmd.Parameters.AddWithValue("@Type", _type2);
                    cmd.Parameters.AddWithValue("@Duty", _duty2);
                    cmd.Parameters.AddWithValue("@Warehouse", _whse2);
                    cmd.Parameters.AddWithValue("@Capacity", _capacity);
                    cmd.Parameters.AddWithValue("@LastChangedBy", _user);
                    cmd.Parameters.AddWithValue("@LastChangeDate", _date);



                    try
                    {

                        cmd.ExecuteNonQuery();

                        //cn.Close();

                        MessageBox.Show("Record updated");
                        oldNumTextBox.Text = "";
                        oldCapTextBox.Text = "";
                        oldWhseTextBox.Text = "";
                        oldTypeTextBox.Text = "";
                        oldDutyTextBox.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex.Message);
                       
                    }
                    cn.Close();
                }
            }
        }

        private void EditTrucks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gHBWFMDataSet.Warehouse' table. You can move, or remove it, as needed.
            this.warehouseTableAdapter.Fill(this.gHBWFMDataSet.Warehouse);
            // TODO: This line of code loads data into the 'gHBWFMDataSet.Duty' table. You can move, or remove it, as needed.
            this.dutyTableAdapter.Fill(this.gHBWFMDataSet.Duty);
            // TODO: This line of code loads data into the 'gHBWFMDataSet.Type' table. You can move, or remove it, as needed.
            this.typeTableAdapter.Fill(this.gHBWFMDataSet.Type);

        }
    }
}


