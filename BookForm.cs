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
    public partial class BookForm : Form
    {
        string filePath = "Books.txt";
        public BookForm()
        {
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string line = txtBookId.Text + "|" + txtBookName.Text + "|" + txtAuthor.Text;

            File.AppendAllText(filePath, line + Environment.NewLine);

            MessageBox.Show("کتاب ذخیره شد");

            txtBookId.Clear();
            txtBookName.Clear();
            txtAuthor.Clear();
        }
    }
}
