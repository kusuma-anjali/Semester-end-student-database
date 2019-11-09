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
    public partial class studentlogin : Form
    {
        public static string SetValueForText1 = "";
        public studentlogin()
        {
            InitializeComponent();
            pass2.PasswordChar = '*';
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new homepage().Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("You are in the student login page");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            new facultylogin().Show();
            this.Hide();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            new student_sign_up().Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Regex r = new Regex("^1BM\\d{2}CS\\d{3}$");
            Match m = r.Match(usn2.Text); 
            if (usn2.Text == "")
            {
                MessageBox.Show("Please enter Faculty-id");
            }

            else if (pass2.Text == "")
            {
                MessageBox.Show("Please enter Password");
            }
            else if (usn2.Text != "" && pass2.Text != "")
            {
                string connectionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=aish;";
                OleDbConnection connection = new OleDbConnection(connectionString);
                string sql = "Select count(*) from login where USN='" + (usn2.Text) + "'and pass='" + (pass2.Text) + "'";
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                if (m.Success)
                {
                    SetValueForText1 = usn2.Text;
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        new studentprofile().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("USN and password doesnot match");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid USN");
                }
            }
            else
            {
                MessageBox.Show("Welcome");
            }
        }

        private void studentlogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Adminlogin().Show();
            this.Hide();
        }
    }
}
