using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FM
{
    public partial class DeleteTrucks : Form
    {
        public DeleteTrucks()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string _num = numTextBox.Text.Trim();
            string _type = "";
            string _capacity = "";
            string _whse = "";
            string _duty = "";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = GlobalVar.conString;
            con.Open();


            using (SqlCommand StrQuer = new SqlCommand("SELECT Duty.Description, Type.Description AS Expr1, Warehouse.Name, Truck.Capacity FROM Duty, Type, Warehouse, Truck Where Duty.ID = Truck.Duty AND Type.ID = Truck.Type and Warehouse.ID = Truck.Warehouse AND Truck.num = @num", con))
            {
                StrQuer.Parameters.AddWithValue("@num", _num);
                
                SqlDataReader dr = StrQuer.ExecuteReader();


                while (dr.Read())
                {
                   _duty = dr.GetValue(0).ToString().Trim();
                   _type = dr.GetValue(1).ToString().Trim();
                   _whse = dr.GetValue(2).ToString().Trim();
                   _capacity = dr.GetValue(3).ToString().Trim();


                }
                if (dr.HasRows)
           
                {
                    dutyTextBox.Text = _duty;
                    typeTextBox.Text = _type;
                    whseTextBox.Text = _whse;
                    capacityTextBox.Text = _capacity;
                   
                }
                else
                {
                    MessageBox.Show("This is not a valid Truck Number. Please re-enter.");
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

               if (MessageBox.Show("Are you sure you want to delete Truck number " +numTextBox.Text.Trim() +"? This action cannot be undone.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes
                    var connString = GlobalVar.conString;
                    SqlConnection cn = new SqlConnection(connString);
                    SqlCommand cmd = new SqlCommand();


                    cmd.Connection = cn;
                    cn.Open();
                    cmd.CommandText = "Delete from Truck Where Truck.num = @Num";
                    cmd.Parameters.AddWithValue("@Num", numTextBox.Text.Trim());
                
                    try
                    {

                        cmd.ExecuteNonQuery();

                        cn.Close();

                        MessageBox.Show("Record deleted");
                        numTextBox.Text = "";
                        capacityTextBox.Text = "";
                        whseTextBox.Text = "";
                        typeTextBox.Text = "";
                        dutyTextBox.Text = "";

                }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex.Message);
                        cn.Close();
                    }
                }
                else
                {
                    // user clicked no
                }


            }
        }
    }

