using Microsoft.Identity.Client;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace School_Attendance_Tracker_System.PAL.Controls
{
    public partial class UC_AddClass : UserControl
    {
        //private DataSet1TableAdapters.AddClassDBTableAdapter dataTableAdapter;
        DataSet1TableAdapters.Add_ClassSATTableAdapter dataTableAdapter = new DataSet1TableAdapters.Add_ClassSATTableAdapter();
        private int loggedInUserID { get; set; }
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public UC_AddClass(int userID)
        {
            InitializeComponent();
            //  dataTableAdapter = new DataSet1TableAdapters.AddClassDBTableAdapter();
            this.loggedInUserID = userID;
            LoadClasses();
        }

        private void LoadClasses()
        {
            // Apply filter to show only classes related to the logged-in user
            this.add_ClassSATTableAdapter.FillByUserID(this.dataSet1.Add_ClassSAT, loggedInUserID);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void Btn_add_Click(object sender, EventArgs e)
        {


            UC_Login newlog = new UC_Login(loggedInUserID);


            string className = txbac_name.Text;
            int classTotal = Convert.ToInt32(txbac_quantity.Text);
            int classMale = Convert.ToInt32(txbac_male.Text);
            int classFemale = Convert.ToInt32(txbac_female.Text);



            try
            {
                // Call the method of the DataTableAdapter to add the class to the database

                dataTableAdapter.addclass(className, classTotal, classMale, classFemale, loggedInUserID);

                MessageBox.Show("Class added successfully.");


                // Optionally, clear the text boxes or close the form after adding the class
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding class: " + ex.Message);
            }
        }

        private void ClearTextBoxes()
        {
            // Clear all text boxes
            txbac_name.Text = "";
            txbac_quantity.Text = "";
            txbac_male.Text = "";
            txbac_female.Text = "";
        }

        private void pb_search_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Add_ClassSATTableAdapter ada = new Add_ClassSATTableAdapter();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    ada.UpdateQuery(
    row.Cells[0].Value.ToString(),              // @Class_name
    (int)row.Cells[1].Value,                    // @Class_total
    (int)row.Cells[2].Value,                    // @Class_female
    (int)row.Cells[3].Value,                    // @Class_male
    row.Cells[0].Value.ToString()               // @OldClassName
);
                }

            }

            DataTable dt_new = ada.GetDataByClass((string)comboboxedit.SelectedValue);
            dataGridView1.DataSource = dt_new;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

                // Retrieve the class name from the selected row
                string className = selectedRow.Cells[0].Value.ToString();

                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to delete this class?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Call the delete method from your table adapter
                    dataTableAdapter.DeleteQuery(className);

                    // Refresh the DataGridView to reflect the changes
                    dataGridView1.Rows.RemoveAt(rowIndex);
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = dataTableAdapter.GetDataByClass(comboboxedit.SelectedValue.ToString());
            if (dt.Rows.Count > 0)
            {
                DataTable dt_new = dataTableAdapter.GetDataByClass((string)comboboxedit.SelectedValue);
                dataGridView1.DataSource = dt_new;
            }
            else
            {

                DataTable student_dt = dataTableAdapter.GetDataByClass((string)comboboxedit.SelectedValue);

                foreach (DataRow row in student_dt.Rows)
                {
                    dataTableAdapter.InsertQuery(row[0].ToString(), (int)comboboxedit.SelectedValue, (int)row[1], (int)row[2], (int)row[3]);
                }


                DataTable dt_new = dataTableAdapter.GetDataByClass((string)comboboxedit.SelectedValue);
                dataGridView1.DataSource = dt_new;
            }
        }

        private void tp_upclass_Click(object sender, EventArgs e)
        {
           ClassName = comboboxedit.Text;
           ClassID = (int)comboboxedit.SelectedValue;
        }
    }
}
