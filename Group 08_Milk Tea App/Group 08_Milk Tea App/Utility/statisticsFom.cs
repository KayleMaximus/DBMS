using Group_08_Milk_Tea_App.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_08_Milk_Tea_App.Utility
{
    public partial class statisticsFom : Form
    {
        public statisticsFom()
        {
            InitializeComponent();
            //Load đầu tháng
            DateTime today = DateTime.Now;
            dateTimePicker1.Value = new DateTime(today.Year, today.Month, 1);

            //Load cuối tháng
            //dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(1).AddDays(-1);

            LoadListBillByDate(dateTimePicker1.Value);
        }

        public void LoadListBillByDate(DateTime day)
        {
            dataGridView1.DataSource = BillDAO.Instance.GetBillListByDate(day);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try //phòng trường hợp ngày truyền vào ko có bill => null
            {
                LoadListBillByDate(dateTimePicker1.Value);
                CultureInfo culture = new CultureInfo("vi-VN");
                txb_Total.Text = BillDAO.Instance.sumByDate(dateTimePicker1.Value.Date).ToString("c", culture);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
