using Group_08_Milk_Tea_App.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_08_Milk_Tea_App.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance { 
            get
            {
                if (instance == null)
                    instance = new MenuDAO();
                return instance;
            }
            private set => instance = value; 
        }
        private MenuDAO(){}

        public List<Menu> GetListMenuByOrder(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            DataTable data = MY_DB.Instance.ExecuteQuery("SELECT * FROM dbo.UF_GetMenu2( @Bid )", new object[]{id});

            foreach(DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }


    }
}
