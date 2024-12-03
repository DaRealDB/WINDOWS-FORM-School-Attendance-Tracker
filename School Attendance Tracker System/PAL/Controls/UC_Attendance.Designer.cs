namespace School_Attendance_Tracker_System.PAL.Controls
{
    partial class UC_Attendance
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
            this.label4 = new System.Windows.Forms.Label();
            this.tp_Mark = new System.Windows.Forms.TabPage();
            this.Btn_record = new System.Windows.Forms.Button();
            this.Btn_getval = new System.Windows.Forms.Button();
            this.dgv_class = new System.Windows.Forms.DataGridView();
            this.studentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceTable2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new School_Attendance_Tracker_System.DataSet1();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addClassSATBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addClassSATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.add_ClassSATTableAdapter = new School_Attendance_Tracker_System.DataSet1TableAdapters.Add_ClassSATTableAdapter();
            this.attendanceTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendance_Table2TableAdapter = new School_Attendance_Tracker_System.DataSet1TableAdapters.Attendance_Table2TableAdapter();
            this.tp_Mark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_class)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceTable2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addClassSATBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addClassSATBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceTable2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(534, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Attendance";
            // 
            // tp_Mark
            // 
            this.tp_Mark.Controls.Add(this.Btn_record);
            this.tp_Mark.Controls.Add(this.Btn_getval);
            this.tp_Mark.Controls.Add(this.dgv_class);
            this.tp_Mark.Controls.Add(this.comboBox1);
            this.tp_Mark.Controls.Add(this.dateTimePicker1);
            this.tp_Mark.Controls.Add(this.panel1);
            this.tp_Mark.Controls.Add(this.panel5);
            this.tp_Mark.Controls.Add(this.label2);
            this.tp_Mark.Controls.Add(this.label1);
            this.tp_Mark.Controls.Add(this.label7);
            this.tp_Mark.Location = new System.Drawing.Point(4, 4);
            this.tp_Mark.Name = "tp_Mark";
            this.tp_Mark.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Mark.Size = new System.Drawing.Size(1016, 519);
            this.tp_Mark.TabIndex = 0;
            this.tp_Mark.Text = "Mark Attendance";
            this.tp_Mark.UseVisualStyleBackColor = true;
            this.tp_Mark.Click += new System.EventHandler(this.tp_Mark_Click);
            // 
            // Btn_record
            // 
            this.Btn_record.BackColor = System.Drawing.Color.Maroon;
            this.Btn_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_record.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Btn_record.ForeColor = System.Drawing.Color.White;
            this.Btn_record.Location = new System.Drawing.Point(833, 458);
            this.Btn_record.Name = "Btn_record";
            this.Btn_record.Size = new System.Drawing.Size(100, 39);
            this.Btn_record.TabIndex = 7;
            this.Btn_record.Text = "Record";
            this.Btn_record.UseVisualStyleBackColor = false;
            this.Btn_record.Click += new System.EventHandler(this.Btn_record_Click);
            // 
            // Btn_getval
            // 
            this.Btn_getval.BackColor = System.Drawing.Color.Maroon;
            this.Btn_getval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_getval.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Btn_getval.ForeColor = System.Drawing.Color.White;
            this.Btn_getval.Location = new System.Drawing.Point(707, 458);
            this.Btn_getval.Name = "Btn_getval";
            this.Btn_getval.Size = new System.Drawing.Size(100, 39);
            this.Btn_getval.TabIndex = 6;
            this.Btn_getval.Text = "Get values";
            this.Btn_getval.UseVisualStyleBackColor = false;
            this.Btn_getval.Click += new System.EventHandler(this.Btn_rec_Click);
            // 
            // dgv_class
            // 
            this.dgv_class.AllowUserToResizeColumns = false;
            this.dgv_class.AllowUserToResizeRows = false;
            this.dgv_class.AutoGenerateColumns = false;
            this.dgv_class.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_class.BackgroundColor = System.Drawing.Color.White;
            this.dgv_class.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_class.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentnameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgv_class.DataSource = this.attendanceTable2BindingSource1;
            this.dgv_class.Location = new System.Drawing.Point(51, 133);
            this.dgv_class.Name = "dgv_class";
            this.dgv_class.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_class.ShowCellErrors = false;
            this.dgv_class.ShowEditingIcon = false;
            this.dgv_class.ShowRowErrors = false;
            this.dgv_class.Size = new System.Drawing.Size(873, 319);
            this.dgv_class.TabIndex = 5;
            this.dgv_class.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_class_CellContentClick);
            // 
            // studentnameDataGridViewTextBoxColumn
            // 
            this.studentnameDataGridViewTextBoxColumn.DataPropertyName = "Student_name";
            this.studentnameDataGridViewTextBoxColumn.HeaderText = "Student_name";
            this.studentnameDataGridViewTextBoxColumn.Name = "studentnameDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // attendanceTable2BindingSource1
            // 
            this.attendanceTable2BindingSource1.DataMember = "Attendance_Table2";
            this.attendanceTable2BindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.addClassSATBindingSource1;
            this.comboBox1.DisplayMember = "Class_name";
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(574, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "Class_name";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // addClassSATBindingSource1
            // 
            this.addClassSATBindingSource1.DataMember = "Add_ClassSAT";
            this.addClassSATBindingSource1.DataSource = this.dataSet1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(172, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(574, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 5);
            this.panel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Maroon;
            this.panel5.Location = new System.Drawing.Point(172, 108);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(219, 5);
            this.panel5.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(570, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(168, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(15, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mark Attendance";
            // 
            // addClassSATBindingSource
            // 
            this.addClassSATBindingSource.DataMember = "Add_ClassSAT";
            this.addClassSATBindingSource.DataSource = this.dataSet1;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tp_Mark);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(21, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1024, 545);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.dateTimePicker3);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1016, 519);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.addClassSATBindingSource1;
            this.comboBox3.DisplayMember = "Class_name";
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(621, 108);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(219, 21);
            this.comboBox3.TabIndex = 25;
            this.comboBox3.ValueMember = "Class_name";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(621, 218);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker3.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(617, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Class:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(740, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 19;
            this.button1.Text = "Get values";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(617, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Date:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(621, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 5);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(621, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 5);
            this.panel3.TabIndex = 16;
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
            this.listView1.Location = new System.Drawing.Point(176, 88);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(402, 360);
            this.listView1.TabIndex = 12;
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
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Late";
            this.columnHeader3.Width = 68;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Absences";
            this.columnHeader4.Width = 84;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Excused";
            this.columnHeader5.Width = 113;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Attendance Report";
            // 
            // add_ClassSATTableAdapter
            // 
            this.add_ClassSATTableAdapter.ClearBeforeFill = true;
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
            // UC_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Name = "UC_Attendance";
            this.Size = new System.Drawing.Size(1200, 600);
            this.Load += new System.EventHandler(this.UC_Attendance_Load);
            this.tp_Mark.ResumeLayout(false);
            this.tp_Mark.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_class)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceTable2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addClassSATBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addClassSATBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceTable2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tp_Mark;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_class;
        private System.Windows.Forms.BindingSource addClassSATBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.Add_ClassSATTableAdapter add_ClassSATTableAdapter;
        private System.Windows.Forms.BindingSource addClassSATBindingSource1;
        private System.Windows.Forms.Button Btn_getval;
        private System.Windows.Forms.BindingSource attendanceTable2BindingSource1;
        private System.Windows.Forms.BindingSource attendanceTable2BindingSource;
        private DataSet1TableAdapters.Attendance_Table2TableAdapter attendance_Table2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Btn_record;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label8;
    }
}
