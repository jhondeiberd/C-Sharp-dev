﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            Window1 transaction = new Window1();

            bool loginOk = true; //GetAccountByNumberPass(123,"abc123");

            if (loginOk)
            {
                transaction.Show();
                this.Close();
            }
            else
            {
                Console.WriteLine("Inexisting account or wrong password");
            }


        }
    }
}
