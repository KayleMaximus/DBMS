using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_08_Milk_Tea_App.DTO
{
    public class Bill
    {
        private int iD;
        private DateTime? dateCheckIn;   //?: cho phép null
        private int status;
        private int staffID;

        public Bill( DateTime? datecheckin, int status, int staffID)
        {
            //this.ID = id;
            this.StaffID = staffID;
            this.DateCheckIn = dateCheckIn;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.StaffID = (int)row["staffID"];
            this.DateCheckIn = (DateTime?)dateCheckIn;
            this.Status = (int)row["status"];
        }

        public int ID { get => iD; set => iD = value; }
        public int Status { get => status; set => status = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public int StaffID { get => staffID; set => staffID = value; }
    }
}
