using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_08_Milk_Tea_App.DTO
{
    public class BillInfo
    {
        private int iD;
        private int billID;  
        private int productID;
        private int quantity;

        public BillInfo(int id, int billID, int productId, int quantity)
        {
            this.Id = id;
            this.BillID = billID;
            this.ProductID = productId;
            this.Quantity = quantity;
        }
        public BillInfo(DataRow row )
        {
            this.Id = (int)row["id"];
            this.BillID = (int)row["idBill"];
            this.ProductID = (int)row["idProduct"];
            this.Quantity = (int)row["quantity"];
        }

        public int Id { get => iD; set => iD = value; }
        public int ProductID { get => productID; set => productID = value; }
        public int BillID { get => billID; set => billID = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
