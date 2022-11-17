using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_08_Milk_Tea_App.DTO
{
    public class Product
    {
        
        public enum IdCatac : int
        {
            coffee = 1,
            traSua = 2,
            tra = 3,
            suaTuoi = 4,
            yogurst = 5,
            machiato = 6,
            topping = 7,
            thucAnNhanh = 8
        }


        private int iD;
        private int iDcat;
        private string name;
        private int quantity;
        private float price;

        public int ID { get => iD; set => iD = value; }
        public int IDcat { get => iDcat; set => iDcat = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float Price { get => price; set => price = value; }

        //Constructor khởi tạo 1 product mới từ input của winform xuống database
        public Product(int ID, int IDcat, string name, int quantity, float price)
        {
            this.ID = ID;
            this.IDcat = IDcat;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

        //Constructor khởi tạo product từ database load lên giao diện winform
        public Product(DataRow row)
        {
            this.iD = (int)row["id"];
            this.name = row["name"].ToString();
            this.IDcat = (int)row["idCategory"];
            this.quantity = (int)row["quantity"];
            this.price = (int)row["price"];
        }

    }
}
