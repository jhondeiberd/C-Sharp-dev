using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using BLL;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace View
{
    public partial class View_ListContacts : Window
    {
        bool isEdit = false;

        public View_ListContacts()
        {
            InitializeComponent();
        }


        private void Btn_ReloadListContact_Click(object sender, RoutedEventArgs e)
        {
            GridListContacts.ItemsSource = Manager.GetAllContacts();
        }
        private void GridListContacts_Loaded(object sender, RoutedEventArgs e)
        {
            GridListContacts.ItemsSource = Manager.GetAllContacts();
        }


        private void Lw_ListContacts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ContextMenu ontxt = new ContextMenu();
            MessageBox.Show("Change data");
        }


        private void GridListContacts_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("mouse doble click");
        }

        private void GridListContacts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

       
        bool _handle = true;
        private void GridListContacts_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            if (_handle)
            {
                Contact contact = new Contact();
                Contact cont = e.Row.Item as Contact;     
                if (cont != null)
                {
                    _handle = false;
                    GridListContacts.CommitEdit();
                    _handle = true;
                    if (e.Row.IsNewItem)
                    {
                        if ((cont.Id > 0) && (Manager.GetContactById(cont.Id)==null))
                        {
                            MessageBox.Show("is insert");
                            bool result = Manager.AddContact(cont);
                            if (result)
                                { MessageBox.Show(contact.Name + " " + " has added sucessfully."); }
                        }
                        else
                        { MessageBox.Show("Field id can't be duplicated and is mandatory"); }                 
                    }
                    else
                    {
                        MessageBox.Show("update");
                        bool result = Manager.SetContactById(cont);
                        if (result)
                        { MessageBox.Show(cont.Name + " " + " has update sucessfully."); }
                    }
                }
                GridListContacts.ItemsSource = Manager.GetAllContacts();


            }
        }
        private void GridListContacts_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            
        }

        private void GridListContacts_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            //isEdit = true;
        }

        private void GridListContacts_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete && !isEdit)
            {
                var grid = (DataGrid)sender;
                if (grid.SelectedItems.Count > 0)
                {
                    var result = MessageBox.Show("Are you sure you want to delete this employee?", "Deleting Records", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
                    if (result == MessageBoxResult.Yes)
                    {
                        foreach (var row in grid.SelectedItems)
                        {
                            Contact contact = row as Contact;
                            Manager.DeleteContactById(contact.Id);
                        }
                        MessageBox.Show("Contacts deleted sucessfully.","Delete Employee", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {   GridListContacts.ItemsSource = Manager.GetAllContacts();}
                }
            }
        }
    }
}
