

namespace AppDateTime
{
    public partial class FormDateTime : Form
    {
        public FormDateTime()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }
}