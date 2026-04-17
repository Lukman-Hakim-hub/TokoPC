using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TokoPC.Views.Panels;

namespace TokoPC.Views
{
    public partial class PublicForm : Form
    {
        public PublicForm()
        {
            InitializeComponent();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(new DashboardPanel());
        }

        private void changeProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(new ChangeProfilePanel());
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(new ChangePasswordPanel());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin akan keluar?", "Konfirmasi",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(new OrderPanel());
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(new HistoryPanel());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(new AboutPanel());
        }
    }
}
