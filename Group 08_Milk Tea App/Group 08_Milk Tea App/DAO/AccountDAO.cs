using Group_08_Milk_Tea_App.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_08_Milk_Tea_App.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
            private set { instance = value; } 
        }

        private AccountDAO() { }
        //kiểm tra tài khoản tồn tại dưới database
        public bool Login( string userName, string passWord, string query)
        {
            DataTable table = new DataTable();
            table = MY_DB.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            //lớn hơn 0 thì true
            return table.Rows.Count>0;
        }    
        //lấy tk dựa trên username phục vụ cho phân quyền giao diện
        public Account GetAccountManager(string username, string password) 
        {
            DataTable table = MY_DB.Instance.ExecuteQuery("EXEC dbo.USP_LoginAsManager @userName  , @passWord ", new object[] { username, password });
            DataRow row = table.Rows[0];
            Account loginAccount = new Account(row);
            return loginAccount;
        }
        //lấy tk dựa trên username phục vụ cho phân quyền giao diện
        public Account GetAccountStaff(string username, string password)
        {
            DataTable table = MY_DB.Instance.ExecuteQuery("EXEC dbo.USP_LoginAsEmployee @userName  , @passWord ", new object[] { username, password });
            DataRow row = table.Rows[0];
            Account loginAccount = new Account(row);
            return loginAccount;
        }
        //lấy tất cả role có trong database
        public DataTable GetAllRole()
        {
            DataTable table = MY_DB.Instance.ExecuteQuery("SELECT * FROM dbo.loadAllRole");
            return table;
        }
        //Kiểm tra trùng username
        public bool CheckUserName(string username)
        {
            DataTable table = new DataTable();
            table = MY_DB.Instance.ExecuteQuery("SELECT * FROM UF_CheckUserName ( @userName )", new object[] { username });
            //lớn hơn 0 thì false
            return table.Rows.Count <= 0;
        }
        //Thêm tài khoản đăng nhập vào hệ thống
        public bool InsertAccount(string username, string password, int roleID)
        {
            if (MY_DB.Instance.ExecuteNonQuery("EXEC dbo.USP_AddAccount @userName , @password , @roleID ", new object[] { username , password , roleID }) == 1)
            {
                return true;
            }
            return false;
        }

        //public bool UpdateEmployee(int aid)
        //{
        //    if (MY_DB.Instance.ExecuteNonQuery("EXEC dbo.USP_UpdateStaff @aid ", new object[] { aid }) == 1)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
