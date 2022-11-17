using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_08_Milk_Tea_App.DTO
{
    public class Account
    {
        private int id;
        private string userName;
        private string password;
        private int roleID;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int RoleID { get => roleID; set => roleID = value; }
        public int Id { get => id; set => id = value; }

        //tạo account để check / insert / update chỉ khởi tạo trên from xuống sẽ được databsae tự động cấp id
        // =>> ko cần id
        public Account(string userName, int roleID, string password = null)
        {
            this.UserName = userName;
            this.Password = password;
            this.RoleID = roleID;
        }

        //lấy account dưới database lên nên cần lấy thêm id (tự động tạo)
        public Account (DataRow row)
        {
            this.Id = (int)row["id"];
            this.UserName = row["Username"].ToString();
            this.Password = row["Password"].ToString();
            this.RoleID = (int)row["RoleID"];
        }
    }
}
