namespace library_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            if (user=="admin"&& pass =="1234")
            {
                 new MainForm();
                Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");
            }
        }
    }
}
