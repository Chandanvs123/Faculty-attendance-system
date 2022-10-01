namespace MultiFaceRec
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_admin = new System.Windows.Forms.Button();
            this.button_Staff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_admin
            // 
            this.button_admin.BackColor = System.Drawing.Color.SeaGreen;
            this.button_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_admin.ForeColor = System.Drawing.Color.White;
            this.button_admin.Location = new System.Drawing.Point(419, 40);
            this.button_admin.Name = "button_admin";
            this.button_admin.Size = new System.Drawing.Size(198, 73);
            this.button_admin.TabIndex = 0;
            this.button_admin.Text = "Admin";
            this.button_admin.UseVisualStyleBackColor = false;
            this.button_admin.Click += new System.EventHandler(this.button_admin_Click);
            // 
            // button_Staff
            // 
            this.button_Staff.BackColor = System.Drawing.Color.SeaGreen;
            this.button_Staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Staff.ForeColor = System.Drawing.Color.White;
            this.button_Staff.Location = new System.Drawing.Point(798, 40);
            this.button_Staff.Name = "button_Staff";
            this.button_Staff.Size = new System.Drawing.Size(199, 73);
            this.button_Staff.TabIndex = 1;
            this.button_Staff.Text = "Staff";
            this.button_Staff.UseVisualStyleBackColor = false;
            this.button_Staff.Click += new System.EventHandler(this.button_Staff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1367, 718);
            this.Controls.Add(this.button_Staff);
            this.Controls.Add(this.button_admin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_admin;
        private System.Windows.Forms.Button button_Staff;
    }
}