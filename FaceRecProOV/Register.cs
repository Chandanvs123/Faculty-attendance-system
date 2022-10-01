using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button_reg_Click(object sender, EventArgs e)
        {

            if (checkForIntegers(textBox_phone.Text) < 0)
            {
                MessageBox.Show("please enter valide phone number");

                textBox_phone.Focus();
                return;
            }
            if (textBox_phone.Text.Length != 10)
            {
                MessageBox.Show("please enter 10 digit");
                return;
            }

            User_details.str_address = textBox_address.Text;
            User_details.str_name = textBox_name.Text;
            User_details.str_phone = textBox_phone.Text;
            User_details.reg_log = "reg";
            User_details.str_ID = textBox_staff_Id.Text;


            this.Hide();
            FrmPrincipal frm_ob =   new FrmPrincipal();
            frm_ob.ShowDialog();
            this.Close();
            
        }

        public int checkForIntegers(String textboxString)
        {
            char[] chars;

            if (textboxString == "")
            {
                chars = textboxString.ToCharArray();
                return -1;
            }
            chars = textboxString.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                switch (chars[i])
                {
                    case '0': break;
                    case '1': break;
                    case '2': break;
                    case '3': break;
                    case '4': break;
                    case '5': break;
                    case '6': break;
                    case '7': break;
                    case '8': break;
                    case '9': break;
                    default: return -1;
                }
            }
            return 0;
        }


    }
}
