using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void menuMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuMemberToolStripMenuItem = new();
            MdiParent = this;
            Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuBookToolStripMenuItem = new();
            MdiParent = this;
            Show();
        }

        private void menuBorrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuBorrowToolStripMenuItem = new();
            MdiParent = this;
            Show();

        }

        private void menuSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuSearchToolStripMenuItem = new();
            MdiParent = this;
            Show();
        }

        private void menuExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
