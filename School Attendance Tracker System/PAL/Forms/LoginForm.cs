using School_Attendance_Tracker_System.PAL.Controls;
using School_Attendance_Tracker_System.PAL.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Attendance_Tracker_System.PAL.Forms
{
    public partial class LoginForm : Form
    {
        public bool loginFlag { get; set; }
        private int loggedinUser;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pb_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pbx_show_MouseHover(object sender, EventArgs e)
        {
        }

        private void pbx_hide_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pbx_show_Click(object sender, EventArgs e)
        {
            
        }

        private void pbx_hide_Click(object sender, EventArgs e)
        {

         
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void pb_close_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pb_close, "Close");
        }

        private void pb_minimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pb_minimize, "Minimize");

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
        }

        private void txb_username_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txb_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txb_pass_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txb_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void lbl_fp_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainerLog.Controls.Clear();
            panelContainerLog.Controls.Add(userControl);
        }

        private void Gbtn_login_Click(object sender, EventArgs e)
        {
            UC_Login log = new UC_Login(loggedinUser);
            addUserControl(log);
        }

        private void Gbtn_Reg_Click(object sender, EventArgs e)
        {
            UC_Reg reg1 = new UC_Reg();
            addUserControl(reg1);
        }
    }
}
