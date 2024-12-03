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
    public partial class UC_Report : UserControl
    {
        public UC_Report()
        {
            InitializeComponent();
        }

        private void pb_search_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_getval_Click(object sender, EventArgs e)
        {
            Student_TBL1TableAdapter students_ada = new Student_TBL1TableAdapter();
            DataTable student_dt = students_ada.GetDataByClassID((string)comboBox1.SelectedValue);
            Attendance_Table2TableAdapter ada = new Attendance_Table2TableAdapter();

            int P = 0;
            int A = 0;
            int L = 0;
            int E = 0;


            foreach (DataRow row in student_dt.Rows)
            {
                P = (int)ada.GetDataByReport(dateTimePicker1.Value.Month, row[1].ToString(), "present").Rows[0][6];

                A = (int)ada.GetDataByReport(dateTimePicker1.Value.Month, row[1].ToString(), "absent").Rows[0][6];

                L = (int)ada.GetDataByReport(dateTimePicker1.Value.Month, row[1].ToString(), "late").Rows[0][6];

                E = (int)ada.GetDataByReport(dateTimePicker1.Value.Month, row[1].ToString(), "excused").Rows[0][6];


                ListViewItem litem = new ListViewItem();

                litem.Text = row[1].ToString();
                litem.SubItems.Add(P.ToString());
                litem.SubItems.Add(A.ToString());
                litem.SubItems.Add(L.ToString());
                litem.SubItems.Add(E.ToString());

            }
        }
    }
}
