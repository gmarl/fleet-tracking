using System;
using System.Windows.Forms;

namespace FM
{
    public partial class EditUsers : Form
    {
        public EditUsers()
        {
            InitializeComponent();
        }

       

        private void EditUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gHBWFMDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.gHBWFMDataSet.Users);
           
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save changes?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    this.Validate();
                    this.usersBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.gHBWFMDataSet);
                    MessageBox.Show("Record successfully updated.");
                }
                    catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                
            }
            
            }
            else
            {

            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
