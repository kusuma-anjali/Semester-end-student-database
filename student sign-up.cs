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
    public partial class student_sign_up : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;
        DataSet ds;

        public void ConnectString()
        {
            string connectionString = "Provider=OraOLEDB.Oracle;Data Source = orcl;User ID = system;Password = aish;";
            string sql = "Select * from student";

            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, connection);

            ds = new DataSet();
            connection.Open();
            dataAdapter.Fill(ds, "student");
            connection.Close();
        }
        public student_sign_up()
        {
            InitializeComponent();
            pass1.PasswordChar = '*';
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void student_sign_up_Load(object sender, EventArgs e)
        {
            ConnectString();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (name1.Text != "" && usn1.Text != "" && number.Text != "" && email.Text != "" && dob.Text != "" && pass1.Text != "")
            {

                Regex r = new Regex("^1BM\\d{2}CS\\d{3}$");
                Match m = r.Match(usn1.Text);
                Regex r1 = new Regex("^\\d{10}$");
                Match m1 = r1.Match(number.Text);


                if (m.Success)
                {
                    if (m1.Success)
                    {
                        string connectionString = "Provider=OraOLEDB.Oracle;Data Source = orcl;User ID = system;Password = aish;";
                        string sql = "Select * from student";
                        string sql2 = "Select * from login";
                        OleDbConnection connection = new OleDbConnection(connectionString);
                        OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, connection);
                        OleDbDataAdapter da1 = new OleDbDataAdapter(sql2, connection);
                        ds = new DataSet();
                        DataSet ds1 = new DataSet();
                        connection.Open();
                        // dataAdapter.Fill(ds,"student");

                        string sql1 = "insert into student VALUES('" + name1.Text + "','" + usn1.Text + "','" + number.Text + "','" + email.Text + "','" + pass1.Text + "','" + dob.Text + "')";
                        dataAdapter.InsertCommand = new OleDbCommand(sql1, connection);
                        dataAdapter.InsertCommand.ExecuteNonQuery();
                        string sql3 = "insert into login VALUES('" + usn1.Text + "','" + pass1.Text + "')";
                        dataAdapter.InsertCommand = new OleDbCommand(sql3, connection);
                        dataAdapter.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Sign-up was Successful");
                        dataAdapter.Fill(ds, "student");
                        dataAdapter.Fill(ds1, "login");

                        connection.Close();
                        new studentlogin().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("enter 10 digit number");
                        number.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("enter USN properly");
                    usn1.Focus();
                }

               
            }
            else
            {
                MessageBox.Show("enter all the fields");
            }


        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new homepage().Show();
            this.Hide();
        }

        private void usn1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
