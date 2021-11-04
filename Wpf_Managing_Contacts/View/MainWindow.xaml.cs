using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Model;
using BLL;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Reflection;

namespace View
{
    public partial class MainWindow : Window
    {
        string filePathUser = "../../users.txt";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            View_ListContacts vlc = new View_ListContacts();
            vlc.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {        
            
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            CrudContact crudct = new CrudContact();
            Contact ct = new Contact() { Id = -1, Name="",Address="",CellPhone = -1 };
            crudct.Show();
            crudct.ClearFieldsGridContact(ct);
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            string msgPwd = "Can you start with User: Admin, Password: R1234*   Rol: Root, you have to change the password";
            if (!File.Exists(filePathUser))
            {             
                string str = string.Format("{0},{1},{2},{3}", 1,"Admin","R1234*","Root");
                File.WriteAllText(filePathUser, str);
                Lbl_Remember_Pwd.Content = msgPwd;
            }
            else
            {
                string[] lines = File.ReadAllLines(filePathUser);
                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    if ((data[1]) == "Admin" && (data[2]) == "R1234*")
                        { Lbl_Remember_Pwd.Content = msgPwd;}
                }
            }
        }
              
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User us = new User();
            us = Manager.GetValidateUserForLogin(TxtBox_UserPassword.Text, TxtBox_Password.Password.ToString());
            
            if (us!=null)
            {
                Menu me = new Menu();
                me.TxtBox_NameUserMenu.Text = us.Name;
                me.TxtBox_RoleUserMenu.Text = us.RoleUser;
                me.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Password or user incorrect, please validate data");
            }
        }
    }
}
