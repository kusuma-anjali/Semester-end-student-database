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
    public partial class Adminlogin : Form
    {
        public Adminlogin()
        {
            InitializeComponent();
            pass4.PasswordChar = '*';
        }

        private void Adminlogin_Load(object sender, EventArgs e)
        {

        }

        private void home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new homepage().Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("You are in the Admin page");
        }

        private void student_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new studentlogin().Show();
            this.Hide();
        }

        private void faculty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new facultylogin().Show();
            this.Hide();
        }

        private void login1_Click(object sender, EventArgs e)
        {
            Regex r = new Regex("^CSE\\d{3}$");
            Match m = r.Match(fid2.Text);
            if (fid2.Text == "")
            {
                MessageBox.Show("Please enter Admin-id");
            }

            else if (pass4.Text == "")
            {
                MessageBox.Show("Please enter Password");
            }
            else if (fid2.Text != "" && pass4.Text != "")
            {
                string connectionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=aish;";
                OleDbConnection connection = new OleDbConnection(connectionString);
                string sql = "Select count(*) from facultylogin where fid='" + (fid2.Text) + "'and password='" + (pass4.Text) + "'";
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                if (m.Success)
                {
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        new Admin().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Admin-Id and password doesnot match");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Admin-Id");
                }
            }
            else
            {
                MessageBox.Show("Welcome");
            }
        }
    }
}
