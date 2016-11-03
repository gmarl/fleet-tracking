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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void warehousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void enterDailyInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form date = new EntryDate();
            date.Show();
        }

        private void trucksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalVar._security != 1 && GlobalVar._security != 2)
            { MessageBox.Show("You do not have permission to perform this task."); }
            else
            {
                TruckMode mode = new TruckMode();
                    mode.Show(); }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUsers frm = new EditUsers();
            frm.Show();
        }

        private void recordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRecords rcrd = new EditRecords();
            rcrd.Show();
        }

        private void builtReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports rprt = new Reports();
            rprt.Show();
        }

        private void sQLReportingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQL_Reports sqlrprt = new SQL_Reports();
            sqlrprt.Show();
        }
    }
}
