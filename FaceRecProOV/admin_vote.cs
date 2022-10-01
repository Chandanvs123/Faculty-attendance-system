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
    public partial class admin_vote : Form
    {
        public admin_vote()
        {
            InitializeComponent();
        }

        private void btn_count_vote_Click(object sender, EventArgs e)
        {
            String str_count_vote = "select count(id), candidate from voting_face.votes group by candidate";

            DataSet ds_vote = new DataSet();
            String str_err = "";

            cls_DataBase.return_Dataset(str_count_vote, ref str_err, ref ds_vote);
            dataGridView_vote.DataSource = ds_vote.Tables[0];




        }
    }
}
