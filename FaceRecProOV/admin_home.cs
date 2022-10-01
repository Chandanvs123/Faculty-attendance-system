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
    public partial class admin_home : Form
    {
        public admin_home()
        {
            InitializeComponent();
        }

        private void btn_count_v_Click(object sender, EventArgs e)
        {
            admin_vote vt_obj = new admin_vote();
            vt_obj.Show();
        }

        private void btn_nomination_Click(object sender, EventArgs e)
        {
            Nomination_form obj_nom = new Nomination_form();
            obj_nom.Show();
            
        }
    }
}
