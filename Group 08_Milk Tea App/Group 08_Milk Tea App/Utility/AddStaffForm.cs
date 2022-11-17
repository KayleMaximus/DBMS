using Group_08_Milk_Tea_App.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_08_Milk_Tea_App.Utility
{
    public partial class AddStaffForm : Form
    {
        public AddStaffForm()
        {
            InitializeComponent();
            cbb_Role.DataSource = AccountDAO.Instance.GetAllRole();
            cbb_Role.DisplayMember = "RoleName";
            cbb_Role.ValueMember = "id";
            cbb_Role.SelectedItem = null;
        }
        private bool verif()
        {
            if (txb_UserName.Text.Trim() == "" || txb_PassWord.Text.Trim() == "" || txb_ConfirmPassword.Text.Trim() == "" )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void bt_SignIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())        //kiểm tra form
                {
                    int userID = Convert.ToInt32(cbb_Role.SelectedValue);
                    string username = txb_UserName.Text;
                    string password = txb_PassWord.Text;
                    string ConfirmPass = txb_ConfirmPassword.Text;
                    int roleID = (int)cbb_Role.SelectedValue;
                    if (AccountDAO.Instance.CheckUserName(username))
                    {
                        if (String.Compare(password, ConfirmPass) != 0)
                        {
                            MessageBox.Show("Password Not Match!", "Invalid Password Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (AccountDAO.Instance.InsertAccount(username, password, roleID))
                            {
                                MessageBox.Show("New Employee Added", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Error", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("UserName Existed!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message +" Please Choose Role", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bt_Cancel_SignIn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
