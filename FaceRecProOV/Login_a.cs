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
    public partial class Login_a : Form
    {
        public Login_a()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_pass.Text=="admin" && textBox_uname.Text == "admin")

            {
                this.Hide();
                admin_attendance ad = new admin_attendance();
                ad.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("invalid Uname or Password");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_pass.Text = "";
            textBox_uname.Text = "";
        }
    }
}
