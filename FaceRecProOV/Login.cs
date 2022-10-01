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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            User_details.str_ID = textBox_uname.Text;

            String str_data = " SELECT name,user_id,address, phone FROM staff where user_id= '" + User_details.str_ID + "'  ";
            String str_er = "";
            DataSet ds_att = new DataSet();
            cls_DataBase.return_Dataset(str_data, ref str_er, ref ds_att);
            if (ds_att.Tables[0].Rows.Count > 0)
            {
                this.Hide();
                User_details.reg_log = "log";
                FrmPrincipal obj_fn = new FrmPrincipal();

                obj_fn.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("invalide staff ID ");
            }




        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_details.reg_log = "reg";
            Register reg = new Register();

            reg.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();
            frm.ShowDialog();
            this.Close();
        }
    }
}
