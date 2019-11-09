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
    public partial class Admin : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter dataadapter;
        DataSet ds;
        

        public Admin()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void complete_Click(object sender, EventArgs e)
        {
            if (c1.Text != "" && c2.Text != "" && c3.Text != "" && c4.Text != "" && c5.Text != "" && s1.Text != "" && s2.Text != "" && s3.Text != "" && s4.Text != "" && s5.Text != "")
            {
                if (int.Parse(c1.Text) <= 50 && int.Parse(c2.Text) <= 50 && int.Parse(c3.Text) <= 50 && int.Parse(c4.Text) <= 50 && int.Parse(c5.Text) <= 50 && int.Parse(s1.Text) <= 50 && int.Parse(s2.Text) <= 50 && int.Parse(s3.Text) <= 50 && int.Parse(s4.Text) <= 50 && int.Parse(s5.Text) <= 50)
                {
                    int res = int.Parse(c1.Text) + int.Parse(s1.Text);
                    t1.Text = Convert.ToString(res);
                    int res1 = int.Parse(c2.Text) + int.Parse(s2.Text);
                    t2.Text = Convert.ToString(res1);
                    int res2 = int.Parse(c3.Text) + int.Parse(s3.Text);
                    t3.Text = Convert.ToString(res2);
                    int res3 = int.Parse(c4.Text) + int.Parse(s4.Text);
                    t4.Text = Convert.ToString(res3);
                    int res4 = int.Parse(c5.Text) + int.Parse(s5.Text);
                    t5.Text = Convert.ToString(res4);

                    if (int.Parse(c1.Text) < 20)
                    {
                        g1.Text = "X";
                        s1.Text = Convert.ToString(0);
                        t1.Text = c1.Text;
                    }
                    else if (int.Parse(s1.Text) < 20)
                    {
                        g1.Text = "F";

                    }
                    else
                    {
                        if (int.Parse(t1.Text) >= 90 && int.Parse(t1.Text) <= 100)
                            g1.Text = "S";
                        if (int.Parse(t1.Text) >= 75 && int.Parse(t1.Text) < 90)
                            g1.Text = "A";
                        if (int.Parse(t1.Text) >= 65 && int.Parse(t1.Text) < 75)
                            g1.Text = "B";
                        if (int.Parse(t1.Text) >= 50 && int.Parse(t1.Text) < 65)
                            g1.Text = "C";
                        if (int.Parse(t1.Text) >= 45 && int.Parse(t1.Text) < 50)
                            g1.Text = "D";
                        if (int.Parse(t1.Text) >= 40 && int.Parse(t1.Text) < 45)
                            g1.Text = "E";
                       
                    }
                    if (int.Parse(c2.Text) < 20)
                    {
                        g2.Text = "X";
                        s2.Text = Convert.ToString(0);
                        t2.Text = c2.Text;
                    }
                    else if (int.Parse(s2.Text) < 20)
                    {
                        g2.Text = "F";

                    }
                    else
                    {

                        if (int.Parse(t2.Text) >= 90 && int.Parse(t2.Text) <= 100)
                            g2.Text = "S";
                        if (int.Parse(t2.Text) >= 75 && int.Parse(t2.Text) < 90)
                            g2.Text = "A";
                        if (int.Parse(t2.Text) >= 65 && int.Parse(t2.Text) < 75)
                            g2.Text = "B";
                        if (int.Parse(t2.Text) >= 50 && int.Parse(t2.Text) < 65)
                            g2.Text = "C";
                        if (int.Parse(t2.Text) >= 45 && int.Parse(t2.Text) < 50)
                            g2.Text = "D";
                        if (int.Parse(t2.Text) >= 40 && int.Parse(t2.Text) < 45)
                            g2.Text = "E";
                        
                    }
                    if (int.Parse(c3.Text) < 20)
                    {
                        g3.Text = "X";
                        s3.Text = Convert.ToString(0);
                        t3.Text = c3.Text;
                    }
                    else if (int.Parse(s3.Text) < 20)
                    {
                        g3.Text = "F";

                    }
                    else
                    {
                        if (int.Parse(t3.Text) >= 90 && int.Parse(t3.Text) <= 100)
                            g3.Text = "S";
                        if (int.Parse(t3.Text) >= 75 && int.Parse(t3.Text) < 90)
                            g3.Text = "A";
                        if (int.Parse(t3.Text) >= 65 && int.Parse(t3.Text) < 75)
                            g3.Text = "B";
                        if (int.Parse(t3.Text) >= 50 && int.Parse(t3.Text) < 65)
                            g3.Text = "C";
                        if (int.Parse(t3.Text) >= 45 && int.Parse(t3.Text) < 50)
                            g3.Text = "D";
                        if (int.Parse(t3.Text) >= 40 && int.Parse(t3.Text) < 45)
                            g3.Text = "E";
                       
                    }
                    if (int.Parse(c4.Text) < 20)
                    {
                        g4.Text = "X";
                        s4.Text = Convert.ToString(0);
                        t4.Text = c4.Text;
                    }
                    else if (int.Parse(s4.Text) < 20)
                    {
                        g4.Text = "F";

                    }
                    else
                    {
                        if (int.Parse(t4.Text) >= 90 && int.Parse(t4.Text) <= 100)
                            g4.Text = "S";
                        if (int.Parse(t4.Text) >= 75 && int.Parse(t4.Text) < 90)
                            g4.Text = "A";
                        if (int.Parse(t4.Text) >= 65 && int.Parse(t4.Text) < 75)
                            g4.Text = "B";
                        if (int.Parse(t4.Text) >= 50 && int.Parse(t4.Text) < 65)
                            g4.Text = "C";
                        if (int.Parse(t4.Text) >= 45 && int.Parse(t4.Text) < 50)
                            g4.Text = "D";
                        if (int.Parse(t4.Text) >= 40 && int.Parse(t4.Text) < 45)
                            g4.Text = "E";
                        
                    }
                    if (int.Parse(c5.Text) < 20)
                    {
                        g5.Text = "X";
                        s5.Text = Convert.ToString(0);
                        t5.Text = c5.Text;
                    }
                    else if (int.Parse(s5.Text) < 20)
                    {
                        g5.Text = "F";

                    }
                    else
                    {
                        if (int.Parse(t5.Text) >= 90 && int.Parse(t5.Text) <= 100)
                            g5.Text = "S";
                        if (int.Parse(t5.Text) >= 75 && int.Parse(t5.Text) < 90)
                            g5.Text = "A";
                        if (int.Parse(t5.Text) >= 65 && int.Parse(t5.Text) < 75)
                            g5.Text = "B";
                        if (int.Parse(t5.Text) >= 50 && int.Parse(t5.Text) < 65)
                            g5.Text = "C";
                        if (int.Parse(t5.Text) >= 45 && int.Parse(t5.Text) < 50)
                            g5.Text = "D";
                        if (int.Parse(t5.Text) >= 40 && int.Parse(t5.Text) < 45)
                            g5.Text = "E";
                       
                    }
                }
                else
                {
                    MessageBox.Show("Please enter marks out-of 50");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
            
            


        }

        private void clear_Click(object sender, EventArgs e)
        {
            foreach(Control c in Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
            }
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=aish;";
            string sql = "SELECT * FROM result";
            
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            ds = new DataSet();

            connection.Open();
            dataadapter.Fill(ds, "result");
            if (usn5.Text!=""&& name5.Text!="" && c1.Text != "" && c2.Text != "" && c3.Text != "" && c4.Text != "" && c5.Text != "" && s1.Text != "" && s2.Text != "" && s3.Text != "" && s4.Text != "" && s5.Text != "")
            {
                if(int.Parse(c1.Text) <=50  && int.Parse(c2.Text) <=50 && int.Parse(c3.Text) <=50 && int.Parse(c4.Text) <=50 && int.Parse(c5.Text) <=50 && int.Parse(s1.Text) <=50 && int.Parse(s2.Text) <=50 && int.Parse(s3.Text) <=50 && int.Parse(s4.Text)<=50 && int.Parse(s5.Text) <=50)
                {
                    string sql2 = "Insert into result VALUES('" + usn5.Text + "','" + l1.Text + "','" + c1.Text + "','" + s1.Text + "','" + t1.Text + "','" + g1.Text + "')";
                    string sql3 = "Insert into result VALUES('" + usn5.Text + "','" + l2.Text + "','" + c2.Text + "','" + s2.Text + "','" + t2.Text + "','" + g2.Text + "')";
                    string sql4 = "Insert into result VALUES('" + usn5.Text + "','" + l3.Text + "','" + c3.Text + "','" + s3.Text + "','" + t3.Text + "','" + g3.Text + "' )";
                    string sql5 = "Insert into result VALUES('" + usn5.Text + "','" + l4.Text + "','" + c4.Text + "','" + s4.Text + "','" + t4.Text + "','" + g4.Text + "' )";
                    string sql6 = "Insert into result VALUES('" + usn5.Text + "','" + l5.Text + "','" + c5.Text + "','" + s5.Text + "','" + t5.Text + "','" + g5.Text + "' )";
                    dataadapter.InsertCommand = new OleDbCommand(sql2, connection);
                    dataadapter.InsertCommand.ExecuteNonQuery();

                    dataadapter.InsertCommand = new OleDbCommand(sql3, connection);
                    dataadapter.InsertCommand.ExecuteNonQuery();

                    dataadapter.InsertCommand = new OleDbCommand(sql4, connection);
                    dataadapter.InsertCommand.ExecuteNonQuery();

                    dataadapter.InsertCommand = new OleDbCommand(sql5, connection);
                    dataadapter.InsertCommand.ExecuteNonQuery();

                    dataadapter.InsertCommand = new OleDbCommand(sql6, connection);
                    dataadapter.InsertCommand.ExecuteNonQuery();

                    MessageBox.Show("Row(s) Inserted into result !! ");
                    connection.Close();

                    string conn = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=aish;";

                    OleDbConnection connect = new OleDbConnection(conn);
                    string sql1 = "SELECT * FROM faculty";
                    OleDbDataAdapter da = new OleDbDataAdapter(sql1, connect);
                    ds = new DataSet();
                    connection.Open();
                    da.Fill(ds, "faculty");
                    string sql7 = "Insert into faculty VALUES ('" + usn5.Text + "','" + name5.Text + "','" + t1.Text + "','" + t2.Text + "','" + t3.Text + "','" + t4.Text + "','" + t5.Text + "')";
                    dataadapter.InsertCommand = new OleDbCommand(sql7, connection);
                    dataadapter.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("Row(s) Inserted into faculty !! ");
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Please enter marks out of 50");
                }
            }
                
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
