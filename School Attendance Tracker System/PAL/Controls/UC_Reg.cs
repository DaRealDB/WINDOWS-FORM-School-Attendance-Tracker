using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.OleDb;
using School_Attendance_Tracker_System.DataSet1TableAdapters;
using School_Attendance_Tracker_System.PAL.Forms;

namespace School_Attendance_Tracker_System.PAL.Controls
{
    public partial class UC_Reg : UserControl
    {
        

        public TextBox email => tbx_email;
        public UC_Reg()
        {
            InitializeComponent();
        }

        
        private void UC_Reg_Load(object sender, EventArgs e)
        {
            lbl_error4.Hide();
            lbl_error1.Hide();
            lbl_error2.Hide();
            lbl_error3.Hide();
            tbx_pass1.UseSystemPasswordChar = true;
            tbx_pass2.UseSystemPasswordChar = true;
        }

        private void btn_reg2_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.userSATTableAdapter adapter = new DataSet1TableAdapters.userSATTableAdapter();
            DataTable existingUser = adapter.GetDataByGetUserandPass(tbx_username1.Text, tbx_pass1.Text);


            if (existingUser.Rows.Count > 0)
            {
                MessageBox.Show("Username already exist. Please try a new username.");
            }
            else
            {
                // Retrieve username, password, and confirm password from textboxes
                string username = tbx_username1.Text;
                string email = tbx_email.Text;
                string password = tbx_pass1.Text;
                string confirmpass = tbx_pass2.Text;
                string role = "";

               
                if (rb_admin.Checked)
                {
                     role = rb_admin.Text;
                }else if (rb_student.Checked)
                {
                     role = rb_student.Text;
                }

                // Check if username, password, and confirm password fields are empty
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmpass) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Username, Password and email fields cannot be empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbl_error1.Show();
                    lbl_error2.Show();
                    lbl_error3.Show();
                    lbl_error4.Show();
                }
                // Check if password and confirm password match
                else if (password != confirmpass)
                {
                    MessageBox.Show("Passwords do not match");
                    lbl_error2.Show();
                    lbl_error3.Show();
                    tbx_pass1.Clear();
                    tbx_pass2.Clear();
                }
                else
                {
                    try
                    {
                        adapter.Insert(username, password, email, role);

                        MessageBox.Show("Registration successful!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error! Please Try Again.", ex.Message);
                    }
                }
            }

        }

        private void gbtn_Clear_Click(object sender, EventArgs e)
        {
            tbx_pass1.Clear();
            tbx_pass2.Clear();
            tbx_username1.Clear();
        }

        private void tbx_pass1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_SP.Checked)
            {
                tbx_pass1.UseSystemPasswordChar = false;
                tbx_pass2.UseSystemPasswordChar = false;
            }
            else
            {
                tbx_pass1.UseSystemPasswordChar = true;
                tbx_pass2.UseSystemPasswordChar = true;
            }
            
        }

        private void lbl_error4_Click(object sender, EventArgs e)
        {

        }
    }
}
