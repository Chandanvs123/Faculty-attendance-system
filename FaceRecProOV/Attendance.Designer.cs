namespace MultiFaceRec
{
    partial class Attendance
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
            this.dataGridView_attendance = new System.Windows.Forms.DataGridView();
            this.button_Entry = new System.Windows.Forms.Button();
            this.button_logut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_attendance)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_attendance
            // 
            this.dataGridView_attendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_attendance.Location = new System.Drawing.Point(308, 95);
            this.dataGridView_attendance.Name = "dataGridView_attendance";
            this.dataGridView_attendance.RowTemplate.Height = 24;
            this.dataGridView_attendance.Size = new System.Drawing.Size(575, 473);
            this.dataGridView_attendance.TabIndex = 0;
            // 
            // button_Entry
            // 
            this.button_Entry.BackColor = System.Drawing.Color.Green;
            this.button_Entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Entry.ForeColor = System.Drawing.Color.White;
            this.button_Entry.Location = new System.Drawing.Point(44, 196);
            this.button_Entry.Name = "button_Entry";
            this.button_Entry.Size = new System.Drawing.Size(144, 69);
            this.button_Entry.TabIndex = 1;
            this.button_Entry.Text = "Entry";
            this.button_Entry.UseVisualStyleBackColor = false;
            this.button_Entry.Click += new System.EventHandler(this.button_Entry_Click);
            // 
            // button_logut
            // 
            this.button_logut.BackColor = System.Drawing.Color.Green;
            this.button_logut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logut.ForeColor = System.Drawing.Color.White;
            this.button_logut.Location = new System.Drawing.Point(44, 328);
            this.button_logut.Name = "button_logut";
            this.button_logut.Size = new System.Drawing.Size(144, 69);
            this.button_logut.TabIndex = 2;
            this.button_logut.Text = "Exit";
            this.button_logut.UseVisualStyleBackColor = false;
            this.button_logut.Click += new System.EventHandler(this.button_logut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(472, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Attendance View";
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_logut);
            this.Controls.Add(this.button_Entry);
            this.Controls.Add(this.dataGridView_attendance);
            this.Name = "Attendance";
            this.Text = "Attendance";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_attendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_attendance;
        private System.Windows.Forms.Button button_Entry;
        private System.Windows.Forms.Button button_logut;
        private System.Windows.Forms.Label label1;
    }
}