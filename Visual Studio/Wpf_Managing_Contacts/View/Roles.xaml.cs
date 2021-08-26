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
using System.Windows.Shapes;

namespace View
{
    /// <summary>
    /// Interaction logic for Roles.xaml
    /// </summary>
    public partial class Roles : Window
    {
        bool isEdit = false;
        public Roles()
        {
            InitializeComponent();
        }

        private void Tv_ControlesMenu_Loaded(object sender, RoutedEventArgs e)
        {
            GetControlsMenu();


        }

        public void GetControlsMenu()
        {
            
            Menu me = new Menu();
            TreeViewItem ParentItem = new TreeViewItem();
            ParentItem.Header = "Controls Menu";
            Tv_ControlesMenu.Items.Add(ParentItem);
            for (int i = 0; i < me.Menu_App_Contacts.Items.Count; i++)
            {
                System.Windows.Controls.MenuItem mni =
                    (System.Windows.Controls.MenuItem)me.Menu_App_Contacts.Items[i];
                //string sTagVals = mni.Tag.ToString();
                //TextBlockMenu.Text += mni.ToString() + "\n";
                if (mni.Items.Count == 1)
                {
                    TreeViewItem Child1Item = new TreeViewItem();
                    Child1Item.Header = mni.ToString();
                    ParentItem.Items.Add(Child1Item);
                    CheckBox chb = new CheckBox();
                    chb.Content = "Is Enable";
                    ParentItem.Items.Add(chb);
                }
                else
                {
                    TreeViewItem Child2Item = new TreeViewItem();
                    Child2Item.Header = mni.ToString();
                    ParentItem.Items.Add(Child2Item);


                    /*for (int j = 0; j < mni.Items.Count; j++)
                    { 
                        // Console.WriteLine(mni.Items[j]);
                    }*/
            
                    foreach (var item2 in mni.Items)
                    {
                        TreeViewItem SubChild1Item = new TreeViewItem();
                        CheckBox chr = new CheckBox(); CheckBox chw = new CheckBox();
                        chr.Content = "Is Enable";
                        Child2Item.Items.Add(chr);
                        SubChild1Item.Header = item2.ToString();
                        Child2Item.Items.Add(SubChild1Item);
                       

                    }
                }
            }
        }
        public void FillListRoles()
        {
            GridListRoles.ItemsSource = Manager.GetAllRoles();
            ComBox_ListRoles.Items.Clear();
            foreach (Role item in Manager.GetAllRoles())
            {
                ComBox_ListRoles.Items.Add(item.Name);
            }
        }
        private void GridListRoles_Loaded(object sender, RoutedEventArgs e)
        {
            FillListRoles();
        }
        bool _handle = true;
        private void GridListRoles_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            if (_handle)
            {
                Role ro = e.Row.Item as Role;
                if (ro != null)
                {
                    _handle = false;
                    GridListRoles.CommitEdit();
                    _handle = true;
                    if (e.Row.IsNewItem)
                    {
                        if ((ro.Id > 0) && (Manager.GetRoleById(ro.Id) == null))
                        {
                            bool result = Manager.AddRole(ro);
                            if (result)
                            { MessageBox.Show(ro.Name + " " + " has added sucessfully."); }
                        }
                        else
                        { MessageBox.Show("Field id can't be duplicated and is mandatory"); }
                    }
                    else
                    {
                        bool result = Manager.SetRoleById(ro);
                        if (result)
                        { MessageBox.Show("Role has update sucessfully."); }
                    }
                }
                FillListRoles();
            }
        }

        private void GridListRoles_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {

        }

        private void GridListRoles_PreviewKeyDown(object sender, KeyEventArgs e)
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
                            //MessageBox.Show(contact.Id.ToString());
                            //context.Employees.DeleteOnSubmit(employee);
                        }
                        //context.SubmitChanges();
                        MessageBox.Show("Contacts deleted sucessfully.", "Delete Employee", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    { GridListRoles.ItemsSource = Manager.GetAllRoles(); }
                }
            }
        }
    }
}
