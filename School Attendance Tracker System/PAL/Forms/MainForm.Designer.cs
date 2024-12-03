namespace School_Attendance_Tracker_System.PAL.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_side = new System.Windows.Forms.Panel();
            this.btn_logout = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_expand = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_minimize = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbtn_addstudent = new Guna.UI2.WinForms.Guna2Button();
            this.gbtn_addclass = new Guna.UI2.WinForms.Guna2Button();
            this.gbtn_Attendance = new Guna.UI2.WinForms.Guna2Button();
            this.gbtn_dash = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.time_dateandtime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel_side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_expand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.panel_side);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Controls.Add(this.lbl_username);
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pb_expand);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 71);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_side
            // 
            this.panel_side.BackColor = System.Drawing.Color.DarkRed;
            this.panel_side.Controls.Add(this.btn_logout);
            this.panel_side.Controls.Add(this.panel4);
            this.panel_side.Location = new System.Drawing.Point(1078, 4);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(119, 69);
            this.panel_side.TabIndex = 5;
            this.panel_side.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn_logout
            // 
            this.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logout.FillColor = System.Drawing.Color.RosyBrown;
            this.btn_logout.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.Location = new System.Drawing.Point(3, 37);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(113, 26);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "Logout";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(119, 34);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Salmon;
            this.guna2Panel1.Location = new System.Drawing.Point(430, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(5, 85);
            this.guna2Panel1.TabIndex = 3;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(541, 9);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(28, 19);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "{?}";
            this.lbl_username.Click += new System.EventHandler(this.lbl_username_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_time.ForeColor = System.Drawing.Color.White;
            this.lbl_time.Location = new System.Drawing.Point(450, 42);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(28, 19);
            this.lbl_time.TabIndex = 2;
            this.lbl_time.Text = "{?}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(450, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(109, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Student Attendance Tracker";
            // 
            // pb_expand
            // 
            this.pb_expand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_expand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_expand.Image = ((System.Drawing.Image)(resources.GetObject("pb_expand.Image")));
            this.pb_expand.Location = new System.Drawing.Point(1100, 20);
            this.pb_expand.Margin = new System.Windows.Forms.Padding(2);
            this.pb_expand.Name = "pb_expand";
            this.pb_expand.Size = new System.Drawing.Size(30, 30);
            this.pb_expand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_expand.TabIndex = 1;
            this.pb_expand.TabStop = false;
            this.pb_expand.Click += new System.EventHandler(this.pbx_logout_Click);
            this.pb_expand.MouseHover += new System.EventHandler(this.pbx_logout_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_minimize
            // 
            this.Btn_minimize.CheckedState.CustomBorderColor = System.Drawing.Color.Maroon;
            this.Btn_minimize.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Btn_minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_minimize.FillColor = System.Drawing.Color.White;
            this.Btn_minimize.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Btn_minimize.ForeColor = System.Drawing.Color.IndianRed;
            this.Btn_minimize.HoverState.CustomBorderColor = System.Drawing.Color.Maroon;
            this.Btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("Btn_minimize.Image")));
            this.Btn_minimize.Location = new System.Drawing.Point(876, 5);
            this.Btn_minimize.Name = "Btn_minimize";
            this.Btn_minimize.Size = new System.Drawing.Size(143, 53);
            this.Btn_minimize.TabIndex = 0;
            this.Btn_minimize.Text = "AccSettings";
            this.Btn_minimize.Click += new System.EventHandler(this.Btn_minimize_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_minimize);
            this.panel2.Controls.Add(this.gbtn_addstudent);
            this.panel2.Controls.Add(this.gbtn_addclass);
            this.panel2.Controls.Add(this.gbtn_Attendance);
            this.panel2.Controls.Add(this.gbtn_dash);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 64);
            this.panel2.TabIndex = 1;
            // 
            // gbtn_addstudent
            // 
            this.gbtn_addstudent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gbtn_addstudent.CheckedState.CustomBorderColor = System.Drawing.Color.Maroon;
            this.gbtn_addstudent.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.gbtn_addstudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_addstudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_addstudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_addstudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_addstudent.FillColor = System.Drawing.Color.White;
            this.gbtn_addstudent.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtn_addstudent.ForeColor = System.Drawing.Color.IndianRed;
            this.gbtn_addstudent.HoverState.CustomBorderColor = System.Drawing.Color.Maroon;
            this.gbtn_addstudent.Image = ((System.Drawing.Image)(resources.GetObject("gbtn_addstudent.Image")));
            this.gbtn_addstudent.Location = new System.Drawing.Point(671, 3);
            this.gbtn_addstudent.Name = "gbtn_addstudent";
            this.gbtn_addstudent.Size = new System.Drawing.Size(171, 53);
            this.gbtn_addstudent.TabIndex = 3;
            this.gbtn_addstudent.Text = "Add Student";
            this.gbtn_addstudent.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // gbtn_addclass
            // 
            this.gbtn_addclass.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gbtn_addclass.CheckedState.CustomBorderColor = System.Drawing.Color.Maroon;
            this.gbtn_addclass.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.gbtn_addclass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_addclass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_addclass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_addclass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_addclass.FillColor = System.Drawing.Color.White;
            this.gbtn_addclass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtn_addclass.ForeColor = System.Drawing.Color.IndianRed;
            this.gbtn_addclass.HoverState.CustomBorderColor = System.Drawing.Color.Maroon;
            this.gbtn_addclass.Image = ((System.Drawing.Image)(resources.GetObject("gbtn_addclass.Image")));
            this.gbtn_addclass.Location = new System.Drawing.Point(482, 5);
            this.gbtn_addclass.Name = "gbtn_addclass";
            this.gbtn_addclass.Size = new System.Drawing.Size(163, 53);
            this.gbtn_addclass.TabIndex = 2;
            this.gbtn_addclass.Text = "Add Class";
            this.gbtn_addclass.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // gbtn_Attendance
            // 
            this.gbtn_Attendance.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gbtn_Attendance.CheckedState.CustomBorderColor = System.Drawing.Color.Maroon;
            this.gbtn_Attendance.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.gbtn_Attendance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Attendance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Attendance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_Attendance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_Attendance.FillColor = System.Drawing.Color.White;
            this.gbtn_Attendance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtn_Attendance.ForeColor = System.Drawing.Color.IndianRed;
            this.gbtn_Attendance.HoverState.CustomBorderColor = System.Drawing.Color.Maroon;
            this.gbtn_Attendance.Image = ((System.Drawing.Image)(resources.GetObject("gbtn_Attendance.Image")));
            this.gbtn_Attendance.Location = new System.Drawing.Point(312, 5);
            this.gbtn_Attendance.Name = "gbtn_Attendance";
            this.gbtn_Attendance.Size = new System.Drawing.Size(148, 53);
            this.gbtn_Attendance.TabIndex = 1;
            this.gbtn_Attendance.Text = "Attendance";
            this.gbtn_Attendance.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // gbtn_dash
            // 
            this.gbtn_dash.BackColor = System.Drawing.Color.White;
            this.gbtn_dash.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gbtn_dash.CheckedState.CustomBorderColor = System.Drawing.Color.Maroon;
            this.gbtn_dash.CustomBorderColor = System.Drawing.Color.White;
            this.gbtn_dash.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.gbtn_dash.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_dash.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_dash.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_dash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_dash.FillColor = System.Drawing.Color.White;
            this.gbtn_dash.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtn_dash.ForeColor = System.Drawing.Color.IndianRed;
            this.gbtn_dash.HoverState.CustomBorderColor = System.Drawing.Color.Maroon;
            this.gbtn_dash.Image = ((System.Drawing.Image)(resources.GetObject("gbtn_dash.Image")));
            this.gbtn_dash.Location = new System.Drawing.Point(84, 5);
            this.gbtn_dash.Name = "gbtn_dash";
            this.gbtn_dash.Size = new System.Drawing.Size(139, 53);
            this.gbtn_dash.TabIndex = 0;
            this.gbtn_dash.Text = "Dashboard";
            this.gbtn_dash.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 135);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1200, 585);
            this.panelContainer.TabIndex = 2;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // time_dateandtime
            // 
            this.time_dateandtime.Tick += new System.EventHandler(this.time_dateandtime_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_side.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_expand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button gbtn_dash;
        private Guna.UI2.WinForms.Guna2Button gbtn_addstudent;
        private Guna.UI2.WinForms.Guna2Button gbtn_addclass;
        private Guna.UI2.WinForms.Guna2Button gbtn_Attendance;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.PictureBox pb_expand;
        private System.Windows.Forms.Panel panel_side;
        private Guna.UI2.WinForms.Guna2Button btn_logout;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button Btn_minimize;
        private System.Windows.Forms.Timer time_dateandtime;
    }
}