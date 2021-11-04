using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Model;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace View
{
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            View_ListContacts vlc = new View_ListContacts();
            vlc.Show();
        }
      
        private void Menu_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MeItem_ContactsManageContactsAdd_Click(object sender, RoutedEventArgs e)
        {
            CrudContact cc = new CrudContact();
            cc.Show();
        }

        private void MeItem_ManageRolesUserAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MeItem_List_Paths_Show_Click(object sender, RoutedEventArgs e)
        {
            Txb_ListPathFiles.Text = " ";
            string path1 = "../../Contacts.txt";
            string path2 = "../../paswword.txt";
            Txb_ListPathFiles.Text += " File Contacts in path: " + System.IO.Path.GetFullPath(path1) + "\n";
            Txb_ListPathFiles.Text += " File Contacts in path: " + System.IO.Path.GetFullPath(path2) + "\n";
        }

        private void MeItem_List_Paths_Hide_Click(object sender, RoutedEventArgs e)
        {
            Txb_ListPathFiles.Text = "";
        }

        private void MeItem_ManageRolesUser_Click(object sender, RoutedEventArgs e)
        {
            Roles ro = new Roles();
            ro.Show();
        }

        private void MeItem_ManageUser_Click(object sender, RoutedEventArgs e)
        {
            Users us = new Users();
            us.Show();
        }

        private void MeItem_Contacts_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
