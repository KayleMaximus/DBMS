using Group_08_Milk_Tea_App.DAO;
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
    public partial class CatagoryForm : Form
    {
        public CatagoryForm()
        {
            InitializeComponent();
        }

        private void CatagoryForm_Load(object sender, EventArgs e)
        {
            cbb_SelectCourse.DataSource = ProductDAO.Instance.GetCatagory();
            cbb_SelectCourse.DisplayMember = "name";
            cbb_SelectCourse.ValueMember = "id";
            cbb_SelectCourse.SelectedItem = null;
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txb_Label.Text;
                int id = (int)cbb_SelectCourse.SelectedValue;
                if (ProductDAO.Instance.UpdateCata(name, id))
                {
                    MessageBox.Show("Update Successfully!", "Update Dish", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update Error!", "Update Dish", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Dish", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

            CatagoryForm_Load(null, null);
            txb_Label.Text = "";
        }
    }
}
