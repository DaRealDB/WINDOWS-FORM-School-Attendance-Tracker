using School_Attendance_Tracker_System.DataSet1TableAdapters;
using School_Attendance_Tracker_System.PAL.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Attendance_Tracker_System.PAL.Controls
{
    public partial class UC_Login : UserControl
    {
        public bool loginFlag { get; set; }
        public int UserID { get; set; }
        public TextBox uname => txb_username;
        public TextBox pass => txb_pass;

        private int loggedinUser;
        private string userEmail;
        public UC_Login(int userID)
        {
            InitializeComponent();
            this.UserID = userID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            DataSet1TableAdapters.userSATTableAdapter adapter = new DataSet1TableAdapters.userSATTableAdapter();

            DataTable dt = adapter.GetDataByGetUserandPass(txb_username.Text, txb_pass.Text);


            if (dt.Rows.Count > 0)
            {
                string role = dt.Rows[0]["Role"].ToString();
                UserID = int.Parse(dt.Rows[0]["UserID"].ToString());
                loginFlag = true;
                MainForm mainForm = new MainForm(txb_username.Text, role, UserID);
                mainForm.username = txb_username.Text;
                txb_username.Clear();
                txb_pass.Clear();
                pbx_hide_Click(sender, e);
                txb_username.Focus();
                pb_error.Hide();
                pb_error.Hide();
                mainForm.ShowDialog();
            }
            else
            {
                pb_error.Show();
                lbl_error.Show();
                loginFlag = false;
            }
        }

        private void pbx_hide_Click(object sender, EventArgs e)
        {
            txb_pass.UseSystemPasswordChar = true;
            pb_show.Show();
            pbx_hide.Hide();
        }

        private void pb_show_Click(object sender, EventArgs e)
        {
            txb_pass.UseSystemPasswordChar = false;
            pb_show.Hide();
            pbx_hide.Show();
        }

        private void UC_Login_Load(object sender, EventArgs e)
        {
            pbx_hide.Hide();
            pb_error.Hide();
            lbl_error.Hide();
            txb_pass.UseSystemPasswordChar=true;
        }

        private void pbx_hide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pb_show, "Show password");
        }

        private void pb_show_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pbx_hide, "Hide password");
        }

        private void txb_username_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txb_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void txb_pass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txb_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_login.PerformClick();
                e.Handled = true;
            }
        }

        private void lbl_forgotpass_Click(object sender, EventArgs e)
        {
            string userEmail = ""; // Initialize userEmail variable or get it from your application logic

            ForgetPass forgetpass = new ForgetPass(userEmail);
            forgetpass.ShowDialog();
        }
    }
}
