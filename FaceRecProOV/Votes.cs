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
    public partial class Votes : Form
    {
        public Votes()
        {
            InitializeComponent();

            String str_retryive = "SELECT * FROM voting_face.nomination ";

            DataSet ds_data = new DataSet();
            String str_err = "";
            cls_DataBase.return_Dataset(str_retryive, ref str_err, ref ds_data);


            dataGridView1.DataSource = ds_data.Tables[0];
            comboBox_candidate.DataSource = ds_data.Tables[0];
            comboBox_candidate.DisplayMember = "name";
            comboBox_candidate.ValueMember = "name";
        }

        private void btn_vote_Click(object sender, EventArgs e)
        {
            String str_vote = "insert into  voting_face.votes values (null,'"+User_details.str_name+"','"+comboBox_candidate.Text+"','party','1')";
            String str_err = "";
            if (cls_DataBase.insertIntoDB(str_vote, ref str_err) > 0)
            {
                MessageBox.Show("succefully voted");
            }
            else
            {
                MessageBox.Show(" you might have voted already please go back ");
            }


        }

        private void button_home_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();

            this.Hide();
        }
    }
}
