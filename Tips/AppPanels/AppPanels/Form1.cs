using AppCalculator;
using DateTime;

namespace AppPanels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void OpenForms<T>() where T : Form, new()
        {
            Form form = panelForm.Controls.OfType<T>().FirstOrDefault();
            if (form == null)
            {
                form = new T();
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                panelForm.Controls.Add(form);
                panelForm.Tag = form;
                form.Show();
                form.BringToFront();
            }
            else
            {
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                form.Show();
                form.BringToFront();
            }
        }
        
        private void CloseForms<T>() where T: Form, new ()
        {
            Form form = panelForm.Controls.OfType<T>().FirstOrDefault();
            if (form != null)
            {
                form.Close();
            }
        }
        private void Panel_Load(object sender, EventArgs e)
        {

        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            CloseForms<FormCalculator>();
            OpenForms<FormDateTime>();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            CloseForms<FormDateTime>();
            //OpenForms<>(FormCalculator);
        }
    }
}