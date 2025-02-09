namespace Library_Management_System
{
    partial class userdashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.TrendingBtn = new System.Windows.Forms.Button();
            this.TimelineBtn = new System.Windows.Forms.Button();
            this.yourlibrarybtn = new System.Windows.Forms.Button();
            this.dashboardbtn = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 956);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(262, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(936, 76);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.TrendingBtn);
            this.panel2.Controls.Add(this.TimelineBtn);
            this.panel2.Controls.Add(this.yourlibrarybtn);
            this.panel2.Controls.Add(this.dashboardbtn);
            this.panel2.Controls.Add(this.user);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 956);
            this.panel2.TabIndex = 0;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(64, 863);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(74, 28);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Log Out";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(64, 814);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(50, 28);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Help";
            // 
            // TrendingBtn
            // 
            this.TrendingBtn.BackColor = System.Drawing.Color.White;
            this.TrendingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TrendingBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrendingBtn.Location = new System.Drawing.Point(27, 397);
            this.TrendingBtn.Name = "TrendingBtn";
            this.TrendingBtn.Size = new System.Drawing.Size(210, 35);
            this.TrendingBtn.TabIndex = 5;
            this.TrendingBtn.Text = "Trending";
            this.TrendingBtn.UseVisualStyleBackColor = false;
            // 
            // TimelineBtn
            // 
            this.TimelineBtn.BackColor = System.Drawing.Color.White;
            this.TimelineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TimelineBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimelineBtn.Location = new System.Drawing.Point(27, 309);
            this.TimelineBtn.Name = "TimelineBtn";
            this.TimelineBtn.Size = new System.Drawing.Size(210, 35);
            this.TimelineBtn.TabIndex = 4;
            this.TimelineBtn.Text = "Timeline";
            this.TimelineBtn.UseVisualStyleBackColor = false;
            this.TimelineBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // yourlibrarybtn
            // 
            this.yourlibrarybtn.BackColor = System.Drawing.Color.White;
            this.yourlibrarybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yourlibrarybtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourlibrarybtn.Location = new System.Drawing.Point(27, 223);
            this.yourlibrarybtn.Name = "yourlibrarybtn";
            this.yourlibrarybtn.Size = new System.Drawing.Size(210, 35);
            this.yourlibrarybtn.TabIndex = 3;
            this.yourlibrarybtn.Text = "Your Library";
            this.yourlibrarybtn.UseVisualStyleBackColor = false;
            // 
            // dashboardbtn
            // 
            this.dashboardbtn.BackColor = System.Drawing.Color.White;
            this.dashboardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dashboardbtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardbtn.Location = new System.Drawing.Point(27, 139);
            this.dashboardbtn.Name = "dashboardbtn";
            this.dashboardbtn.Size = new System.Drawing.Size(210, 35);
            this.dashboardbtn.TabIndex = 2;
            this.dashboardbtn.Text = "Dashboard";
            this.dashboardbtn.UseVisualStyleBackColor = false;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(95, 24);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(62, 34);
            this.user.TabIndex = 1;
            this.user.Text = "USER";
            // 
            // userdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 956);
            this.Controls.Add(this.panel1);
            this.Name = "userdashboard";
            this.Text = "userdashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button TrendingBtn;
        private System.Windows.Forms.Button TimelineBtn;
        private System.Windows.Forms.Button yourlibrarybtn;
        private System.Windows.Forms.Button dashboardbtn;
    }
}