
namespace Group_08_Milk_Tea_App
{
    partial class frm_home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pl_home = new System.Windows.Forms.Panel();
            this.lb_welcome = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Pay = new System.Windows.Forms.Button();
            this.txb_totalPrice = new System.Windows.Forms.TextBox();
            this.dataGridBill = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_addBill = new System.Windows.Forms.Button();
            this.ms_home = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activiyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catagoryManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mILKTEAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lEMONTEAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.fRESHMILKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mACHIATOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.fASTFOODToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pl_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBill)).BeginInit();
            this.ms_home.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_home
            // 
            this.pl_home.BackgroundImage = global::Group_08_Milk_Tea_App.Properties.Resources.BLUEHOME_PNG;
            this.pl_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl_home.Controls.Add(this.lb_welcome);
            this.pl_home.Controls.Add(this.numericUpDown1);
            this.pl_home.Controls.Add(this.Pay);
            this.pl_home.Controls.Add(this.txb_totalPrice);
            this.pl_home.Controls.Add(this.dataGridBill);
            this.pl_home.Controls.Add(this.listView1);
            this.pl_home.Controls.Add(this.flowLayoutPanel1);
            this.pl_home.Controls.Add(this.btn_addBill);
            this.pl_home.Controls.Add(this.ms_home);
            this.pl_home.Location = new System.Drawing.Point(12, 0);
            this.pl_home.Name = "pl_home";
            this.pl_home.Size = new System.Drawing.Size(1520, 784);
            this.pl_home.TabIndex = 0;
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_welcome.ForeColor = System.Drawing.Color.Blue;
            this.lb_welcome.Location = new System.Drawing.Point(22, 93);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(149, 32);
            this.lb_welcome.TabIndex = 9;
            this.lb_welcome.Text = "Welcome:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(960, 226);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(129, 22);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Pay
            // 
            this.Pay.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay.Location = new System.Drawing.Point(1261, 617);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(136, 56);
            this.Pay.TabIndex = 7;
            this.Pay.Text = "PAY";
            this.Pay.UseVisualStyleBackColor = true;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // txb_totalPrice
            // 
            this.txb_totalPrice.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_totalPrice.ForeColor = System.Drawing.Color.Red;
            this.txb_totalPrice.Location = new System.Drawing.Point(1132, 636);
            this.txb_totalPrice.Name = "txb_totalPrice";
            this.txb_totalPrice.ReadOnly = true;
            this.txb_totalPrice.Size = new System.Drawing.Size(123, 28);
            this.txb_totalPrice.TabIndex = 6;
            this.txb_totalPrice.Text = "0";
            this.txb_totalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataGridBill
            // 
            this.dataGridBill.AllowUserToAddRows = false;
            this.dataGridBill.AllowUserToDeleteRows = false;
            this.dataGridBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBill.Location = new System.Drawing.Point(1095, 168);
            this.dataGridBill.Name = "dataGridBill";
            this.dataGridBill.ReadOnly = true;
            this.dataGridBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridBill.RowTemplate.Height = 24;
            this.dataGridBill.Size = new System.Drawing.Size(302, 81);
            this.dataGridBill.TabIndex = 5;
            this.dataGridBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBill_CellContentClick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(960, 254);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(437, 356);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sản Phẩm";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 80;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 170);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(921, 517);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btn_addBill
            // 
            this.btn_addBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addBill.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addBill.Image = global::Group_08_Milk_Tea_App.Properties.Resources.blue1;
            this.btn_addBill.Location = new System.Drawing.Point(960, 168);
            this.btn_addBill.Name = "btn_addBill";
            this.btn_addBill.Size = new System.Drawing.Size(129, 44);
            this.btn_addBill.TabIndex = 1;
            this.btn_addBill.Text = "+";
            this.btn_addBill.UseVisualStyleBackColor = true;
            this.btn_addBill.Click += new System.EventHandler(this.btn_addBill_Click);
            // 
            // ms_home
            // 
            this.ms_home.BackgroundImage = global::Group_08_Milk_Tea_App.Properties.Resources.blue1;
            this.ms_home.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ms_home.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_home.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ms_home.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.mILKTEAToolStripMenuItem,
            this.lEMONTEAToolStripMenuItem,
            this.toolStripMenuItem3,
            this.fRESHMILKToolStripMenuItem,
            this.mACHIATOToolStripMenuItem,
            this.toolStripMenuItem4,
            this.fASTFOODToolStripMenuItem});
            this.ms_home.Location = new System.Drawing.Point(0, 690);
            this.ms_home.Name = "ms_home";
            this.ms_home.Padding = new System.Windows.Forms.Padding(65, 30, 0, 30);
            this.ms_home.Size = new System.Drawing.Size(1520, 94);
            this.ms_home.TabIndex = 2;
            this.ms_home.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGOUTToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.activiyToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(45, 34);
            this.toolStripMenuItem1.Text = "...";
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.lOGOUTToolStripMenuItem.Text = "Log out";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // activiyToolStripMenuItem
            // 
            this.activiyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStaffToolStripMenuItem,
            this.updateInfoToolStripMenuItem,
            this.manageStaffToolStripMenuItem});
            this.activiyToolStripMenuItem.Name = "activiyToolStripMenuItem";
            this.activiyToolStripMenuItem.ShowShortcutKeys = false;
            this.activiyToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.activiyToolStripMenuItem.Text = "Activity";
            // 
            // addStaffToolStripMenuItem
            // 
            this.addStaffToolStripMenuItem.Name = "addStaffToolStripMenuItem";
            this.addStaffToolStripMenuItem.Size = new System.Drawing.Size(318, 34);
            this.addStaffToolStripMenuItem.Text = "Add Employee";
            this.addStaffToolStripMenuItem.Click += new System.EventHandler(this.addStaffToolStripMenuItem_Click);
            // 
            // updateInfoToolStripMenuItem
            // 
            this.updateInfoToolStripMenuItem.Name = "updateInfoToolStripMenuItem";
            this.updateInfoToolStripMenuItem.Size = new System.Drawing.Size(318, 34);
            this.updateInfoToolStripMenuItem.Text = "Update Personal Info";
            this.updateInfoToolStripMenuItem.Click += new System.EventHandler(this.updateInfoToolStripMenuItem_Click);
            // 
            // manageStaffToolStripMenuItem
            // 
            this.manageStaffToolStripMenuItem.Name = "manageStaffToolStripMenuItem";
            this.manageStaffToolStripMenuItem.Size = new System.Drawing.Size(318, 34);
            this.manageStaffToolStripMenuItem.Text = "Manage Staff";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productManagementToolStripMenuItem,
            this.catagoryManagementToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // productManagementToolStripMenuItem
            // 
            this.productManagementToolStripMenuItem.Name = "productManagementToolStripMenuItem";
            this.productManagementToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.productManagementToolStripMenuItem.Text = "Product Management";
            this.productManagementToolStripMenuItem.Click += new System.EventHandler(this.productManagementToolStripMenuItem_Click);
            // 
            // catagoryManagementToolStripMenuItem
            // 
            this.catagoryManagementToolStripMenuItem.Name = "catagoryManagementToolStripMenuItem";
            this.catagoryManagementToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.catagoryManagementToolStripMenuItem.Text = "Catagory Management";
            this.catagoryManagementToolStripMenuItem.Click += new System.EventHandler(this.catagoryManagementToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(124, 34);
            this.toolStripMenuItem2.Text = "01 COFFE";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // mILKTEAToolStripMenuItem
            // 
            this.mILKTEAToolStripMenuItem.Name = "mILKTEAToolStripMenuItem";
            this.mILKTEAToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.mILKTEAToolStripMenuItem.Text = "02 MILK TEA";
            this.mILKTEAToolStripMenuItem.Click += new System.EventHandler(this.mILKTEAToolStripMenuItem_Click);
            // 
            // lEMONTEAToolStripMenuItem
            // 
            this.lEMONTEAToolStripMenuItem.Name = "lEMONTEAToolStripMenuItem";
            this.lEMONTEAToolStripMenuItem.Size = new System.Drawing.Size(99, 34);
            this.lEMONTEAToolStripMenuItem.Text = "03 TEA";
            this.lEMONTEAToolStripMenuItem.Click += new System.EventHandler(this.lEMONTEAToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(184, 34);
            this.toolStripMenuItem3.Text = "04 FRESH MILK";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // fRESHMILKToolStripMenuItem
            // 
            this.fRESHMILKToolStripMenuItem.Name = "fRESHMILKToolStripMenuItem";
            this.fRESHMILKToolStripMenuItem.Size = new System.Drawing.Size(159, 34);
            this.fRESHMILKToolStripMenuItem.Text = "05 YOGURST";
            this.fRESHMILKToolStripMenuItem.Click += new System.EventHandler(this.fRESHMILKToolStripMenuItem_Click);
            // 
            // mACHIATOToolStripMenuItem
            // 
            this.mACHIATOToolStripMenuItem.Name = "mACHIATOToolStripMenuItem";
            this.mACHIATOToolStripMenuItem.Size = new System.Drawing.Size(175, 34);
            this.mACHIATOToolStripMenuItem.Text = "06 MACHIATO";
            this.mACHIATOToolStripMenuItem.Click += new System.EventHandler(this.mACHIATOToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(156, 34);
            this.toolStripMenuItem4.Text = "07 TOPPING";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // fASTFOODToolStripMenuItem
            // 
            this.fASTFOODToolStripMenuItem.Name = "fASTFOODToolStripMenuItem";
            this.fASTFOODToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.fASTFOODToolStripMenuItem.Text = "08 FAST FOOD";
            this.fASTFOODToolStripMenuItem.Click += new System.EventHandler(this.fASTFOODToolStripMenuItem_Click);
            // 
            // frm_home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1544, 784);
            this.Controls.Add(this.pl_home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_home";
            this.Load += new System.EventHandler(this.frm_home_Load);
            this.pl_home.ResumeLayout(false);
            this.pl_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBill)).EndInit();
            this.ms_home.ResumeLayout(false);
            this.ms_home.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_home;
        private System.Windows.Forms.Button btn_addBill;
        private System.Windows.Forms.MenuStrip ms_home;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activiyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mILKTEAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lEMONTEAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem fRESHMILKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mACHIATOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem fASTFOODToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button Pay;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ToolStripMenuItem addStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateInfoToolStripMenuItem;
        private System.Windows.Forms.Label lb_welcome;
        private System.Windows.Forms.TextBox txb_totalPrice;
        private System.Windows.Forms.ToolStripMenuItem manageStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catagoryManagementToolStripMenuItem;
    }
}