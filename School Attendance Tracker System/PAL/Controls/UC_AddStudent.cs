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
    public partial class UC_AddStudent : UserControl
    {
       
        private int loggedinUser;
        public int ClassID { get; set; }
        public string ClassName { get; set; } 
        DataSet1TableAdapters.Student_TBL1TableAdapter ada = new DataSet1TableAdapters.Student_TBL1TableAdapter();
        public UC_AddStudent(int userID)
        {
            InitializeComponent();
            this.loggedinUser = userID;
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_addStudent_Click(object sender, EventArgs e)
        {
            




        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void UC_AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            this.studentTBL1BindingSource.EndEdit();
            this.student_TBL1TableAdapter.Update(dataSet1.Student_TBL1);
            MessageBox.Show("Student added successfully.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
