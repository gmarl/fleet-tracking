using System;
using System.Windows.Forms;

namespace FM
{
    public partial class EditRecords : Form
    {
        public EditRecords()
        {
            InitializeComponent();
        }

        //private void recordsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Save changes?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        //    {
        //        try
        //        {
        //            this.Validate();
        //            this.recordsBindingSource.EndEdit();
        //            this.tableAdapterManager.UpdateAll(this.gHBWFMDataSet);
        //            MessageBox.Show("Records successfully updated.");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error" + ex.Message);

        //        }

        //    }
        //    else
        //    {



        //    }

        //}

        private void EditRecords_Load(object sender, EventArgs e)
        {
           
            this.recordsTableAdapter.FillBy2(this.gHBWFMDataSet.Records, GlobalVar.__date.ToShortDateString(), GlobalVar._whse);

          

        }

       
        private void recordsBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save changes?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    this.Validate();
                    this.recordsBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.gHBWFMDataSet);
                    MessageBox.Show("Records successfully updated.");
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
    }
}
