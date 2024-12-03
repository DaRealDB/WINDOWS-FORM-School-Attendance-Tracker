namespace School_Attendance_Tracker_System.PAL.Controls
{
    partial class UC_Report
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_getval = new System.Windows.Forms.Button();
            this.dataSet1 = new School_Attendance_Tracker_System.DataSet1();
            this.attendanceTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendance_Table2TableAdapter = new School_Attendance_Tracker_System.DataSet1TableAdapters.Attendance_Table2TableAdapter();
            this.addClassSATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_ClassSATTableAdapter = new School_Attendance_Tracker_System.DataSet1TableAdapters.Add_ClassSATTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addClassSATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(309, 85);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(402, 360);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Student";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Present";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Late";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Absences";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Excused";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.addClassSATBindingSource;
            this.comboBox1.DisplayMember = "Class_name";
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(754, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "Class_name";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(754, 217);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(754, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 5);
            this.panel1.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Maroon;
            this.panel5.Location = new System.Drawing.Point(754, 235);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(219, 5);
            this.panel5.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(805, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Class:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(750, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Date:";
            // 
            // Btn_getval
            // 
            this.Btn_getval.BackColor = System.Drawing.Color.Maroon;
            this.Btn_getval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_getval.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Btn_getval.ForeColor = System.Drawing.Color.White;
            this.Btn_getval.Location = new System.Drawing.Point(873, 406);
            this.Btn_getval.Name = "Btn_getval";
            this.Btn_getval.Size = new System.Drawing.Size(100, 39);
            this.Btn_getval.TabIndex = 11;
            this.Btn_getval.Text = "Get values";
            this.Btn_getval.UseVisualStyleBackColor = false;
            this.Btn_getval.Click += new System.EventHandler(this.Btn_getval_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceTable2BindingSource
            // 
            this.attendanceTable2BindingSource.DataMember = "Attendance_Table2";
            this.attendanceTable2BindingSource.DataSource = this.dataSet1;
            // 
            // attendance_Table2TableAdapter
            // 
            this.attendance_Table2TableAdapter.ClearBeforeFill = true;
            // 
            // addClassSATBindingSource
            // 
            this.addClassSATBindingSource.DataMember = "Add_ClassSAT";
            this.addClassSATBindingSource.DataSource = this.dataSet1;
            // 
            // add_ClassSATTableAdapter
            // 
            this.add_ClassSATTableAdapter.ClearBeforeFill = true;
            // 
            // UC_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_getval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listView1);
            this.Name = "UC_Report";
            this.Size = new System.Drawing.Size(1200, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addClassSATBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_getval;
        private System.Windows.Forms.BindingSource attendanceTable2BindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.Attendance_Table2TableAdapter attendance_Table2TableAdapter;
        private System.Windows.Forms.BindingSource addClassSATBindingSource;
        private DataSet1TableAdapters.Add_ClassSATTableAdapter add_ClassSATTableAdapter;
    }
}
