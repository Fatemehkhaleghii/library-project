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
    public partial class SearchForm : Form
    {
        string filePath = "Books.txt";
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string key = txtSearch.Text.Trim();

            if (!File.Exists(filePath))
            {
                MessageBox.Show("فایل کتاب‌ها وجود ندارد");
                return;
            }

            foreach (string line in File.ReadAllLines(filePath))
            {
                if (line.Contains(key))
                    listBox1.Items.Add(line);
            }
        }
    }
}
    

