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
    public partial class BorrowForm : Form
    {
        string filePath = "Borrows.txt";
        public BorrowForm()
        {
            InitializeComponent();
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string line =
                txtBookId.Text + "|" +
                txtMemberId.Text + "|" +
                dtFrom.Value.ToShortDateString() + "|" +
                dtTo.Value.ToShortDateString();

            File.AppendAllText(filePath, line + Environment.NewLine);

            MessageBox.Show("امانت ثبت شد");

            txtBookId.Clear();
            txtMemberId.Clear();
        }
    }
}
