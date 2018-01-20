using System;
using System.Windows.Forms;

namespace FM
{
    public partial class TruckMode : Form
    {
        public TruckMode()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                this.Close();
                EditTrucks edit = new EditTrucks();
                edit.Show();
            }

            else if (radioButton2.Checked == true)
            {
                this.Close();
                AddTrucks add = new AddTrucks();
                add.Show();
            }

            else
            {
                this.Close();
                DeleteTrucks del = new DeleteTrucks();
                del.Show();
                    
                    }

        }
    }
}
