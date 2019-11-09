namespace see_results
{
    partial class Adminlogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Amdin = new System.Windows.Forms.LinkLabel();
            this.student = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.LinkLabel();
            this.faculty = new System.Windows.Forms.LinkLabel();
            this.faclogin = new System.Windows.Forms.GroupBox();
            this.login1 = new System.Windows.Forms.Button();
            this.pass4 = new System.Windows.Forms.TextBox();
            this.fid2 = new System.Windows.Forms.TextBox();
            this.pass3 = new System.Windows.Forms.Label();
            this.fid1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.faclogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.Amdin);
            this.groupBox1.Controls.Add(this.student);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.home);
            this.groupBox1.Controls.Add(this.faculty);
            this.groupBox1.Location = new System.Drawing.Point(1, -12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 61);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Amdin
            // 
            this.Amdin.AutoSize = true;
            this.Amdin.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amdin.Location = new System.Drawing.Point(418, 19);
            this.Amdin.Name = "Amdin";
            this.Amdin.Size = new System.Drawing.Size(84, 33);
            this.Amdin.TabIndex = 11;
            this.Amdin.TabStop = true;
            this.Amdin.Text = "Admin";
            this.Amdin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student.Location = new System.Drawing.Point(495, 19);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(104, 33);
            this.student.TabIndex = 7;
            this.student.TabStop = true;
            this.student.Text = "Student";
            this.student.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.student_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // home
            // 
            this.home.AutoSize = true;
            this.home.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Location = new System.Drawing.Point(347, 19);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(77, 33);
            this.home.TabIndex = 6;
            this.home.TabStop = true;
            this.home.Text = "Home";
            this.home.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.home_LinkClicked);
            // 
            // faculty
            // 
            this.faculty.AutoSize = true;
            this.faculty.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faculty.Location = new System.Drawing.Point(594, 19);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(96, 33);
            this.faculty.TabIndex = 5;
            this.faculty.TabStop = true;
            this.faculty.Text = "Faculty";
            this.faculty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.faculty_LinkClicked);
            // 
            // faclogin
            // 
            this.faclogin.Controls.Add(this.login1);
            this.faclogin.Controls.Add(this.pass4);
            this.faclogin.Controls.Add(this.fid2);
            this.faclogin.Controls.Add(this.pass3);
            this.faclogin.Controls.Add(this.fid1);
            this.faclogin.Location = new System.Drawing.Point(166, 122);
            this.faclogin.Name = "faclogin";
            this.faclogin.Size = new System.Drawing.Size(363, 206);
            this.faclogin.TabIndex = 9;
            this.faclogin.TabStop = false;
            this.faclogin.Text = "ADMIN LOGIN";
            // 
            // login1
            // 
            this.login1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login1.Location = new System.Drawing.Point(108, 117);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(144, 37);
            this.login1.TabIndex = 4;
            this.login1.Text = "LOGIN";
            this.login1.UseVisualStyleBackColor = true;
            this.login1.Click += new System.EventHandler(this.login1_Click);
            // 
            // pass4
            // 
            this.pass4.Location = new System.Drawing.Point(136, 72);
            this.pass4.Name = "pass4";
            this.pass4.Size = new System.Drawing.Size(210, 22);
            this.pass4.TabIndex = 3;
            // 
            // fid2
            // 
            this.fid2.Location = new System.Drawing.Point(136, 31);
            this.fid2.Name = "fid2";
            this.fid2.Size = new System.Drawing.Size(210, 22);
            this.fid2.TabIndex = 2;
            // 
            // pass3
            // 
            this.pass3.AutoSize = true;
            this.pass3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass3.Location = new System.Drawing.Point(22, 72);
            this.pass3.Name = "pass3";
            this.pass3.Size = new System.Drawing.Size(83, 20);
            this.pass3.TabIndex = 1;
            this.pass3.Text = "Password";
            // 
            // fid1
            // 
            this.fid1.AutoSize = true;
            this.fid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fid1.Location = new System.Drawing.Point(22, 31);
            this.fid1.Name = "fid1";
            this.fid1.Size = new System.Drawing.Size(75, 20);
            this.fid1.TabIndex = 0;
            this.fid1.Text = "Admin-Id";
            // 
            // Adminlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.faclogin);
            this.Controls.Add(this.groupBox1);
            this.Name = "Adminlogin";
            this.Text = "Adminlogin";
            this.Load += new System.EventHandler(this.Adminlogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.faclogin.ResumeLayout(false);
            this.faclogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel Amdin;
        private System.Windows.Forms.LinkLabel student;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel home;
        private System.Windows.Forms.LinkLabel faculty;
        private System.Windows.Forms.GroupBox faclogin;
        private System.Windows.Forms.Button login1;
        private System.Windows.Forms.TextBox pass4;
        private System.Windows.Forms.TextBox fid2;
        private System.Windows.Forms.Label pass3;
        private System.Windows.Forms.Label fid1;
    }
}