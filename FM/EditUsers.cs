using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FM
{
    public partial class EditUsers : Form
    {
        public EditUsers()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gHBWFMDataSet);

        }

        private void EditUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gHBWFMDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.gHBWFMDataSet.Users);
           
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gHBWFMDataSet);

        }
    }
}
