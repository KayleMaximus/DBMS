using Group_08_Milk_Tea_App.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_08_Milk_Tea_App.DAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;


        public static int ButtonWidth = 150;
        public static int ButtonHeight = 150;

        public static ProductDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProductDAO();
                return instance;
            }
            private set
            {
                ProductDAO.instance = value;
            }
        }

        private ProductDAO() { }

        //Load Full Menu (tất cả món)
        public List<Product> LoadAllProduct()
        {
            List<Product> productList = new List<Product>();
            
            //Truy vấn lấy 1 bảng full product
            DataTable data = MY_DB.Instance.ExecuteQuery("SELECT * FROM loadMenu");
            
            foreach(DataRow item in data.Rows)
            {
                Product product = new Product(item);
                productList.Add(product);
            }    

            return productList;
        }
        //Tìm kiếm Dish theo tên (cả có dấu lẫu ko dấu)
        public DataTable SearchDishByName(string name)
        {
            DataTable data = MY_DB.Instance.ExecuteQuery("SELECT * FROM dbo.UF_FindDish ( @name )", new object[] { name });
            return data;
        }
        //Load Dish Menu By idCata (món ăn theo danh mục)
        public List<Product> LoadProductByIDcat(int idCat)
        {
            List<Product> productList = new List<Product>();

            //Truy vấn lấy 1 bảng full product
            //DataTable data = MY_DB.Instance.ExecuteQuery("EXEC dbo.USP_GetProduct @iDcat", new object[] { idCat });
            DataTable data = MY_DB.Instance.ExecuteQuery("SELECT * FROM UF_GetProduct ( @iDcat )", new object[] { idCat });

            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                productList.Add(product);
            }

            return productList;
        }
        //Load Catagory (load tất cả danh mục)
        public DataTable GetCatagory()
        {
            DataTable data = MY_DB.Instance.ExecuteQuery("SELECT * FROM dbo.ProductCategory ");
            return data;
        }
        //Load View dish + cata
        public DataTable GetStorage()
        {
            DataTable data = MY_DB.Instance.ExecuteQuery("SELECT * FROM dbo.LoadStorage");
            return data;
        }
        public DataTable GetStorageCata(string nameCata)
        {
            DataTable data = MY_DB.Instance.ExecuteQuery("SELECT * FROM dbo.UF_GetStorageCata ( @nameCata )");
            return data;
        }
        //Thêm món ăn
        public bool InsertDish(string name, int idCATE, int quantity, string price)
        {
            if(MY_DB.Instance.ExecuteNonQuery("EXEC dbo.USP_AddDish @name , @idCata , @quantity , @price " , new object[] {name,idCATE,quantity,price }) == 1)
            {
                return true;
            }
            return false;
        }
        //Xóa món ăn
        public bool DeleteDish(string dishname)
        {
            if((MY_DB.Instance.ExecuteNonQuery("EXEC dbo.USP_DeleteDish  @name  ", new object[] { dishname }) > 0))
            {
                return true;
            }    return false;
        }
        //Cập nhật tên cata
        public bool UpdateCata(string name, int id)
        {
            if(MY_DB.Instance.ExecuteNonQuery("EXEC dbo.USP_UpdateCata  @name , @id ", new object[] {name , id})==1)
            {
                return true;
            }
            return false;
        }

    }

}
