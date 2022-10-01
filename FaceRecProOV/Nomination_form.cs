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
    public partial class Nomination_form : Form
    {
        public Nomination_form()
        {
            InitializeComponent();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            String str_insert = "insert into voting_face.nomination  values(null,'"+textBox_name.Text+"','"+textBox_age.Text+"','"+textBox_phone.Text+"','"+textBox_address+"','"+comboBox_party.Text+"')";
            String str_err = "";
            if (cls_DataBase.insertIntoDB(str_insert, ref str_err) > 0)
            {
                MessageBox.Show("inserted");
            }
            else
            {
                MessageBox.Show("please contact Admin");
            }




        }
    }
}
