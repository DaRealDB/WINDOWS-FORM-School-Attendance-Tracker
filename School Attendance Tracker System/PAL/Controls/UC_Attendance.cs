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
    public partial class UC_Attendance : UserControl
    {


        private int loggedinUser;

        public ComboBox cb_att => comboBox1;
        public UC_Attendance(int userID)
        {
            InitializeComponent();
            this.loggedinUser = userID;
            LoadClasses();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadClasses()
        {
            // Apply filter to show only classes related to the logged-in user
            this.add_ClassSATTableAdapter.FillByUserID(this.dataSet1.Add_ClassSAT, loggedinUser);
        }

        private void tp_Mark_Click(object sender, EventArgs e)
        {
            UC_AddStudent add = new UC_AddStudent(loggedinUser);
            add.ClassName = cb_att.Text;
            add.ClassID = (int)cb_att.SelectedValue;
        }

        private void UC_Attendance_Load(object sender, EventArgs e)
        {


        }

        private void Btn_rec_Click(object sender, EventArgs e)
        {
            Attendance_Table2TableAdapter ada = new Attendance_Table2TableAdapter();
            DataTable dt = ada.GetDataBy((string)comboBox1.SelectedValue, dateTimePicker1.Text);

            if (dt.Rows.Count > 0)
            {
                DataTable dt_new = ada.GetDataBy((string)comboBox1.SelectedValue, dateTimePicker1.Text);
                dgv_class.DataSource = dt_new;
            }
            else
            {
                Student_TBL1TableAdapter students_ada = new Student_TBL1TableAdapter();
                DataTable student_dt = students_ada.GetDataByClassID((string)comboBox1.SelectedValue);

                foreach (DataRow row in student_dt.Rows)
                {
                    ada.InsertQuery((int)row[0], comboBox1.SelectedValue.ToString(), dateTimePicker1.Text, "", row[1].ToString());
                }


                DataTable dt_new = ada.GetDataBy((string)comboBox1.SelectedValue, dateTimePicker1.Text);
                dgv_class.DataSource = dt_new;
            }



        }

        private void dgv_class_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_record_Click(object sender, EventArgs e)
        {
            Attendance_Table2TableAdapter ada = new Attendance_Table2TableAdapter();

            foreach (DataGridViewRow row in dgv_class.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    ada.UpdateQuery(row.Cells[1].Value.ToString(), row.Cells[0].Value.ToString(), comboBox1.SelectedValue.ToString(), dateTimePicker1.Text);

                }

            }

            DataTable dt_new = ada.GetDataBy((string)comboBox1.SelectedValue, dateTimePicker1.Text);
            dgv_class.DataSource = dt_new;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_TBL1TableAdapter students_ada = new Student_TBL1TableAdapter();
            DataTable student_dt = students_ada.GetDataByClassID((string)comboBox3.SelectedValue);
            Attendance_Table2TableAdapter ada = new Attendance_Table2TableAdapter();

            int P = 0;
            int A = 0;
            int L = 0;
            int E = 0;


            foreach (DataRow row in student_dt.Rows)
            {
                P = (int)ada.GetDataByReport(dateTimePicker3.Value.Month, row[1].ToString(), "present").Rows[0][6];

                A = (int)ada.GetDataByReport(dateTimePicker3.Value.Month, row[1].ToString(), "late").Rows[0][6];

                L = (int)ada.GetDataByReport(dateTimePicker3.Value.Month, row[1].ToString(), "absent").Rows[0][6];

                E = (int)ada.GetDataByReport(dateTimePicker3.Value.Month, row[1].ToString(), "excused").Rows[0][6];


                ListViewItem litem = new ListViewItem();

                litem.Text = row[1].ToString();
                litem.SubItems.Add(P.ToString());
                litem.SubItems.Add(A.ToString());
                litem.SubItems.Add(L.ToString());
                litem.SubItems.Add(E.ToString());
                listView1.Items.Add(litem);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
