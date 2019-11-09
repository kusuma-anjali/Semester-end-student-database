using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;

namespace see_results
{
    public partial class facultyview : Form
    {
        public facultyview()
        {
            InitializeComponent();
        }

        private void home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new homepage().Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new homepage().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void facultyview_Load(object sender, EventArgs e)
        {
             string connetionString = "Provider=OraOLEDB.Oracle;Data Source = orcl;User ID = system;Password = aish;";
            string sql = "SELECT * FROM faculty order by USN";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "faculty");
            connection.Close();
            dgv1.DataSource = ds;
            dgv1.DataMember = "faculty";
        }
    }
}
