using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMultiForms
{
    public partial class Access : Form
    {
        private string message;
        public string Message
        {
            get
            {
                return txtMessageReturn.Text;
            }
            set 
            { 
                message = value; 
                mesAccess.Text = message;
            }
        }
        public Access()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
