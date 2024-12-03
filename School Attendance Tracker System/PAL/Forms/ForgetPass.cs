using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Attendance_Tracker_System.PAL.Forms
{
    public partial class ForgetPass : Form
    {
        string randomcode;
        public static string to;
        private string userEmail;
        
        public ForgetPass(string userEmail)
        {
            InitializeComponent();
            this.userEmail = userEmail;
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string from, pass, messagebody;
            Random rand = new Random();
            randomcode = (rand.Next(999999)).ToString();

            MailMessage message = new MailMessage();
            to = (tbx_email.Text).ToString();
            from = "vcodesender4@gmail.com";
            pass = "ifmp myvi gubk qdzt";
            messagebody = $"Here's your reset code:{randomcode}";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messagebody;
            message.Subject = "Password Reset Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from,pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Code sent successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ForgetPass_Load(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (randomcode == (tbx_vcode.Text).ToString())
            {
                to = tbx_email.Text;
                ResetPass rp = new ResetPass(userEmail);
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Invalid Code, Please Try Again");
            }
        }
    }
}
