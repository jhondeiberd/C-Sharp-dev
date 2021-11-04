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
using System.Threading;

namespace View
{
    public partial class CrudContact : Window
    {
        public enum StatusBottons { ADD, EDIT, DELETE, SEARCH, RELOAD, SAVE_NEW, SAVE_CHANGES, SEARCH_NOW };
        public CrudContact()
        {
            InitializeComponent();
        }
        public void TransferDataContact(StatusBottons stBt = StatusBottons.RELOAD)
        {
            bool dataOk = true;
          
            switch (stBt)
            {
                case StatusBottons.ADD:
                    {
                        try
                        {
                            ClearFieldsCrudFromForm();
                            Btn_AddContact_Crud.Content = "Save New";
                            Btn_EditContact_Crud.IsEnabled = false;
                            Btn_DelContact_Crud.IsEnabled = false;
                            Btn_SearchListContact_Crud.IsEnabled = false;
                            TxtBox_IdContact_Crud.IsEnabled = true;
                            TxtBox_NameContact_Crud.IsEnabled = true;
                            TxtBox_AddressContact_Crud.IsEnabled = true;
                            TxtBox_CellPhoneContact_Crud.IsEnabled = true;
                            Lbl_ModeCrudFromForm.Content = "Mode: Adding Contact";

                        }
                        catch (Exception)
                        {
                            dataOk = false;
                        }
                        break;
                    }
                case StatusBottons.EDIT:
                    {
                        try
                        {
                            TxtBox_IdContact_Crud.IsEnabled = false;
                            TxtBox_NameContact_Crud.IsEnabled = true;
                            TxtBox_AddressContact_Crud.IsEnabled = true;
                            TxtBox_CellPhoneContact_Crud.IsEnabled = true;
                            Btn_EditContact_Crud.Content = "Save Changes";
                            Btn_AddContact_Crud.IsEnabled = false;
                            Btn_DelContact_Crud.IsEnabled = false;
                            Btn_SearchListContact_Crud.IsEnabled = false;
                            Lbl_ModeCrudFromForm.Content = "Mode: Editing Contact";
                        }
                        catch (Exception)
                        {
                            dataOk = false;
                        }
                        break;
                    }
                case StatusBottons.DELETE:
                    try
                    {
                        if (Manager.DeleteContactById(int.Parse(TxtBox_IdContact_Crud.Text)))
                        {
                            Lbl_ModeCrudFromForm.Content = "Data Deleted successfully";
                        }
                        else
                        {
                            Lbl_ModeCrudFromForm.Content = "Error Deleted Data";
                        }
                        TransferDataContact();
                        break;
                    }
                    catch (Exception)
                    {
                        dataOk = false;
                    }
                    break;

                case StatusBottons.SEARCH:
                    {
                        try
                        {
                            TxtBox_IdContact_Crud.IsEnabled = true;
                            TxtBox_NameContact_Crud.IsEnabled = false;
                            TxtBox_AddressContact_Crud.IsEnabled = false;
                            TxtBox_CellPhoneContact_Crud.IsEnabled = false;
                            Btn_AddContact_Crud.IsEnabled = false;
                            Btn_DelContact_Crud.IsEnabled = false;
                            Btn_EditContact_Crud.IsEnabled = false;
                            Btn_SearchListContact_Crud.Content = "Search Now";
                            Lbl_ModeCrudFromForm.Content = "Please enter id to search";
                        }
                        catch (Exception)
                        {
                            dataOk = false;
                        }
                        break;
                    }
                case StatusBottons.SEARCH_NOW:
                    {
                        try
                        {
                            if (int.Parse(TxtBox_IdContact_Crud.Text) > 0)
                            {
                               Contact con= Manager.GetContactById(int.Parse(TxtBox_IdContact_Crud.Text));
                               if (con!=null)
                               {
                                    ClearFieldsCrudFromForm(con.Id,con.Name,con.Address,con.CellPhone);
                                    Lbl_ModeCrudFromForm.Content = "Data found";
                                    Btn_AddContact_Crud.IsEnabled = true;
                                    Btn_DelContact_Crud.IsEnabled = true;
                                    Btn_EditContact_Crud.IsEnabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("Data not found, please check id of the contact");
                                }
                            }
                           
                        }
                        catch (Exception)
                        {
                            dataOk = false;
                        }
                        break;
                    }
                case StatusBottons.RELOAD:
                    {
                        try
                        {
                            ClearFieldsCrudFromForm();
                            Btn_AddContact_Crud.IsEnabled = true;
                            Btn_AddContact_Crud.Content = "Add";
                            Btn_EditContact_Crud.IsEnabled = false;
                            Btn_EditContact_Crud.Content = "Edit";
                            Btn_DelContact_Crud.IsEnabled = false;
                            Btn_SearchListContact_Crud.Content = "Search";
                            Btn_SearchListContact_Crud.IsEnabled = true;
                            Lbl_ModeCrudFromForm.Content = "Please Click on any Botton for Select";
                            GetAllContactsForListViewCrudForm();


                        }
                        catch (Exception)
                        {
                            dataOk = false;
                        }
                        break;
                    }
                case StatusBottons.SAVE_NEW:
                    {
                        try
                        {
                            if ((int.Parse(TxtBox_IdContact_Crud.Text) > 0) && (Manager.GetContactById(int.Parse(TxtBox_IdContact_Crud.Text)) == null))
                            {
                                if (Manager.AddContact(GetDataContact()))
                                {
                                    Lbl_ModeCrudFromForm.Content = "Contact added";
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Lbl_ModeCrudFromForm.Content = "Error adding contact";
                                    Thread.Sleep(1000);
                                }
                                TransferDataContact();
                            }
                            else
                            {
                                MessageBox.Show( "Field id can't be duplicated and is mandatory");
                            }
                            

                        }
                        catch (Exception)
                        {
                            dataOk = false;
                        }
                        break;

                    }
                case StatusBottons.SAVE_CHANGES:
                    {
                        try
                        {                         
                            if (Manager.SetContactById(GetDataContact()))
                            {   MessageBox.Show("Data updated successfully"); }
                            else
                            {   MessageBox.Show("Error updating Data"); }
                            TransferDataContact();
                        }
                        catch (Exception)
                        {
                            dataOk = false;
                        }
                        break;

                    }
                default:
                    break;
            }
            if (dataOk)
            {

            }
            else { MessageBox.Show("Error Loading data, check information please for action: " + stBt.ToString()); }
        }
        public void ClearFieldsCrudFromForm(int id = -1, string name = "", string address = "", long cellPhone = -1)
        {

            TxtBox_IdContact_Crud.Text = id== -1 ? "" : id.ToString();
            TxtBox_NameContact_Crud.Text = String.IsNullOrEmpty(name.ToString()) ? "" : name.ToString();
            TxtBox_AddressContact_Crud.Text = String.IsNullOrEmpty(address.ToString()) ? "" : address.ToString();
            TxtBox_CellPhoneContact_Crud.Text = cellPhone == -1 ? "" : cellPhone.ToString();
            TxtBox_IdContact_Crud.IsEnabled = false;
            TxtBox_NameContact_Crud.IsEnabled = false;
            TxtBox_AddressContact_Crud.IsEnabled = false;
            TxtBox_CellPhoneContact_Crud.IsEnabled = false;
        }

        public  Contact GetDataContact()
        {
            Contact contact = new Contact();
            contact.Id = int.Parse(TxtBox_IdContact_Crud.Text); ;
            contact.Name = Convert.ToString(TxtBox_NameContact_Crud.Text);
            contact.Address = Convert.ToString(TxtBox_AddressContact_Crud.Text);
            contact.CellPhone = long.Parse(TxtBox_CellPhoneContact_Crud.Text);
            return contact;
        }
        public Contact AddContactDataStore()
        {
            Contact addCont = new Contact()
            {
                Id = int.Parse(TxtBox_IdContact_Crud.Text),
                Name = Convert.ToString(TxtBox_NameContact_Crud.Text),
                Address = Convert.ToString(TxtBox_AddressContact_Crud.Text),
                CellPhone = long.Parse(TxtBox_CellPhoneContact_Crud.Text)
            };
            return addCont;
        }

        public void ClearFieldsGridContact(Contact contact)
        {
            TxtBox_IdContact_Crud.Text = contact.Id.ToString() == "-1" ? "" : contact.Id.ToString();
            TxtBox_NameContact_Crud.Text =String.IsNullOrEmpty(contact.Name.ToString()) ? "" : contact.Name.ToString();
            TxtBox_AddressContact_Crud.Text = String.IsNullOrEmpty(contact.Address.ToString()) ? "" : contact.Address.ToString();
            TxtBox_CellPhoneContact_Crud.Text = contact.CellPhone.ToString() == "-1" ? "" : contact.CellPhone.ToString();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                TransferDataContact();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_AddContact_Crud_Click(object sender, RoutedEventArgs e)
        {
            if (Btn_AddContact_Crud.Content.ToString() == "Add")
            {
                TransferDataContact(StatusBottons.ADD);
            }
            else if (Btn_AddContact_Crud.Content.ToString() == "Save New")
            {
                TransferDataContact(StatusBottons.SAVE_NEW);
            }

        }

        private void Btn_EditContact_Crud_Click(object sender, RoutedEventArgs e)
        {
            if (Btn_EditContact_Crud.Content.ToString() == "Edit")
            {
                TransferDataContact(StatusBottons.EDIT);

            }
            else if (Btn_EditContact_Crud.Content.ToString() == "Save Changes")
            {
                TransferDataContact(StatusBottons.SAVE_CHANGES);
            }
        }

        private void Btn_DelContact_Crud_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TransferDataContact(StatusBottons.DELETE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_ClearListContact_Crud_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TransferDataContact();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public void GetAllContactsForListViewCrudForm()
        {
            try
            {
                Lw_CrudFromForm.ItemsSource = Manager.GetAllContacts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void Btn_ClearListContact_Crud_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_SearchListContact_Crud_Click(object sender, RoutedEventArgs e)
        {
            if (Btn_SearchListContact_Crud.Content.ToString() == "Search")
            {
                TransferDataContact(StatusBottons.SEARCH);

            }
            else if (Btn_SearchListContact_Crud.Content.ToString() == "Search Now")
            {
                TransferDataContact(StatusBottons.SEARCH_NOW);
            }
        }
    }
}
