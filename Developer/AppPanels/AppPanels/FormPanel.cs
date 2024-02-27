using AppCalculator;
using AppDateTime;

namespace AppPanels
{
    public partial class FormPanel : Form
    {
        public FormPanel()
        {
            InitializeComponent();
        }
        private void OpenForms<T>() where T : Form, new()
        {
            Form form = ContApplication.Controls.OfType<T>().FirstOrDefault();
            if (form == null)
            {
                form = new T();
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                ContApplication.Controls.Add(form);
                ContApplication.Tag = form;
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
            Form form = ContApplication.Controls.OfType<T>().FirstOrDefault();
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
            OpenForms<FormCalculator>();
        }
    }
}