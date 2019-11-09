using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace see_results
{
    public partial class studentprofile : Form
    {
        public studentprofile()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void usn1_TextChanged(object sender, EventArgs e)
        {

        }

        private void name1_TextChanged(object sender, EventArgs e)
        {

        }

        private void home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new homepage().Show();
            this.Hide();
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new homepage().Show();
            this.Hide();
        }

        private void studentprofile_Load(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source = orcl;User ID = system;Password = aish;";
            string sql = "SELECT cc_name,cie,see,tmarks,grades FROM result r,cc c where USN ='" + (studentlogin.SetValueForText1) + "'and r.cc_id=c.cc_id";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "result");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "result";

            usn1.Text = studentlogin.SetValueForText1;
            string source = "Provider=OraOLEDB.Oracle;Data Source = orcl;User ID = system;Password = aish;";
            OleDbConnection conn = new OleDbConnection(source);
            string sql2 = "Select * from student where USN ='" + (usn1.Text) + "'";
            OleDbCommand cmd = new OleDbCommand(sql2, conn);
            conn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                name1.Text = (string)dr["Stu_name"];
            }
            conn.Close();

        }
    }
}
