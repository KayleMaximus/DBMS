using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_08_Milk_Tea_App
{
    public partial class frm_start : Form
    {
        public frm_start()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm_login = new frm_login();
            frm_login.ShowDialog();
            frm_login = null;
            this.Show();
            
        }


        private void frm_start_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
