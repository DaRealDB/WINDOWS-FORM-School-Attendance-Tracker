namespace School_Attendance_Tracker_System.PAL.Controls
{
    partial class UC_AddClass
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
            this.tp_upclass = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.classnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classfemaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classmaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addClassSATBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new School_Attendance_Tracker_System.DataSet1();
            this.comboboxedit = new System.Windows.Forms.ComboBox();
            this.addClassSATBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btn_add = new System.Windows.Forms.Button();
            this.txbac_female = new System.Windows.Forms.TextBox();
            this.txbac_quantity = new System.Windows.Forms.TextBox();
            this.txbac_male = new System.Windows.Forms.TextBox();
            this.txbac_name = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tab_addclass = new System.Windows.Forms.TabControl();
            this.addClassSATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_ClassSATTableAdapter = new School_Attendance_Tracker_System.DataSet1TableAdapters.Add_ClassSATTableAdapter();
            this.tp_upclass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addClassSATBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addClassSATBindingSource1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.Tab_addclass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addClassSATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(452, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Add Class";
            // 
            // tp_upclass
            // 
            this.tp_upclass.Controls.Add(this.button1);
            this.tp_upclass.Controls.Add(this.dataGridView1);
            this.tp_upclass.Controls.Add(this.comboboxedit);
            this.tp_upclass.Controls.Add(this.btn_delete);
            this.tp_upclass.Controls.Add(this.btn_update);
            this.tp_upclass.Controls.Add(this.panel8);
            this.tp_upclass.Controls.Add(this.label13);
            this.tp_upclass.Controls.Add(this.label10);
            this.tp_upclass.Location = new System.Drawing.Point(4, 4);
            this.tp_upclass.Name = "tp_upclass";
            this.tp_upclass.Padding = new System.Windows.Forms.Padding(3);
            this.tp_upclass.Size = new System.Drawing.Size(1204, 468);
            this.tp_upclass.TabIndex = 2;
            this.tp_upclass.Text = "Update or Delete Class";
            this.tp_upclass.UseVisualStyleBackColor = true;
            this.tp_upclass.Click += new System.EventHandler(this.tp_upclass_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(419, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classnameDataGridViewTextBoxColumn,
            this.classtotalDataGridViewTextBoxColumn,
            this.classfemaleDataGridViewTextBoxColumn,
            this.classmaleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.addClassSATBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(280, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 271);
            this.dataGridView1.TabIndex = 6;
            // 
            // classnameDataGridViewTextBoxColumn
            // 
            this.classnameDataGridViewTextBoxColumn.DataPropertyName = "Class_name";
            this.classnameDataGridViewTextBoxColumn.HeaderText = "Class_name";
            this.classnameDataGridViewTextBoxColumn.Name = "classnameDataGridViewTextBoxColumn";
            // 
            // classtotalDataGridViewTextBoxColumn
            // 
            this.classtotalDataGridViewTextBoxColumn.DataPropertyName = "Class_total";
            this.classtotalDataGridViewTextBoxColumn.HeaderText = "Class_total";
            this.classtotalDataGridViewTextBoxColumn.Name = "classtotalDataGridViewTextBoxColumn";
            // 
            // classfemaleDataGridViewTextBoxColumn
            // 
            this.classfemaleDataGridViewTextBoxColumn.DataPropertyName = "Class_female";
            this.classfemaleDataGridViewTextBoxColumn.HeaderText = "Class_female";
            this.classfemaleDataGridViewTextBoxColumn.Name = "classfemaleDataGridViewTextBoxColumn";
            // 
            // classmaleDataGridViewTextBoxColumn
            // 
            this.classmaleDataGridViewTextBoxColumn.DataPropertyName = "Class_male";
            this.classmaleDataGridViewTextBoxColumn.HeaderText = "Class_male";
            this.classmaleDataGridViewTextBoxColumn.Name = "classmaleDataGridViewTextBoxColumn";
            // 
            // addClassSATBindingSource2
            // 
            this.addClassSATBindingSource2.DataMember = "Add_ClassSAT";
            this.addClassSATBindingSource2.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboboxedit
            // 
            this.comboboxedit.DataSource = this.addClassSATBindingSource1;
            this.comboboxedit.DisplayMember = "Class_name";
            this.comboboxedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboboxedit.FormattingEnabled = true;
            this.comboboxedit.Location = new System.Drawing.Point(373, 76);
            this.comboboxedit.Name = "comboboxedit";
            this.comboboxedit.Size = new System.Drawing.Size(243, 21);
            this.comboboxedit.TabIndex = 5;
            this.comboboxedit.ValueMember = "Class_name";
            // 
            // addClassSATBindingSource1
            // 
            this.addClassSATBindingSource1.DataMember = "Add_ClassSAT";
            this.addClassSATBindingSource1.DataSource = this.dataSet1;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Maroon;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(628, 386);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 36);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Maroon;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(522, 386);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(94, 36);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Maroon;
            this.panel8.Location = new System.Drawing.Point(373, 93);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(243, 10);
            this.panel8.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(370, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Class";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(26, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Update or Delete Class";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Btn_add);
            this.tabPage2.Controls.Add(this.txbac_female);
            this.tabPage2.Controls.Add(this.txbac_quantity);
            this.tabPage2.Controls.Add(this.txbac_male);
            this.tabPage2.Controls.Add(this.txbac_name);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1204, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Class";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Btn_add
            // 
            this.Btn_add.BackColor = System.Drawing.Color.Maroon;
            this.Btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_add.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.Btn_add.ForeColor = System.Drawing.Color.White;
            this.Btn_add.Location = new System.Drawing.Point(197, 324);
            this.Btn_add.Name = "Btn_add";
            this.Btn_add.Size = new System.Drawing.Size(125, 42);
            this.Btn_add.TabIndex = 3;
            this.Btn_add.Text = "Add";
            this.Btn_add.UseVisualStyleBackColor = false;
            this.Btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // txbac_female
            // 
            this.txbac_female.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbac_female.Location = new System.Drawing.Point(565, 270);
            this.txbac_female.Name = "txbac_female";
            this.txbac_female.Size = new System.Drawing.Size(237, 13);
            this.txbac_female.TabIndex = 2;
            // 
            // txbac_quantity
            // 
            this.txbac_quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbac_quantity.Location = new System.Drawing.Point(565, 138);
            this.txbac_quantity.Name = "txbac_quantity";
            this.txbac_quantity.Size = new System.Drawing.Size(237, 13);
            this.txbac_quantity.TabIndex = 2;
            // 
            // txbac_male
            // 
            this.txbac_male.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbac_male.Location = new System.Drawing.Point(197, 270);
            this.txbac_male.Name = "txbac_male";
            this.txbac_male.Size = new System.Drawing.Size(237, 13);
            this.txbac_male.TabIndex = 2;
            // 
            // txbac_name
            // 
            this.txbac_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbac_name.Location = new System.Drawing.Point(197, 138);
            this.txbac_name.Name = "txbac_name";
            this.txbac_name.Size = new System.Drawing.Size(237, 13);
            this.txbac_name.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(197, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 3);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(565, 283);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 3);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(565, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 3);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(197, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 3);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(194, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Male:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(562, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Female:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(194, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Class name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(562, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "How many students?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(-343, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Add Class";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Class";
            // 
            // Tab_addclass
            // 
            this.Tab_addclass.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.Tab_addclass.Controls.Add(this.tabPage2);
            this.Tab_addclass.Controls.Add(this.tp_upclass);
            this.Tab_addclass.Location = new System.Drawing.Point(0, 3);
            this.Tab_addclass.Name = "Tab_addclass";
            this.Tab_addclass.SelectedIndex = 0;
            this.Tab_addclass.Size = new System.Drawing.Size(1212, 494);
            this.Tab_addclass.TabIndex = 4;
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
            // UC_AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Tab_addclass);
            this.Controls.Add(this.label4);
            this.Name = "UC_AddClass";
            this.Size = new System.Drawing.Size(1230, 585);
            this.tp_upclass.ResumeLayout(false);
            this.tp_upclass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addClassSATBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addClassSATBindingSource1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Tab_addclass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addClassSATBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tp_upclass;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Btn_add;
        private System.Windows.Forms.TextBox txbac_female;
        private System.Windows.Forms.TextBox txbac_quantity;
        private System.Windows.Forms.TextBox txbac_male;
        private System.Windows.Forms.TextBox txbac_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Tab_addclass;
        private System.Windows.Forms.ComboBox comboboxedit;
        private System.Windows.Forms.BindingSource addClassSATBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource addClassSATBindingSource1;
        private DataSet1TableAdapters.Add_ClassSATTableAdapter add_ClassSATTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classfemaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classmaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource addClassSATBindingSource2;
        private System.Windows.Forms.Button button1;
    }
}
