using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Group_08_Milk_Tea_App
{
    public class MY_DB
    {
        private static MY_DB instance; //biến cho cấu trúc singleton => tạo 1 lần dùng xuyên suốt chương trình
        private static MY_DB instanceforpermission;
        private static string username;
        private static string password;

        public static MY_DB InstanceGetPermission (string username,string password)
        {
                if (instanceforpermission == null)
                instanceforpermission = new MY_DB(username,password);

          
            return instance;
        }

        public static MY_DB Instance
        {
            get
            {
                if (instance == null)
                    instance = new MY_DB();
                return MY_DB.instance;
            }
            private set { MY_DB.instance = value; }  //chỉ cho phép nội bộ class này thay đổi => bảo mật cao
        }

        private MY_DB(string username, string password){

            MY_DB.username = username;
            MY_DB.password = password;
        }

        private MY_DB() { }

        //private string connectionStr = (@"Data Source=DESKTOP-P4QH0C8\KAYLE;Initial Catalog=MilkTeaShop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;User ID="  ";password=" );

        private string connectionStr = ("Password=" + MY_DB.password + "; Persist Security Info=True;User ID=" + MY_DB.username + @";Initial Catalog=MilkTeaShop;Data Source=DESKTOP-P4QH0C8\KAYLE");
        //Data Provider
        //object[] parameter = null có 2 mục đích
        //-cho phép truyền 1 mảng n para
        //-có thể có para hoặc ko (null)

        //Execute Querry: trả về 1 bảng data dựa trên query
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                
                //thuật toán xử lý mảng object để lấy n parameter
                //lưu ý: thuật toán này chỉ đúng khi các para độc lập ko bị dính ký tự khác (, "")
                if(parameter != null)
                {
                    string[] Listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in Listpara)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }    
                    }    
                }    

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
            }    
            return table;
        }
        //Excecute Non-Querry: trả về kết quả thao tác INSERT UPDATE DELETE (số dòng thành công)
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                //thuật toán xử lý mảng object để lấy n parameter
                //lưu ý: thuật toán này chỉ đúng khi các para độc lập ko bị dính ký tự khác (, "")
                if (parameter != null)
                {
                    string[] Listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in Listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }
        //Excecute Scarla: trả về cột đầu tiên của số dòng truy vấn (phù hợp với đếm số lượng => count * )
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                //thuật toán xử lý mảng object để lấy n parameter
                //lưu ý: thuật toán này chỉ đúng khi các para độc lập ko bị dính ký tự khác (, "")
                if (parameter != null)
                {
                    string[] Listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in Listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }
            return data;
        }

        


    }
}
