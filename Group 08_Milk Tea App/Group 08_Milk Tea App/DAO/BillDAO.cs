using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_08_Milk_Tea_App.DAO
{
    public class BillDAO
    {
        #region Singleton
        private static BillDAO instance;

        public static BillDAO Instance {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return instance;
            }
            private set => instance = value;
        }

        private BillDAO() { }
        #endregion
        //Load toàn bộ Bill chưa tính tiền
        public DataTable GetUncheckBIDinListBill()
        {
            DataTable data = MY_DB.Instance.ExecuteQuery("SELECT * FROM dbo.loadUncheckBill");
            return data;
        }
        //Insert bill mới để order  
        public bool addBill(int account)
        {
            if (MY_DB.Instance.ExecuteNonQuery("EXEC dbo.USP_InsertBill @iDsaccount  ", new object[] { account }) == 1)
            {
                return true;
            }
            return false;
        }
        //Update lại trạng thái thanh toán của bill
        public bool checkOut(int Bid, double totalPrice)
        {
            if((MY_DB.Instance.ExecuteNonQuery("EXEC dbo.USP_UpdateBillStatus @bID , @totalPrice ", new object[] {Bid, totalPrice})) == 1)
            {
                return true;
            }
            return false;
        }
        //Lấy danh sách bill ĐÃ THANH TOÁN theo ngày truyền vào
        public DataTable GetBillListByDate(DateTime orderDate)
        {
            return MY_DB.Instance.ExecuteQuery("SELECT * FROM UF_GetBillByDate ( @Date )", new object[] { orderDate });
        }

        public int sumByDate(DateTime orderDate)
        {

            int total;
            return  total = Int32.Parse(MY_DB.Instance.ExecuteScalar("SELECT dbo.UF_SumByDate ( @Date )", new object[] { orderDate }).ToString()); ;
        }
    }
}
