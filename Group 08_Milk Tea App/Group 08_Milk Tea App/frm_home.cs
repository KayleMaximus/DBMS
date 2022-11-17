using Group_08_Milk_Tea_App.DAO;
using Group_08_Milk_Tea_App.DTO;
using Group_08_Milk_Tea_App.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = Group_08_Milk_Tea_App.DTO.Menu;
using System.Globalization;
using System.Threading;

namespace Group_08_Milk_Tea_App
{
    public partial class frm_home : Form
    {
        private Account loginAccount;
        public Account LoginAccount
        {
            get => loginAccount;
            set
            {
                loginAccount = value;
            }
        }
        public frm_home(Account loginAccount)
        {
            InitializeComponent();
            this.LoginAccount = loginAccount;
        }
        #region Methods
        //Load form ( load Menu, Load datagridview hóa đơn đang order)
        private void frm_home_Load(object sender, EventArgs e)
        {
            #region load menu

            List<Product> products = ProductDAO.Instance.LoadAllProduct();

            foreach (Product item in products)
            {
                Button btn = new Button() { Width = ProductDAO.ButtonWidth, Height = ProductDAO.ButtonHeight };
                //btn.Text = item.Name + Environment.NewLine + item.Price;
                btn.BackgroundImage = global::Group_08_Milk_Tea_App.Properties.Resources.cà_phê_đen;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Click += Btn_Click;
                btn.Tag = item;             //gán đối tượng vào thẻ tag để truy xuất thông tin bên Event Btn_Click
                Label label = new Label();
                label.Text = item.Name + Environment.NewLine + item.Price;
                btn.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(btn); 
            }

            #endregion

            #region load hóa đơn
            dataGridBill.DataSource = BillDAO.Instance.GetUncheckBIDinListBill();
            #endregion

            #region try catch phòng khi load menu nhưng chưa có bill
            try
            { 
                dataGridBill_CellContentClick(null, null);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Welcome to Blue House!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            numericUpDown1.Value = 1;
            #endregion

            //truyền tk đăng nhập qua form home
            lb_welcome.Text = "Welcome:  " + loginAccount.UserName;
        }
        //thêm vào order
        void addIntoBillinfo(int bID, int pID, int quantity )
        {
            //lấy thông tin: id món ăn, id bill và số lượng order để thêm vào hóa đơn
            if(BillInfoDAO.Instance.addBillinfo(bID,pID, quantity))
            {
                MessageBox.Show("Order create successfully", "Create Order", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridBill_CellContentClick(null, null);
                numericUpDown1.Value = 1;
            }
            else
            {
                MessageBox.Show("Can't not Order", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
                

        }
        //click vào hình ảnh để truy xuất thông tin tạo order
        private void Btn_Click(object sender, EventArgs e)
        {
            //try catch để phòng khi thêm món ăn nhưng chưa tạo bill
            try
            {
                int quantity =(int)numericUpDown1.Value;
                int billInfoID = (int)dataGridBill.CurrentRow.Cells[0].Value;
                int pID = ((sender as Button).Tag as Product).ID;        //truy xuất ProductID từ sencder button tag trong đối tượng Product
                addIntoBillinfo(billInfoID, pID, quantity);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please create bill before add product! " + ex.Message, "Add Product Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Events
        //nút thêm bill
        private void btn_addBill_Click(object sender, EventArgs e)
        {
            //bên sql đã xử lý chuyển account id sang staff id
            int staffid = LoginAccount.Id;
            if (BillDAO.Instance.addBill(staffid))
            {
                MessageBox.Show("Bill create successfully", "Create Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridBill.DataSource = BillDAO.Instance.GetUncheckBIDinListBill();

            }
            else
            {
                MessageBox.Show("Can't not Create New Bill", "Create Bill Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //click vào datagridview để coi thông tin bill chưa thanh toán
        private void dataGridBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            listView1.Items.Clear();    //xóa listview mỗi lần load 1 bill khác
            int billInfoID = (int)dataGridBill.CurrentRow.Cells[0].Value;   //lấy ID bill để load lên listvew từ datagridview
            List<Menu> listMenuinfo = MenuDAO.Instance.GetListMenuByOrder(billInfoID);  //tạo 1 danh sách các món đã order từ BillID
            double totalPrice = 0;
            foreach (Menu item in listMenuinfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.ProductName.ToString());
                lsvItem.SubItems.Add(item.Quantity.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                listView1.Items.Add(lsvItem);

                totalPrice += item.TotalPrice;
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txb_totalPrice.Text = totalPrice.ToString("c", culture);
            //Thread.CurrentThread.CurrentCulture = culture;      //chỉ thay đổi culture cho app này chứ KHÔNG CHO CẢ PC
        }
        //nút pay
        private void Pay_Click(object sender, EventArgs e)
        {
            try //phòng khi nhấn pay khi chưa có hóa đơn từ datagrid view => throw exception
            {
                int billID = (int)dataGridBill.CurrentRow.Cells[0].Value;   //billID
                //int totalPrice = Convert.ToInt32(txb_totalPrice.Text.Split(',')[0]);
                double totalPrice = Convert.ToDouble(txb_totalPrice.Text.Split(',')[0]);
                int realTotalPrice = (int)(totalPrice) * 1000;
                if (MessageBox.Show("You are checking out for bill " + billID + "! + totalPrice = " + realTotalPrice, "Check Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (!BillDAO.Instance.checkOut(billID, realTotalPrice))
                        {
                            MessageBox.Show("Cannot check out since no product was purchased!", "Check Out Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Check out successfully!", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception EX)
                    {
                        MessageBox.Show(EX.Message, "Check Out Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }




                    #region load lại sau khi check out
                    dataGridBill.DataSource = BillDAO.Instance.GetUncheckBIDinListBill();
                    dataGridBill_CellContentClick(null, null);
                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Bill To Pay!", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        #region strip Menu
        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Storage storage = new Storage();
            storage.UpdateDish += Storage_UpdateDish;
            storage.Show();
        }

        private void Storage_UpdateDish(object sender, EventArgs e)
        {
            dataGridBill_CellContentClick(null, null);
        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateInfoForm uif = new updateInfoForm(loginAccount);
            uif.Show();
        }
        private void fRESHMILKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Product> products = ProductDAO.Instance.LoadProductByIDcat((int)Product.IdCatac.yogurst);

            foreach (Product item in products)
            {
                Button btn = new Button() { Width = ProductDAO.ButtonWidth, Height = ProductDAO.ButtonHeight };
                //btn.Text = item.Name + Environment.NewLine + item.Price;
                btn.BackgroundImage = global::Group_08_Milk_Tea_App.Properties.Resources.yogurt_việt_quốc;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Click += Btn_Click;
                btn.Tag = item;             //gán đối tượng vào thẻ tag để truy xuất thông tin bên Event Btn_Click
                Label label = new Label();
                label.Text = item.Name + Environment.NewLine + item.Price;
                btn.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        private void mACHIATOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Product> products = ProductDAO.Instance.LoadProductByIDcat((int)Product.IdCatac.machiato);

            foreach (Product item in products)
            {
                Button btn = new Button() { Width = ProductDAO.ButtonWidth, Height = ProductDAO.ButtonHeight };
                //btn.Text = item.Name + Environment.NewLine + item.Price;
                btn.BackgroundImage = global::Group_08_Milk_Tea_App.Properties.Resources.Caramel_Macchiato_Recipe_sq_1;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Click += Btn_Click;
                btn.Tag = item;             //gán đối tượng vào thẻ tag để truy xuất thông tin bên Event Btn_Click
                Label label = new Label();
                label.Text = item.Name + Environment.NewLine + item.Price;
                btn.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        private void lEMONTEAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Product> products = ProductDAO.Instance.LoadProductByIDcat((int)Product.IdCatac.tra);

            foreach (Product item in products)
            {
                Button btn = new Button() { Width = ProductDAO.ButtonWidth, Height = ProductDAO.ButtonHeight };
                //btn.Text = item.Name + Environment.NewLine + item.Price;
                btn.BackgroundImage = global::Group_08_Milk_Tea_App.Properties.Resources.lục_trà;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Click += Btn_Click;
                btn.Tag = item;             //gán đối tượng vào thẻ tag để truy xuất thông tin bên Event Btn_Click
                Label label = new Label();
                label.Text = item.Name + Environment.NewLine + item.Price;
                btn.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        private void fASTFOODToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Product> products = ProductDAO.Instance.LoadProductByIDcat((int)Product.IdCatac.thucAnNhanh);

            foreach (Product item in products)
            {
                Button btn = new Button() { Width = ProductDAO.ButtonWidth, Height = ProductDAO.ButtonHeight };
                //btn.Text = item.Name + Environment.NewLine + item.Price;
                btn.BackgroundImage = global::Group_08_Milk_Tea_App.Properties.Resources.FastFood;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Click += Btn_Click;
                btn.Tag = item;             //gán đối tượng vào thẻ tag để truy xuất thông tin bên Event Btn_Click
                Label label = new Label();
                label.Text = item.Name + Environment.NewLine + item.Price;
                btn.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStaffForm asf = new AddStaffForm();
            asf.Show();
        }
        private void mILKTEAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Product> products = ProductDAO.Instance.LoadProductByIDcat((int)Product.IdCatac.traSua);

            foreach (Product item in products)
            {
                Button btn = new Button() { Width = ProductDAO.ButtonWidth, Height = ProductDAO.ButtonHeight };
                //btn.Text = item.Name + Environment.NewLine + item.Price;
                btn.BackgroundImage = global::Group_08_Milk_Tea_App.Properties.Resources.trà_sữa_socola;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Click += Btn_Click;
                btn.Tag = item;             //gán đối tượng vào thẻ tag để truy xuất thông tin bên Event Btn_Click
                Label label = new Label();
                label.Text = item.Name + Environment.NewLine + item.Price;
                btn.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statisticsFom sttF = new statisticsFom();
            sttF.Show();
        }
        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Product> products = ProductDAO.Instance.LoadProductByIDcat((int)Product.IdCatac.coffee);

            foreach (Product item in products)
            {
                Button btn = new Button() { Width = ProductDAO.ButtonWidth, Height = ProductDAO.ButtonHeight };
                //btn.Text = item.Name + Environment.NewLine + item.Price;
                btn.BackgroundImage = global::Group_08_Milk_Tea_App.Properties.Resources.cà_phê_đen;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Click += Btn_Click;
                btn.Tag = item;             //gán đối tượng vào thẻ tag để truy xuất thông tin bên Event Btn_Click
                Label label = new Label();
                label.Text = item.Name + Environment.NewLine + item.Price;
                btn.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Product> products = ProductDAO.Instance.LoadProductByIDcat((int)Product.IdCatac.suaTuoi);

            foreach (Product item in products)
            {
                Button btn = new Button() { Width = ProductDAO.ButtonWidth, Height = ProductDAO.ButtonHeight };
                //btn.Text = item.Name + Environment.NewLine + item.Price;
                btn.BackgroundImage = global::Group_08_Milk_Tea_App.Properties.Resources.sữa_tươi_trân_châu_khoai_môn;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Click += Btn_Click;
                btn.Tag = item;             //gán đối tượng vào thẻ tag để truy xuất thông tin bên Event Btn_Click
                Label label = new Label();
                label.Text = item.Name + Environment.NewLine + item.Price;
                btn.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Product> products = ProductDAO.Instance.LoadProductByIDcat((int)Product.IdCatac.topping);

            foreach (Product item in products)
            {
                Button btn = new Button() { Width = ProductDAO.ButtonWidth, Height = ProductDAO.ButtonHeight };
                //btn.Text = item.Name + Environment.NewLine + item.Price;
                btn.BackgroundImage = global::Group_08_Milk_Tea_App.Properties.Resources.topping;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Click += Btn_Click;
                btn.Tag = item;             //gán đối tượng vào thẻ tag để truy xuất thông tin bên Event Btn_Click
                Label label = new Label();
                label.Text = item.Name + Environment.NewLine + item.Price;
                btn.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(btn);
            }


        }

        private void catagoryManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatagoryForm CTF = new CatagoryForm();
            CTF.Show();
        }
        #endregion

        #endregion


    }
}
