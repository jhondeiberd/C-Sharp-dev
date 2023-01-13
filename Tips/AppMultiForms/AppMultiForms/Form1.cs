namespace AppMultiForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Access access = new Access();
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                this.Visible = false;
                access.Message = txtMessageForm.Text;
                access.ShowDialog();
                message.Text = access.Message;
            }
            else
            {
                message.Text = "Invalid username or password";
            }
            this.Visible = true;
        }

        private void message_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}