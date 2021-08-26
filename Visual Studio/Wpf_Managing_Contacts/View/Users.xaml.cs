using System;
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
using System.Windows.Shapes;
using Model;
using BLL;
using System.Threading;

namespace View
{
    public partial class Users : Window
    {
        public enum StatusBottons { ADD, EDIT, DELETE, SEARCH, RELOAD, SAVE_NEW, SAVE_CHANGES, SEARCH_NOW };
        public Users()
        {
            InitializeComponent();
        }
        public void TransferDataUser(StatusBottons stBt = StatusBottons.RELOAD)
        {
            bool dataOk = true;

            switch (stBt)
            {
                case StatusBottons.ADD:
                    {
                        try
                        {
                            ClearFieldsUserForm();
                            btnUserAdd.Content = "Save New";
                            BtnUserEdit.IsEnabled = false;
                            BtnUserDelete.IsEnabled = false;
                            BtnUserSearch.IsEnabled = false;
                            txtUserId.IsEnabled = true;
                            txtUserName.IsEnabled = true;
                            txtUserPassword.IsEnabled = true;
                            txtUserRole.IsEnabled = true;
                            Lbl_UserModeForm.Content = "Mode: Adding user";

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
                            txtUserId.IsEnabled = false;
                            txtUserName.IsEnabled = true;
                            txtUserPassword.IsEnabled = true;
                            txtUserRole.IsEnabled = true;
                            BtnUserEdit.Content = "Save Changes";
                            btnUserAdd.IsEnabled = false;
                            BtnUserDelete.IsEnabled = false;
                            BtnUserSearch.IsEnabled = false;
                            Lbl_UserModeForm.Content = "Mode: Editing user";
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
                        if (Manager.DeleteUserById(int.Parse(txtUserId.Text)))
                        {
                            Lbl_UserModeForm.Content = "Data Deleted successfully";
                        }
                        else
                        {
                            Lbl_UserModeForm.Content = "Error Deleted Data";
                        }
                        TransferDataUser();
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
                            txtUserId.IsEnabled = true;
                            txtUserName.IsEnabled = false;
                            txtUserPassword.IsEnabled = false;
                            txtUserRole.IsEnabled = false;
                            btnUserAdd.IsEnabled = false;
                            BtnUserEdit.IsEnabled = false;
                            BtnUserDelete.IsEnabled = false;
                            BtnUserSearch.Content = "Search Now";
                            Lbl_UserModeForm.Content = "Please enter id to search";
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
                            ClearFieldsUserForm();
                            btnUserAdd.IsEnabled = true;
                            btnUserAdd.Content = "Add";
                            BtnUserEdit.IsEnabled = false;
                            BtnUserEdit.Content = "Edit";
                            BtnUserDelete.IsEnabled = false;
                            BtnUserSearch.Content = "Search";
                            BtnUserSearch.IsEnabled = true;
                            Lbl_UserModeForm.Content = "Please Click on any Botton for Select";
                            GetAllUserForListView();


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
                            if ((int.Parse(txtUserId.Text) > 0) && (Manager.GetUserById(int.Parse(txtUserId.Text)) == null))
                            {
                                if (Manager.AddUser(GetDataUser()))
                                {
                                    Lbl_UserModeForm.Content = "User added";
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Lbl_UserModeForm.Content = "Error adding user";
                                    Thread.Sleep(1000);
                                }
                                TransferDataUser();
                            }
                            else
                            {
                                MessageBox.Show("Field id can't be duplicated and is mandatory");
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
                            if (Manager.SetUserById(GetDataUser()))
                            { MessageBox.Show("Data updated successfully"); }
                            else
                            { MessageBox.Show("Error updating Data"); }
                            TransferDataUser();
                        }
                        catch (Exception)
                        {
                            dataOk = false;
                        }
                        break;

                    }

                default:
                    break;

                case StatusBottons.SEARCH_NOW:
                    {
                        try
                        {
                            if (int.Parse(txtUserId.Text) > 0)
                            {
                                User us = Manager.GetUserById(int.Parse(txtUserId.Text));
                                if (us != null)
                                {
                                    ClearFieldsUserForm(us.Id, us.Name, us.Password, us.RoleUser);
                                    Lbl_UserModeForm.Content = "Data found";
                                    btnUserAdd.IsEnabled = true;
                                    BtnUserDelete.IsEnabled = true;
                                    BtnUserEdit.IsEnabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("Data not found, please check id of the user");
                                }
                            }

                        }
                        catch (Exception)
                        {
                            dataOk = false;
                        }
                        break;
                    }
            }

            if (dataOk)
            {

            }
            else { MessageBox.Show("Error Loading data, check information please for action: " + stBt.ToString()); }
        }
        public void ClearFieldsUserForm(int id = -1, string name = "", string password = "", string roleUser = "")
        {
            txtUserId.Text = id == -1 ? "" : id.ToString();
            txtUserName.Text = String.IsNullOrEmpty(name.ToString()) ? "" : name.ToString();
            txtUserPassword.Password = String.IsNullOrEmpty(password.ToString()) ? "" : password.ToString();
            txtUserRole.Text = String.IsNullOrEmpty(roleUser.ToString()) ? "" : roleUser.ToString();
            txtUserId.IsEnabled = false;
            txtUserName.IsEnabled = false;
            txtUserPassword.IsEnabled = false;
            txtUserRole.IsEnabled = false;
        }

        private void BtnUserAdd_Click(object sender, RoutedEventArgs e)
        {
            if (btnUserAdd.Content.ToString() == "Add")
            {
                TransferDataUser(StatusBottons.ADD);
            }
            else if (btnUserAdd.Content.ToString() == "Save New")
            {
                TransferDataUser(StatusBottons.SAVE_NEW);
            }

        }

        private void BtnUserEdit_Click(object sender, RoutedEventArgs e)
        {
            if (BtnUserEdit.Content.ToString() == "Edit")
            {
                TransferDataUser(StatusBottons.EDIT);

            }
            else if (BtnUserEdit.Content.ToString() == "Save Changes")
            {
                TransferDataUser(StatusBottons.SAVE_CHANGES);
            }
        }

        private void BtnUserDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TransferDataUser(StatusBottons.DELETE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnUserSearch_Click(object sender, RoutedEventArgs e)
        {
            if (BtnUserSearch.Content.ToString() == "Search")
            {
                TransferDataUser(StatusBottons.SEARCH);

            }
            else if (BtnUserSearch.Content.ToString() == "Search Now")
            {
                TransferDataUser(StatusBottons.SEARCH_NOW);
            }
        }
        public User GetDataUser()
        {
            User user = new User();
            user.Id = int.Parse(txtUserId.Text);
            user.Name = Convert.ToString(txtUserName.Text);
            user.Password = Convert.ToString(txtUserPassword.Password);
            user.RoleUser = Convert.ToString(txtUserRole.Text);
            return user;
        }
        public User AddUserDataStore()
        {
            User addUser = new User()
            {
                Id = int.Parse(txtUserId.Text),
                Name = Convert.ToString(txtUserName.Text),
                Password = Convert.ToString(txtUserPassword.Password),
                RoleUser = Convert.ToString(txtUserRole.Text)
            };
            return addUser;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (Role item in Manager.GetAllRoles())
                {
                    txtUserRole.Items.Add(item.Name);
                }
                TransferDataUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void GetAllUserForListView()
        {
            try
            {
                lwViewUser.ItemsSource = Manager.GetAllUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

    }
}
