using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Group_08_Milk_Tea_App.DAO;
using Group_08_Milk_Tea_App.DTO;

namespace Group_08_Milk_Tea_App
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                //ADMIN 
                if (rbtn_admin.Checked == true)
                {
                    //Get Form Info
                    string username = TextBoxUsername.Text;
                    string password = TextBoxPassword.Text;
                    MY_DB.InstanceGetPermission(username, password);
                    string query = "EXEC dbo.USP_LoginAsManager @userName  , @passWord ";
                    if (AccountDAO.Instance.Login(username, password, query))
                    {
                        //xử lý tác vụ phân quyền giao diện
                        Account account = AccountDAO.Instance.GetAccountManager(username, password);


                        //Giấu Form này đi thay vì Close() để có thể gọi lại
                        this.Hide();

                        //Gọi Form mới
                        frm_home mainForm = new frm_home(account);
                        mainForm.ShowDialog(this);

                        //Khi tắt Form mới sẽ gọi lại form cũ
                        mainForm = null;
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //STAFF
                else if (rbtn_staff.Checked == true)
                {
                    //Get Form Info
                    string query = "EXEC dbo.USP_LoginAsEmployee @userName , @passWord ";
                    string username = TextBoxUsername.Text;
                    string password = TextBoxPassword.Text;
                    MY_DB.InstanceGetPermission(username, password);
                    if (AccountDAO.Instance.Login(username, password, query))
                    {
                        //xử lý tác vụ phân quyền giao diện
                        Account account = AccountDAO.Instance.GetAccountStaff(username, password);
                        //Giấu Form này đi thay vì Close() để có thể gọi lại
                        this.Hide();

                        //Gọi Form mới
                        frm_home mainForm = new frm_home(account);
                        mainForm.ShowDialog(this);

                        //Khi tắt Form mới sẽ gọi lại form cũ
                        mainForm = null;
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }   
                }
                else
                {
                    MessageBox.Show("Please Chose User Type", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }   catch(Exception ex)
           {
                MessageBox.Show("Wrong Password or Username","Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //tắt hoàn toàn chương trình dựa vào event đóng form
        private void frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }


        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(null, null);
            }
        }

    }
}
