using Group_08_Milk_Tea_App.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_08_Milk_Tea_App.DAO
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;

        public static EmployeeDAO Instance 
        {
            get
            {
                if (instance == null)
                    instance = new EmployeeDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private EmployeeDAO() { }

        public Employee GetEmployeeByaID( int aid)
        {
            DataTable table = MY_DB.Instance.ExecuteQuery("SELECT * FROM  dbo.UF_GetStaffByAccountID( @aid )", new object[] { aid });
            Employee employee = new Employee(table.Rows[0]);
            return employee;
        }

        public bool UpdateInfo( int aid, string fname, string lname, string addr, string phone, DateTime bdate, string gender)
        {
            if (MY_DB.Instance.ExecuteNonQuery("dbo.USP_UpdateStaffInfo @aid , @FName , @LName , @addr , @phone , @bdate , @gender ", new object[] { aid, fname,lname,addr,phone,bdate,gender }) == 1)
                return true;
            return false;
        }

    }
}
