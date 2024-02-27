namespace AppCalculator
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(Number1.Text);
            double b = Convert.ToDouble(Number2.Text);
            double result = 0.0;

            if (Add.Checked == true) { result = a + b; }
            if (Sub.Checked == true) { result = a - b;}
            if (Mult.Checked == true) { result = a * b;}
            if (Div.Checked == true) 
            {
                Divition divition = new Divition();
                try
                {
                    result = divition.SetDivition(a,b);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            Result.Text = result.ToString();
        }

        public class Divition
        {
            public double SetDivition(double divition, double divitor)
            {
                if (divitor == 0)
                {
                    throw new Exception(string.Format("The divition by 0 is not posible"));
                } else
                {
                    return(divition / divitor);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Add_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Sub_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Mult_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}