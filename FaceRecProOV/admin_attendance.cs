using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WrapperDataBase;

namespace MultiFaceRec
{
    public partial class admin_attendance : Form
    {
        public admin_attendance()
        {
            InitializeComponent();

            String str_data = " SELECT name,user_id,address, phone FROM staff  ";
            String str_er = "";
            DataSet ds_att = new DataSet();
            cls_DataBase.return_Dataset(str_data, ref str_er, ref ds_att);
            dataGridView1.DataSource = ds_att.Tables[0];


            comboBox_staff.DataSource = ds_att.Tables[0];
            comboBox_staff.ValueMember = "user_id";
            comboBox_staff.DisplayMember = "name";
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string stDate = dateTimePicker_St.Value.ToString("yyyy-MM-dd 00:00:00");
            string endDate = dateTimePicker_end.Value.ToString("yyyy-MM-dd 22:22:22");
            fille_gid(stDate, endDate);
            User_details.str_ID = comboBox_staff.SelectedValue.ToString() ;
        }

        protected void fille_gid(String st_Date, String st_end)
        {
            String str_data = "SELECT staff_id,login_date,logout_date, Truncate (TIME_TO_SEC(TIMEDIFF(logout_date,login_date))/3600,2) as hour FROM college_attendence.attendance where staff_id='" + User_details.str_ID + "' and login_date >= '" + st_Date + "' and logout_date <= '" + st_end + "' and  logout_date != '0000-00-00 00:00:00'  ";
            String str_er = "";
            DataSet ds_att = new DataSet();

            cls_DataBase.return_Dataset(str_data, ref str_er, ref ds_att);
            dataGridView_at.DataSource = ds_att.Tables[0];
            String str_sum_hour = "SELECT staff_id,login_date,logout_date, sum(Truncate (TIME_TO_SEC(TIMEDIFF(logout_date,login_date))/3600,2)) as hour FROM college_attendence.attendance where staff_id='" + User_details.str_ID + "' and login_date >= '" + st_Date + "' and logout_date <= '" + st_end + "' and  logout_date != '0000-00-00 00:00:00'  ";
            DataSet ds_at_sum = new DataSet();

            cls_DataBase.return_Dataset(str_sum_hour, ref str_er, ref ds_at_sum);
            if (ds_at_sum.Tables[0].Rows.Count > 0)
            {
                textBox_hour.Text = ds_at_sum.Tables[0].Rows[0][3].ToString();
            }

        }
        private void button_logout_s_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();
            frm.ShowDialog();
            this.Close();
        }

        private void buttonlogout_AA_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();
            frm.ShowDialog();
            this.Close();
        }

        private void button_staff_Click(object sender, EventArgs e)
        {
            String str_data = " SELECT name,user_id,address, phone FROM staff  ";
            String str_er = "";
            DataSet ds_att = new DataSet();
            cls_DataBase.return_Dataset(str_data, ref str_er, ref ds_att);
            dataGridView1.DataSource = ds_att.Tables[0];
        }
    }
}
