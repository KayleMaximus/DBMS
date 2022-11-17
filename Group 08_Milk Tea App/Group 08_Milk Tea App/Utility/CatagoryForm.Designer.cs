
namespace Group_08_Milk_Tea_App.Utility
{
    partial class CatagoryForm
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
            this.cbb_SelectCourse = new System.Windows.Forms.ComboBox();
            this.txb_Label = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbb_SelectCourse
            // 
            this.cbb_SelectCourse.FormattingEnabled = true;
            this.cbb_SelectCourse.Location = new System.Drawing.Point(304, 51);
            this.cbb_SelectCourse.Name = "cbb_SelectCourse";
            this.cbb_SelectCourse.Size = new System.Drawing.Size(213, 24);
            this.cbb_SelectCourse.TabIndex = 21;
            // 
            // txb_Label
            // 
            this.txb_Label.Location = new System.Drawing.Point(304, 103);
            this.txb_Label.Name = "txb_Label";
            this.txb_Label.Size = new System.Drawing.Size(213, 22);
            this.txb_Label.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(149, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Change Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(142, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Select Catagory: ";
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.Color.Cyan;
            this.bt_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Edit.Location = new System.Drawing.Point(79, 166);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(527, 65);
            this.bt_Edit.TabIndex = 25;
            this.bt_Edit.Text = "Edit";
            this.bt_Edit.UseVisualStyleBackColor = false;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // CatagoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 296);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.cbb_SelectCourse);
            this.Controls.Add(this.txb_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CatagoryForm";
            this.Text = "CatagoryForm";
            this.Load += new System.EventHandler(this.CatagoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_SelectCourse;
        private System.Windows.Forms.TextBox txb_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Edit;
    }
}