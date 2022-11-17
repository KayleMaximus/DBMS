using Group_08_Milk_Tea_App.DAO;
using Group_08_Milk_Tea_App.DTO;
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
    public partial class updateInfoForm : Form
    {

        private Account loginAccount;

        public Account LoginAccount
        {
            get => loginAccount;
            set
            {
                loginAccount = value;
            }
        }

        Employee employee;

        public updateInfoForm(Account loginAccount)
        {
            InitializeComponent();
            this.LoginAccount = loginAccount;
            employee = EmployeeDAO.Instance.GetEmployeeByaID(loginAccount.Id);
        }

        private void updateInfoForm_Load(object sender, EventArgs e)
        {
            
            txb_Addr.Text = employee.Addr;
            txb_Fname.Text = employee.FirstName;
            txb_Lname.Text = employee.LastName;
            txb_Phone.Text = employee.Phone;
            dateTimePicker1.Value = employee.BDate;
            rdb_Male.Checked = true;
            if(employee.Gender == "nữ")
            {
                rbt_Female.Checked = true;
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int aid = loginAccount.Id;
            string fname = txb_Fname.Text;
            string lname = txb_Lname.Text;
            string addr = txb_Addr.Text;
            string phone = txb_Phone.Text;
            DateTime bdate = dateTimePicker1.Value;
            string gender = "nam";
            if (rbt_Female.Checked)
            {
                gender = "nữ";
            }
            if (EmployeeDAO.Instance.UpdateInfo(aid,fname,lname,addr,phone,bdate,gender))
            {
                MessageBox.Show("Update successfully!", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Update Error!", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
