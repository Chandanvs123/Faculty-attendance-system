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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_admin_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login_a lg = new Login_a();
            lg.ShowDialog();
            this.Close();

        }

        private void button_Staff_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login lg = new Login();
            lg.ShowDialog();
            this.Close();
        }
    }
}
