using School_Attendance_Tracker_System.PAL.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace School_Attendance_Tracker_System.PAL.Forms
{
    public partial class MainForm : Form
    {
        DataSet1TableAdapters.userSATTableAdapter adapter = new DataSet1TableAdapters.userSATTableAdapter();
        DataSet1.userSATDataTable userData = new DataSet1.userSATDataTable();
        private int loggedInUserID;
        public string username;
        private string role;
        private UC_Attendance ucAttendance;

        public int UserID { get; set; }
        
        public MainForm(string username, string role, int userID)
        {
            InitializeComponent();
            time_dateandtime.Start();
            this.username = username;
            this.role = role;
            this.loggedInUserID = userID;
           
          
            ControlVisibility();
        }

      

        private void ControlVisibility()
        {
            // Assuming you have buttons for various functions
            // Hide or show buttons based on the user's role
            if (role == "Student")
            {
                // Hide buttons for functions that should be hidden for students
                gbtn_addclass.Hide();
                gbtn_addstudent.Hide();

                
           
                
                // Hide other buttons as needed
            }
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Dashboard dashboard = new UC_Dashboard(loggedInUserID);
            addUserControl(dashboard);
           
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_Attendance attendance = new UC_Attendance(loggedInUserID);
            addUserControl(attendance);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_AddClass addclass = new UC_AddClass(loggedInUserID);
            addUserControl(addclass);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UC_AddStudent addstudent = new UC_AddStudent(loggedInUserID);
            addUserControl(addstudent);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            UC_Report rep = new UC_Report();
            addUserControl(rep);
        }

        private void pbx_logout_Click(object sender, EventArgs e)
        {
            if (panel_side.Visible)
            {
                panel_side.Visible = false;
            }
            else
            {
                panel_side.Visible =true; 
            }
        }

        private void pbx_logout_MouseHover(object sender, EventArgs e)
        {
           
           
         

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                time_dateandtime.Stop();
                Close();
            }
            else
            {
                panel_side.Hide();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panel_side.Hide();
            lbl_username.Text = username;

        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            
            int userID = loggedInUserID;
            panel_side.Hide();
            UC_accountsett accsett = new UC_accountsett(userID);
            addUserControl(accsett);

            UC_Login uname1 = new UC_Login(loggedInUserID);
            TextBox uname2 = uname1.uname;
            UC_Login pass1 = new UC_Login(loggedInUserID);
            TextBox pass2 = pass1.pass;
            UC_Reg email1 = new UC_Reg();
            TextBox email2 = email1.email;
            UC_accountsett accountsett = new UC_accountsett(userID);
            TextBox name = accountsett.username1;
            TextBox password = accountsett.password1;
            TextBox gmail = accountsett.email;


            string username = uname2.Text;
            string password1 = pass2.Text;
            string gmail1 = email2.Text;


            DataSet1.userSATDataTable userData = adapter.GetDataByGetUserandPass(username, password1);
            adapter.FillByGetUserandPass(userData, username, password1);


    

        }

        private void time_dateandtime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lbl_time.Text = now.ToString("F");
        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
           UC_Login newlog = new UC_Login(loggedInUserID);

            UserID = newlog.UserID;

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
