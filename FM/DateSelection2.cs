using System;
using System.Windows.Forms;

namespace FM
{
    public partial class DateSelection2 : Form
    {
        public DateSelection2()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
             


            if (MessageBox.Show("Edit records for " + dateTimePicker1.Value.ToShortDateString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GlobalVar.__date = dateTimePicker1.Value.Date;
                this.Close();
                EditRecords ercrd = new EditRecords();
                ercrd.Show();
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
