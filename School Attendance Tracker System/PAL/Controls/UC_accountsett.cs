using School_Attendance_Tracker_System.PAL.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace School_Attendance_Tracker_System.PAL.Controls
{

    public partial class UC_accountsett : UserControl
    {
        DataSet1TableAdapters.userSATTableAdapter adapter = new DataSet1TableAdapters.userSATTableAdapter();
        DataSet1.userSATDataTable userData = new DataSet1.userSATDataTable();
        private int loggedInUserID;
        public TextBox username1 => tbx_username;
        public TextBox password1 => tbx_password;
        public TextBox email => tbx_email;
        
        public UC_accountsett(int userID)
        {
            
            InitializeComponent();
            this.loggedInUserID = userID;
            LoadUserData();


        }

        private void LoadUserData()
        {
            // Fetch user data based on UserID
            DataSet1.userSATDataTable userData = adapter.GetDataByUserID(loggedInUserID);

            // Display user data in text boxes
            if (userData.Rows.Count > 0)
            {
                tbx_username.Text = userData[0].username;
                tbx_password.Text = userData[0].password;
                tbx_email.Text = userData[0].email;
            }
            else
            {
                // Handle the case where no user was found
                MessageBox.Show("No user found with the provided UserID.");
            }
        }

        private void UC_accountsett_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            // Update the user's account
            string username = tbx_username.Text;
            string password = tbx_password.Text;
            string email = tbx_email.Text;

            DataSet1.userSATDataTable userData = adapter.GetDataByUserID(loggedInUserID);

            if (userData.Rows.Count > 0)
            {
                // Update the DataRow with the new values
                userData[0].username = username;
                userData[0].password = password;
                userData[0].email = email;

                // Save changes back to the database
                adapter.Update(userData);
                MessageBox.Show("Account updated successfully.");

            }
            else
            {
                MessageBox.Show("No user found with the provided UserID.");
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        { 
            DataSet1.userSATDataTable userData = adapter.GetDataByUserID(loggedInUserID);

            if (userData.Rows.Count > 0)
            {
                string originalUsername = userData[0].username; 

                
                adapter.Delete(loggedInUserID, originalUsername, userData[0].password, userData[0].email, userData[0].role);

                MessageBox.Show("Account deleted successfully.");

                
            }
            else
            {
                MessageBox.Show("No user found with the provided UserID.");
            }
        }
    }
}
