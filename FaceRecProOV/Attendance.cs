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
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
            check_at();
        }

        protected void check_at()
        {
            String str_data = "SELECT staff_id,login_date FROM college_attendence.attendance where staff_id='" + User_details.str_ID + "' and  logout_date = '0000-00-00 00:00:00'  ";
            String str_er = "";
            DataSet ds_att = new DataSet();

            cls_DataBase.return_Dataset(str_data, ref str_er, ref ds_att);


            if (ds_att.Tables[0].Rows.Count>0)
            {
                button_Entry.Visible = false;
                button_logut.Visible =true;

            }
            else
            {
                button_Entry.Visible = true;
                button_logut.Visible = false;
            }
        }

        private void button_Entry_Click(object sender, EventArgs e)
        {
            String str_err = "";
            try
            {

                String str_insert_cmd = "insert into college_attendence.attendance values('" + User_details.str_ID + "',now(),0,'0000/00/00')";
                if (cls_DataBase.insertIntoDB(str_insert_cmd, ref str_err) > 0)
                {
                    MessageBox.Show("record_inserted");
                    fille_gid();
                    this.Hide();
                    FrmPrincipal obj_fn = new FrmPrincipal();
                    obj_fn.ShowDialog();
                    this.Close();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("please contact admin");
                    return;
                }
                
            }
            catch (Exception ex)
            {
            }

        }

        protected void fille_gid()
        {
            String str_data = "SELECT staff_id,login_date,logout_date, Truncate (TIME_TO_SEC(TIMEDIFF(logout_date,login_date))/3600,2) as hour FROM college_attendence.attendance where staff_id='" + User_details.str_ID + "' and  logout_date != '0000-00-00 00:00:00'  ";
            String str_er = "";
            DataSet ds_att = new  DataSet();

            cls_DataBase.return_Dataset(str_data, ref str_er, ref ds_att);
            dataGridView_attendance.DataSource = ds_att.Tables[0];


        }


        private void button_logut_Click(object sender, EventArgs e)
        {
            String str_err = "";
            try
            {

                String str_insert_cmd = "update college_attendence.attendance set logout_date= now()  where logout_date='0000-00-00 00:00:00' and staff_id='" + User_details.str_ID + "'";
                if (cls_DataBase.insertIntoDB(str_insert_cmd, ref str_err) > 0)
                {
                    MessageBox.Show("record_inserted");
                    this.Hide();
                    FrmPrincipal obj_fn = new FrmPrincipal();
                    obj_fn.ShowDialog();
                    this.Close();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("please contact admin");
                    return;
                }

                
            }
            catch (Exception ex)
            {
            }
            fille_gid();
        }
    }
}
