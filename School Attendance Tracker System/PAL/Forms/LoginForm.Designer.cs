namespace School_Attendance_Tracker_System.PAL.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.pb_minimize = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Gbtn_login = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainerLog = new System.Windows.Forms.Panel();
            this.Gbtn_Reg = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_close
            // 
            this.pb_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_close.Image = ((System.Drawing.Image)(resources.GetObject("pb_close.Image")));
            this.pb_close.Location = new System.Drawing.Point(1253, 10);
            this.pb_close.Margin = new System.Windows.Forms.Padding(2);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(25, 26);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_close.TabIndex = 0;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            this.pb_close.MouseHover += new System.EventHandler(this.pb_close_MouseHover);
            // 
            // pb_minimize
            // 
            this.pb_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pb_minimize.Image")));
            this.pb_minimize.Location = new System.Drawing.Point(1224, 11);
            this.pb_minimize.Margin = new System.Windows.Forms.Padding(2);
            this.pb_minimize.Name = "pb_minimize";
            this.pb_minimize.Size = new System.Drawing.Size(25, 26);
            this.pb_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_minimize.TabIndex = 0;
            this.pb_minimize.TabStop = false;
            this.pb_minimize.Click += new System.EventHandler(this.pb_minimize_Click);
            this.pb_minimize.MouseHover += new System.EventHandler(this.pb_minimize_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.Gbtn_login);
            this.groupBox1.Controls.Add(this.panelContainerLog);
            this.groupBox1.Controls.Add(this.Gbtn_Reg);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBox1.Location = new System.Drawing.Point(90, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(670, 517);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcome!";
            // 
            // Gbtn_login
            // 
            this.Gbtn_login.Animated = true;
            this.Gbtn_login.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Gbtn_login.CheckedState.FillColor = System.Drawing.Color.RosyBrown;
            this.Gbtn_login.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Gbtn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gbtn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gbtn_login.FillColor = System.Drawing.Color.Maroon;
            this.Gbtn_login.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Gbtn_login.ForeColor = System.Drawing.Color.White;
            this.Gbtn_login.HoverState.CustomBorderColor = System.Drawing.Color.RosyBrown;
            this.Gbtn_login.Location = new System.Drawing.Point(26, 31);
            this.Gbtn_login.Name = "Gbtn_login";
            this.Gbtn_login.Size = new System.Drawing.Size(314, 72);
            this.Gbtn_login.TabIndex = 0;
            this.Gbtn_login.Text = "Login";
            this.Gbtn_login.Click += new System.EventHandler(this.Gbtn_login_Click);
            // 
            // panelContainerLog
            // 
            this.panelContainerLog.Location = new System.Drawing.Point(23, 109);
            this.panelContainerLog.Name = "panelContainerLog";
            this.panelContainerLog.Size = new System.Drawing.Size(632, 400);
            this.panelContainerLog.TabIndex = 5;
            // 
            // Gbtn_Reg
            // 
            this.Gbtn_Reg.Animated = true;
            this.Gbtn_Reg.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Gbtn_Reg.CheckedState.FillColor = System.Drawing.Color.RosyBrown;
            this.Gbtn_Reg.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Gbtn_Reg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_Reg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Gbtn_Reg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Gbtn_Reg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Gbtn_Reg.FillColor = System.Drawing.Color.Maroon;
            this.Gbtn_Reg.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Gbtn_Reg.ForeColor = System.Drawing.Color.White;
            this.Gbtn_Reg.HoverState.CustomBorderColor = System.Drawing.Color.RosyBrown;
            this.Gbtn_Reg.Location = new System.Drawing.Point(340, 31);
            this.Gbtn_Reg.Name = "Gbtn_Reg";
            this.Gbtn_Reg.Size = new System.Drawing.Size(312, 72);
            this.Gbtn_Reg.TabIndex = 1;
            this.Gbtn_Reg.Text = "Register";
            this.Gbtn_Reg.Click += new System.EventHandler(this.Gbtn_Reg_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(842, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 500);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(986, 289);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(942, 509);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Student Attendance Tracker";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.label5.Location = new System.Drawing.Point(1022, 534);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "By Daryl D. Bacusmo";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1289, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_minimize);
            this.Controls.Add(this.pb_close);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.PictureBox pb_minimize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Button Gbtn_Reg;
        private Guna.UI2.WinForms.Guna2Button Gbtn_login;
        private System.Windows.Forms.Panel panelContainerLog;
    }
}