using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_08_Milk_Tea_App.DTO
{
    public class Menu
    {
        private string productName;
        private int quantity;
        private int price;
        private int totalPrice;

        public Menu(string productName, int quantity, int price, int totalPrice)
        {
            this.ProductName = productName;
            this.Quantity = quantity;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }


        public Menu(DataRow row)
        {

            this.ProductName = row["name"].ToString();
            this.Quantity = (int)row["quantity"];
            this.Price = (int)row["price"];
            this.TotalPrice = (int)row["totalPrice"];
        }


        public string ProductName { get => productName; set => productName = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
