using School_Attendance_Tracker_System.DataSet1TableAdapters;
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
    public partial class UC_Dashboard : UserControl
    {
        private int userID;
        DataSet1TableAdapters.Add_ClassSATTableAdapter dataTableAdapter = new DataSet1TableAdapters.Add_ClassSATTableAdapter();
        DataSet1TableAdapters.Student_TBL1TableAdapter ada = new DataSet1TableAdapters.Student_TBL1TableAdapter();
        private string role;
        public UC_Dashboard(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            this.role = role;
            ControlVis();
        }



        private void UC_Dashboard_Load(object sender, EventArgs e)
        {


        }

        private void ControlVis()
        {
            if (role == "Student")
            {
                lbl_stude.Hide();
            }
        }

    }
}
