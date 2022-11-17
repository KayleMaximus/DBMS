
namespace Group_08_Milk_Tea_App
{
    partial class frm_login
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
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbpassword = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.ptc_login = new System.Windows.Forms.PictureBox();
            this.rbtn_admin = new System.Windows.Forms.RadioButton();
            this.rbtn_staff = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptc_login)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsername.Location = new System.Drawing.Point(331, 177);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(265, 32);
            this.TextBoxUsername.TabIndex = 4;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.TextBoxPassword.Location = new System.Drawing.Point(331, 250);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(265, 32);
            this.TextBoxPassword.TabIndex = 6;
            this.TextBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPassword_KeyDown);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_login.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_login.Location = new System.Drawing.Point(156, 418);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(180, 65);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_exit.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_exit.Location = new System.Drawing.Point(368, 418);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(180, 64);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpassword.Image = global::Group_08_Milk_Tea_App.Properties.Resources.login1;
            this.lbpassword.Location = new System.Drawing.Point(158, 246);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(152, 35);
            this.lbpassword.TabIndex = 3;
            this.lbpassword.Text = "Password:";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Image = global::Group_08_Milk_Tea_App.Properties.Resources.blue;
            this.lb_name.Location = new System.Drawing.Point(150, 177);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(160, 35);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Username:";
            // 
            // ptc_login
            // 
            this.ptc_login.BackColor = System.Drawing.SystemColors.Control;
            this.ptc_login.Image = global::Group_08_Milk_Tea_App.Properties.Resources.login1;
            this.ptc_login.Location = new System.Drawing.Point(-6, -1);
            this.ptc_login.Name = "ptc_login";
            this.ptc_login.Size = new System.Drawing.Size(1225, 691);
            this.ptc_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptc_login.TabIndex = 0;
            this.ptc_login.TabStop = false;
            // 
            // rbtn_admin
            // 
            this.rbtn_admin.AutoSize = true;
            this.rbtn_admin.BackgroundImage = global::Group_08_Milk_Tea_App.Properties.Resources.blue;
            this.rbtn_admin.Checked = true;
            this.rbtn_admin.Font = new System.Drawing.Font("Modern No. 20", 20F);
            this.rbtn_admin.Location = new System.Drawing.Point(182, 353);
            this.rbtn_admin.Name = "rbtn_admin";
            this.rbtn_admin.Size = new System.Drawing.Size(131, 39);
            this.rbtn_admin.TabIndex = 9;
            this.rbtn_admin.TabStop = true;
            this.rbtn_admin.Text = "Admin";
            this.rbtn_admin.UseVisualStyleBackColor = true;
            // 
            // rbtn_staff
            // 
            this.rbtn_staff.AutoSize = true;
            this.rbtn_staff.BackgroundImage = global::Group_08_Milk_Tea_App.Properties.Resources.blue;
            this.rbtn_staff.Font = new System.Drawing.Font("Modern No. 20", 20F);
            this.rbtn_staff.Location = new System.Drawing.Point(408, 353);
            this.rbtn_staff.Name = "rbtn_staff";
            this.rbtn_staff.Size = new System.Drawing.Size(105, 39);
            this.rbtn_staff.TabIndex = 10;
            this.rbtn_staff.Text = "Staff";
            this.rbtn_staff.UseVisualStyleBackColor = true;
            // 
            // frm_login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1222, 688);
            this.Controls.Add(this.rbtn_staff);
            this.Controls.Add(this.rbtn_admin);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.lbpassword);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.ptc_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ptc_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptc_login;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.RadioButton rbtn_admin;
        private System.Windows.Forms.RadioButton rbtn_staff;
    }
}