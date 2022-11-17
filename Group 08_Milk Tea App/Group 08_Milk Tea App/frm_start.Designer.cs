
namespace Group_08_Milk_Tea_App
{
    partial class frm_start
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
            this.ptc_start = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptc_start)).BeginInit();
            this.SuspendLayout();
            // 
            // ptc_start
            // 
            this.ptc_start.Image = global::Group_08_Milk_Tea_App.Properties.Resources.background3;
            this.ptc_start.Location = new System.Drawing.Point(0, -1);
            this.ptc_start.Name = "ptc_start";
            this.ptc_start.Size = new System.Drawing.Size(1283, 696);
            this.ptc_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptc_start.TabIndex = 0;
            this.ptc_start.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_start.BackgroundImage = global::Group_08_Milk_Tea_App.Properties.Resources.background3;
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_start.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_start.Font = new System.Drawing.Font("Segoe Script", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(1029, 607);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(254, 75);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start ⇨";
            this.btn_start.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // frm_start
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1283, 694);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.ptc_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_start_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ptc_start)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptc_start;
        private System.Windows.Forms.Button btn_start;
    }
}

