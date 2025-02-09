namespace Library_Management_System
{
    partial class userRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userRegister));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linklogintxt = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.acceptcheck = new System.Windows.Forms.CheckBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.studentnumtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.Lastnametxt = new System.Windows.Forms.TextBox();
            this.confirmpasstxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 827);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linklogintxt);
            this.panel2.Controls.Add(this.confirmpasstxt);
            this.panel2.Controls.Add(this.Lastnametxt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nametxt);
            this.panel2.Controls.Add(this.createBtn);
            this.panel2.Controls.Add(this.acceptcheck);
            this.panel2.Controls.Add(this.emailtxt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.studentnumtxt);
            this.panel2.Controls.Add(this.passtxt);
            this.panel2.Location = new System.Drawing.Point(328, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 553);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // linklogintxt
            // 
            this.linklogintxt.AutoSize = true;
            this.linklogintxt.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklogintxt.Location = new System.Drawing.Point(344, 512);
            this.linklogintxt.Name = "linklogintxt";
            this.linklogintxt.Size = new System.Drawing.Size(43, 23);
            this.linklogintxt.TabIndex = 11;
            this.linklogintxt.TabStop = true;
            this.linklogintxt.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Already have account?";
            // 
            // acceptcheck
            // 
            this.acceptcheck.AutoSize = true;
            this.acceptcheck.Font = new System.Drawing.Font("Poppins Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptcheck.Location = new System.Drawing.Point(96, 416);
            this.acceptcheck.Name = "acceptcheck";
            this.acceptcheck.Size = new System.Drawing.Size(219, 30);
            this.acceptcheck.TabIndex = 8;
            this.acceptcheck.Text = "Accept Terms & Conditions";
            this.acceptcheck.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.createBtn.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.ForeColor = System.Drawing.Color.White;
            this.createBtn.Location = new System.Drawing.Point(156, 451);
            this.createBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(244, 46);
            this.createBtn.TabIndex = 7;
            this.createBtn.Text = "Create Account";
            this.createBtn.UseVisualStyleBackColor = false;
            // 
            // passtxt
            // 
            this.passtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passtxt.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(96, 309);
            this.passtxt.Margin = new System.Windows.Forms.Padding(2);
            this.passtxt.Multiline = true;
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(360, 40);
            this.passtxt.TabIndex = 6;
            this.passtxt.Text = "Password";
            this.passtxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // studentnumtxt
            // 
            this.studentnumtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentnumtxt.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentnumtxt.Location = new System.Drawing.Point(96, 247);
            this.studentnumtxt.Margin = new System.Windows.Forms.Padding(2);
            this.studentnumtxt.Multiline = true;
            this.studentnumtxt.Name = "studentnumtxt";
            this.studentnumtxt.Size = new System.Drawing.Size(360, 37);
            this.studentnumtxt.TabIndex = 3;
            this.studentnumtxt.Text = "Student Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registration";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Library Management System";
            // 
            // emailtxt
            // 
            this.emailtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailtxt.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.Location = new System.Drawing.Point(96, 185);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(2);
            this.emailtxt.Multiline = true;
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(360, 37);
            this.emailtxt.TabIndex = 7;
            this.emailtxt.Text = "Email Address";
            // 
            // nametxt
            // 
            this.nametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nametxt.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(96, 124);
            this.nametxt.Margin = new System.Windows.Forms.Padding(2);
            this.nametxt.Multiline = true;
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(162, 37);
            this.nametxt.TabIndex = 8;
            this.nametxt.Text = "First Name";
            // 
            // Lastnametxt
            // 
            this.Lastnametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lastnametxt.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lastnametxt.Location = new System.Drawing.Point(284, 124);
            this.Lastnametxt.Margin = new System.Windows.Forms.Padding(2);
            this.Lastnametxt.Multiline = true;
            this.Lastnametxt.Name = "Lastnametxt";
            this.Lastnametxt.Size = new System.Drawing.Size(172, 37);
            this.Lastnametxt.TabIndex = 9;
            this.Lastnametxt.Text = "Last Name";
            // 
            // confirmpasstxt
            // 
            this.confirmpasstxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmpasstxt.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpasstxt.Location = new System.Drawing.Point(96, 371);
            this.confirmpasstxt.Margin = new System.Windows.Forms.Padding(2);
            this.confirmpasstxt.Multiline = true;
            this.confirmpasstxt.Name = "confirmpasstxt";
            this.confirmpasstxt.Size = new System.Drawing.Size(360, 40);
            this.confirmpasstxt.TabIndex = 10;
            this.confirmpasstxt.Text = "Confirm Password";
            // 
            // userRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 827);
            this.Controls.Add(this.panel1);
            this.Name = "userRegister";
            this.Text = "userRegister";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linklogintxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox acceptcheck;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.TextBox studentnumtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmpasstxt;
        private System.Windows.Forms.TextBox Lastnametxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox emailtxt;
    }
}