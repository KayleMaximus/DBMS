using Group_08_Milk_Tea_App.DAO;
using Group_08_Milk_Tea_App.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_08_Milk_Tea_App.Utility
{
    public partial class Storage : Form
    {
        public Storage()
        {
            InitializeComponent();
        }

        private void Storage_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = ProductDAO.Instance.GetCatagory();
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember= "name";
            dataGridView1.DataSource = ProductDAO.Instance.GetStorage();
            //comboBox1.ValueMember = "id";
            //comboBox1.SelectedItem = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_Name.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            numericUpDown1.Value = (int)dataGridView1.CurrentRow.Cells[1].Value;
            tb_Price.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        //Reset
        private void button1_Click(object sender, EventArgs e)
        {
            tb_Name.Text = "";
            tb_Price.Text = "";
            comboBox1.SelectedItem = null;
            numericUpDown1.Value = 10;
            dataGridView1.DataSource = ProductDAO.Instance.GetStorage();
        }
        //Refresh
        private void button2_Click(object sender, EventArgs e)
        {
            Storage_Load(null, null);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string name = tb_Name.Text;
            int idCate = comboBox1.SelectedIndex + 1;
            //int idCate = (comboBox1.SelectedItem as Product).ID + 1;
            string price = tb_Price.Text;
            int quantity = (int)numericUpDown1.Value;
            try
            {
                if (!ProductDAO.Instance.InsertDish(name, idCate, quantity, price))
                {
                    MessageBox.Show("New dish created!", "Create Dish!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Storage_Load(null, null);
                    button1_Click(null, null);
                    if (updateDish != null)
                        updateDish(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Error while creating new dish!", "Create Dish!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Storage_Load(null, null);
                    button1_Click(null, null);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Create Dish Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string DishName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            try
            {
                if (MessageBox.Show("Are you sure you want to delete " + DishName + " ?", "Delete Dish", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ProductDAO.Instance.DeleteDish(DishName))
                    {
                        MessageBox.Show("Dish delete!", "Delete Dish!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error while deleting dish!", "Delete Dish!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    Storage_Load(null, null);
                    button1_Click(null, null);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Dish!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

             
        }

        private event EventHandler updateDish;
        public event EventHandler UpdateDish
        {
            add { updateDish += value; }
            remove { updateDish -= value; }
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductDAO.Instance.SearchDishByName(txb_Search.Text);
        }

        private void txb_Search_KeyDown(object sender, KeyEventArgs e)
        {
            //chỉ khi nào nhấn Enter mới tìm
            //if (e.KeyCode == Keys.Enter)
            //{
            //    bt_Search_Click(null, null);
            //}
            //nhấn phím là tìm
            bt_Search_Click(null, null);
        }
    }
}
