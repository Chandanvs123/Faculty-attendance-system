namespace MultiFaceRec
{
    partial class admin_home
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
            this.btn_nomination = new System.Windows.Forms.Button();
            this.btn_count_v = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_nomination
            // 
            this.btn_nomination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nomination.Location = new System.Drawing.Point(225, 160);
            this.btn_nomination.Name = "btn_nomination";
            this.btn_nomination.Size = new System.Drawing.Size(253, 106);
            this.btn_nomination.TabIndex = 0;
            this.btn_nomination.Text = "Nomination";
            this.btn_nomination.UseVisualStyleBackColor = true;
            this.btn_nomination.Click += new System.EventHandler(this.btn_nomination_Click);
            // 
            // btn_count_v
            // 
            this.btn_count_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_count_v.Location = new System.Drawing.Point(736, 160);
            this.btn_count_v.Name = "btn_count_v";
            this.btn_count_v.Size = new System.Drawing.Size(240, 106);
            this.btn_count_v.TabIndex = 1;
            this.btn_count_v.Text = "Vote Count";
            this.btn_count_v.UseVisualStyleBackColor = true;
            this.btn_count_v.Click += new System.EventHandler(this.btn_count_v_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin Home";
            // 
            // admin_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 779);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_count_v);
            this.Controls.Add(this.btn_nomination);
            this.Name = "admin_home";
            this.Text = "admin_home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nomination;
        private System.Windows.Forms.Button btn_count_v;
        private System.Windows.Forms.Label label1;
    }
}