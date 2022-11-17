
namespace Group_08_Milk_Tea_App.Utility
{
    partial class AddStaffForm
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
            this.txb_UserName = new System.Windows.Forms.TextBox();
            this.txb_PassWord = new System.Windows.Forms.TextBox();
            this.txb_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Cancel_SignIn = new System.Windows.Forms.Button();
            this.bt_SignIn = new System.Windows.Forms.Button();
            this.cbb_Role = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb_UserName
            // 
            this.txb_UserName.Location = new System.Drawing.Point(240, 93);
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.Size = new System.Drawing.Size(167, 22);
            this.txb_UserName.TabIndex = 5;
            // 
            // txb_PassWord
            // 
            this.txb_PassWord.Location = new System.Drawing.Point(240, 136);
            this.txb_PassWord.Name = "txb_PassWord";
            this.txb_PassWord.Size = new System.Drawing.Size(167, 22);
            this.txb_PassWord.TabIndex = 7;
            // 
            // txb_ConfirmPassword
            // 
            this.txb_ConfirmPassword.Location = new System.Drawing.Point(240, 178);
            this.txb_ConfirmPassword.Name = "txb_ConfirmPassword";
            this.txb_ConfirmPassword.Size = new System.Drawing.Size(167, 22);
            this.txb_ConfirmPassword.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(53, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Confirm Password: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(119, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(116, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // bt_Cancel_SignIn
            // 
            this.bt_Cancel_SignIn.BackColor = System.Drawing.Color.Red;
            this.bt_Cancel_SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel_SignIn.ForeColor = System.Drawing.Color.Black;
            this.bt_Cancel_SignIn.Location = new System.Drawing.Point(43, 278);
            this.bt_Cancel_SignIn.Name = "bt_Cancel_SignIn";
            this.bt_Cancel_SignIn.Size = new System.Drawing.Size(130, 56);
            this.bt_Cancel_SignIn.TabIndex = 11;
            this.bt_Cancel_SignIn.Text = "I Don\'t Want To Get Trĩ";
            this.bt_Cancel_SignIn.UseVisualStyleBackColor = false;
            this.bt_Cancel_SignIn.Click += new System.EventHandler(this.bt_Cancel_SignIn_Click);
            // 
            // bt_SignIn
            // 
            this.bt_SignIn.BackColor = System.Drawing.Color.Lime;
            this.bt_SignIn.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SignIn.ForeColor = System.Drawing.Color.Black;
            this.bt_SignIn.Location = new System.Drawing.Point(277, 278);
            this.bt_SignIn.Name = "bt_SignIn";
            this.bt_SignIn.Size = new System.Drawing.Size(130, 56);
            this.bt_SignIn.TabIndex = 10;
            this.bt_SignIn.Text = "Sign Me In";
            this.bt_SignIn.UseVisualStyleBackColor = false;
            this.bt_SignIn.Click += new System.EventHandler(this.bt_SignIn_Click);
            // 
            // cbb_Role
            // 
            this.cbb_Role.FormattingEnabled = true;
            this.cbb_Role.Location = new System.Drawing.Point(240, 219);
            this.cbb_Role.Name = "cbb_Role";
            this.cbb_Role.Size = new System.Drawing.Size(167, 24);
            this.cbb_Role.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(154, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Role: ";
            // 
            // AddStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 424);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbb_Role);
            this.Controls.Add(this.bt_Cancel_SignIn);
            this.Controls.Add(this.bt_SignIn);
            this.Controls.Add(this.txb_UserName);
            this.Controls.Add(this.txb_PassWord);
            this.Controls.Add(this.txb_ConfirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStaffForm";
            this.Text = "AddStaffForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_UserName;
        private System.Windows.Forms.TextBox txb_PassWord;
        private System.Windows.Forms.TextBox txb_ConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Cancel_SignIn;
        private System.Windows.Forms.Button bt_SignIn;
        private System.Windows.Forms.ComboBox cbb_Role;
        private System.Windows.Forms.Label label4;
    }
}