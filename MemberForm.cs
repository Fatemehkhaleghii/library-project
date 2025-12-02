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
    public partial class MemberForm : Form
    {
        string filePath = "Member.txt";
        public MemberForm()
        {
            InitializeComponent();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string line = txtId.Text + "|" + txtName.Text + "|" + txtPhone.Text;

            File.AppendAllText(filePath, line + Environment.NewLine);

            MessageBox.Show("عضو با موفقیت ذخیره شد");

            txtId.Clear();
            txtName.Clear();
            txtPhone.Clear();
        }
    }
}
