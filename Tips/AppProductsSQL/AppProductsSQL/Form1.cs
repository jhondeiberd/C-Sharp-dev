using System;
using System.Linq;

namespace AppProductsSQL
{
    public partial class Form1 : Form
    {
        private ConectionProductsDataContext conection = new ConectionProductsDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            viewProducts.DataSource = conection.ReadProducts_Test;
        }
    }
}