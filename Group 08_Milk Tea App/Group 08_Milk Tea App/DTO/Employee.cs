using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_08_Milk_Tea_App.DTO
{
    public class Employee
    {
        string firstName;
        string lastName;
        string addr;
        string phone;
        DateTime bDate;
        string gender;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Addr { get => addr; set => addr = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime BDate { get => bDate; set => bDate = value; }
        public string Gender { get => gender; set => gender = value; }


        public Employee(DataRow row)
        {
            this.FirstName = row["FName"].ToString();
            this.LastName = row["LName"].ToString();
            this.Addr = row["Addr"].ToString();
            this.Phone = row["Phone"].ToString();
            this.BDate = (DateTime)row["Birthday"];
            this.Gender = row["Gender"].ToString();
        }
    }
}
