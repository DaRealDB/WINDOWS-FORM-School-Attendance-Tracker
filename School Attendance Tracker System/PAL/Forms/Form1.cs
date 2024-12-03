using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace School_Attendance_Tracker_System.PAL.Forms
{
    public partial class ResetPass : Form
    {
        DataSet1TableAdapters.userSATTableAdapter adapter = new DataSet1TableAdapters.userSATTableAdapter();
        DataSet1.userSATDataTable userData = new DataSet1.userSATDataTable();
        
        public ResetPass(string userEmail)
        {
            InitializeComponent();
            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            string password = tbx_pass1.Text;
            string confirmpass = tbx_conpass.Text;
            string uname = tbx_uname.Text;

            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmpass))
            {
                MessageBox.Show("Fields cannot be empty", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            // Check if password and confirm password match
            else if (password != confirmpass)
            {
                MessageBox.Show("Passwords do not match");

            }
            else
            {
                try
                {
                    adapter.UpdateQuery1(password, uname);
                    MessageBox.Show("Password reset successfully.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error! Please Try Again.", ex.Message);
                }
            }



        }
    }
}
