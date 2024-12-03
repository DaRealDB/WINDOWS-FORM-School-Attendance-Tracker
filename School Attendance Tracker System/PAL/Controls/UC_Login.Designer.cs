namespace School_Attendance_Tracker_System.PAL.Controls
{
    partial class UC_Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Login));
            this.txb_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbx_hide = new System.Windows.Forms.PictureBox();
            this.pb_show = new System.Windows.Forms.PictureBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_forgotpass = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.pb_error = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_error)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_username
            // 
            this.txb_username.Location = new System.Drawing.Point(115, 59);
            this.txb_username.Margin = new System.Windows.Forms.Padding(2);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(265, 20);
            this.txb_username.TabIndex = 1;
            this.txb_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_username_KeyPress);
            this.txb_username.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txb_username_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(112, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // txb_pass
            // 
            this.txb_pass.Location = new System.Drawing.Point(115, 120);
            this.txb_pass.Margin = new System.Windows.Forms.Padding(2);
            this.txb_pass.Name = "txb_pass";
            this.txb_pass.Size = new System.Drawing.Size(241, 20);
            this.txb_pass.TabIndex = 1;
            this.txb_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_pass_KeyPress);
            this.txb_pass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txb_pass_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(112, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // pbx_hide
            // 
            this.pbx_hide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_hide.Image = ((System.Drawing.Image)(resources.GetObject("pbx_hide.Image")));
            this.pbx_hide.Location = new System.Drawing.Point(355, 120);
            this.pbx_hide.Margin = new System.Windows.Forms.Padding(2);
            this.pbx_hide.Name = "pbx_hide";
            this.pbx_hide.Size = new System.Drawing.Size(25, 20);
            this.pbx_hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_hide.TabIndex = 0;
            this.pbx_hide.TabStop = false;
            this.pbx_hide.Click += new System.EventHandler(this.pbx_hide_Click);
            this.pbx_hide.MouseHover += new System.EventHandler(this.pbx_hide_MouseHover);
            // 
            // pb_show
            // 
            this.pb_show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_show.Image = ((System.Drawing.Image)(resources.GetObject("pb_show.Image")));
            this.pb_show.Location = new System.Drawing.Point(355, 120);
            this.pb_show.Margin = new System.Windows.Forms.Padding(2);
            this.pb_show.Name = "pb_show";
            this.pb_show.Size = new System.Drawing.Size(25, 20);
            this.pb_show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_show.TabIndex = 0;
            this.pb_show.TabStop = false;
            this.pb_show.Click += new System.EventHandler(this.pb_show_Click);
            this.pb_show.MouseHover += new System.EventHandler(this.pb_show_MouseHover);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Maroon;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.Snow;
            this.btn_login.Location = new System.Drawing.Point(200, 181);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(73, 23);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_forgotpass
            // 
            this.lbl_forgotpass.AutoSize = true;
            this.lbl_forgotpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_forgotpass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_forgotpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_forgotpass.Location = new System.Drawing.Point(187, 163);
            this.lbl_forgotpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_forgotpass.Name = "lbl_forgotpass";
            this.lbl_forgotpass.Size = new System.Drawing.Size(118, 16);
            this.lbl_forgotpass.TabIndex = 0;
            this.lbl_forgotpass.Text = "Forgot Password?";
            this.lbl_forgotpass.Click += new System.EventHandler(this.lbl_forgotpass_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbl_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.lbl_error.Location = new System.Drawing.Point(165, 146);
            this.lbl_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(183, 17);
            this.lbl_error.TabIndex = 0;
            this.lbl_error.Text = "Invalid Username or Password";
            // 
            // pb_error
            // 
            this.pb_error.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_error.Image = ((System.Drawing.Image)(resources.GetObject("pb_error.Image")));
            this.pb_error.Location = new System.Drawing.Point(136, 144);
            this.pb_error.Margin = new System.Windows.Forms.Padding(2);
            this.pb_error.Name = "pb_error";
            this.pb_error.Size = new System.Drawing.Size(25, 19);
            this.pb_error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_error.TabIndex = 0;
            this.pb_error.TabStop = false;
            // 
            // UC_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txb_username);
            this.Controls.Add(this.pb_error);
            this.Controls.Add(this.lbl_forgotpass);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txb_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbx_hide);
            this.Controls.Add(this.pb_show);
            this.Name = "UC_Login";
            this.Size = new System.Drawing.Size(632, 325);
            this.Load += new System.EventHandler(this.UC_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbx_hide;
        private System.Windows.Forms.PictureBox pb_show;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_forgotpass;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.PictureBox pb_error;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
