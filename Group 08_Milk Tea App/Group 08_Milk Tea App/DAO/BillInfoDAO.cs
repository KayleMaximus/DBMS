using Group_08_Milk_Tea_App.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_08_Milk_Tea_App.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance {
            get
            {
                if (instance == null)
                    instance = new BillInfoDAO();
                return instance;
            }
            private set => instance = value; 
        }
        private BillInfoDAO() { }

        //Lấy danh sách product dựa trên Id hóa đơn (datagridview click event)
        public List<BillInfo> GetListBillInfo(int id) 
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            //DataTable data = MY_DB.Instance.ExecuteQuery("EXEC dbo.USP_GetInfoWithBilliD  @Bid", new object[] { id });
            DataTable data = MY_DB.Instance.ExecuteQuery("SELECT* FROM dbo.UF_GetInfoWithBilliD( @Bid )", new object[] { id });
   
            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }    

            return listBillInfo;
        }

        //Tạo bill mới để thêm product (button_+_click event)
        public bool addBillinfo(int bID, int pID, int quantity )
        {
            if (MY_DB.Instance.ExecuteNonQuery("EXEC dbo.USP_InsertBillInfo  @idBill  , @idProduct , @quantity ", new object[] { bID,pID,quantity }) > 0)
            {
                return true; 
            }
            return false;
        }
    }
}
