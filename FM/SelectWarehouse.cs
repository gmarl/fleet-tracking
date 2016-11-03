﻿using System;
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
    public partial class SelectWarehouse : Form
    {
        public SelectWarehouse()
        {
            InitializeComponent();
        }

        private void warehouseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.warehouseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gHBWFMDataSet);

        }

        private void SelectWarehouse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gHBWFMDataSet.Warehouse' table. You can move, or remove it, as needed.
            this.warehouseTableAdapter.Fill(this.gHBWFMDataSet.Warehouse);

        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameListBox == null)
            { }
            else
            {
                if (MessageBox.Show("Use warehouse " + nameListBox.GetItemText(nameListBox.SelectedItem).Trim() + " for this session?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int result = int.Parse(nameListBox.SelectedValue.ToString());
                    GlobalVar._whse = result;
                    this.Hide();
                    MainPage frm = new MainPage();
                    frm.Show();
                }
                else
                { }
            }
        }
    }
}