namespace MultiFaceRec
{
    partial class admin_attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_attendance));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_logout_s = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonlogout_AA = new System.Windows.Forms.Button();
            this.dataGridView_at = new System.Windows.Forms.DataGridView();
            this.comboBox_staff = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_hour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_St = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_at)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1400, 741);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button_logout_s);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1392, 699);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Staff List  ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_logout_s
            // 
            this.button_logout_s.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_logout_s.Location = new System.Drawing.Point(1201, 32);
            this.button_logout_s.Name = "button_logout_s";
            this.button_logout_s.Size = new System.Drawing.Size(174, 52);
            this.button_logout_s.TabIndex = 3;
            this.button_logout_s.Text = "Logout";
            this.button_logout_s.UseVisualStyleBackColor = true;
            this.button_logout_s.Click += new System.EventHandler(this.button_logout_s_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(311, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(828, 463);
            this.dataGridView1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 242);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Linen;
            this.tabPage2.Controls.Add(this.buttonlogout_AA);
            this.tabPage2.Controls.Add(this.dataGridView_at);
            this.tabPage2.Controls.Add(this.comboBox_staff);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBox_hour);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button_search);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dateTimePicker_end);
            this.tabPage2.Controls.Add(this.dateTimePicker_St);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1392, 699);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " Attendance";
            // 
            // buttonlogout_AA
            // 
            this.buttonlogout_AA.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonlogout_AA.Location = new System.Drawing.Point(1220, 22);
            this.buttonlogout_AA.Name = "buttonlogout_AA";
            this.buttonlogout_AA.Size = new System.Drawing.Size(164, 40);
            this.buttonlogout_AA.TabIndex = 11;
            this.buttonlogout_AA.Text = "Logout";
            this.buttonlogout_AA.UseVisualStyleBackColor = true;
            this.buttonlogout_AA.Click += new System.EventHandler(this.buttonlogout_AA_Click);
            // 
            // dataGridView_at
            // 
            this.dataGridView_at.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_at.Location = new System.Drawing.Point(197, 270);
            this.dataGridView_at.Name = "dataGridView_at";
            this.dataGridView_at.RowTemplate.Height = 24;
            this.dataGridView_at.Size = new System.Drawing.Size(457, 418);
            this.dataGridView_at.TabIndex = 10;
            // 
            // comboBox_staff
            // 
            this.comboBox_staff.FormattingEnabled = true;
            this.comboBox_staff.Location = new System.Drawing.Point(329, 181);
            this.comboBox_staff.Name = "comboBox_staff";
            this.comboBox_staff.Size = new System.Drawing.Size(188, 37);
            this.comboBox_staff.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(518, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Attendance Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select Staff";
            // 
            // textBox_hour
            // 
            this.textBox_hour.Location = new System.Drawing.Point(704, 478);
            this.textBox_hour.Name = "textBox_hour";
            this.textBox_hour.Size = new System.Drawing.Size(259, 34);
            this.textBox_hour.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(699, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Working Hours";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(763, 169);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(200, 49);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date";
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_end.Location = new System.Drawing.Point(763, 101);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(200, 34);
            this.dateTimePicker_end.TabIndex = 1;
            // 
            // dateTimePicker_St
            // 
            this.dateTimePicker_St.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_St.Location = new System.Drawing.Point(329, 106);
            this.dateTimePicker_St.Name = "dateTimePicker_St";
            this.dateTimePicker_St.Size = new System.Drawing.Size(200, 34);
            this.dateTimePicker_St.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSalmon;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(615, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "Staff Details";
            // 
            // admin_attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 741);
            this.Controls.Add(this.tabControl1);
            this.Name = "admin_attendance";
            this.Text = "admin_attendance";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_at)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView_at;
        private System.Windows.Forms.ComboBox comboBox_staff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_hour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.DateTimePicker dateTimePicker_St;
        private System.Windows.Forms.Button button_logout_s;
        private System.Windows.Forms.Button buttonlogout_AA;
        private System.Windows.Forms.Label label6;
    }
}