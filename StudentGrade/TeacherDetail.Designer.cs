
namespace StudentGrade
{
    partial class TeacherDetail
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpBoxStudentAdd = new System.Windows.Forms.GroupBox();
            this.txBoxStudentSurname = new System.Windows.Forms.TextBox();
            this.txBoxStudentName = new System.Windows.Forms.TextBox();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txBoxExam3 = new System.Windows.Forms.TextBox();
            this.txBoxExam2 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txBoxExam1 = new System.Windows.Forms.TextBox();
            this.lblExam3 = new System.Windows.Forms.Label();
            this.lblExam2 = new System.Windows.Forms.Label();
            this.lblExam1 = new System.Windows.Forms.Label();
            this.grpBoxResult = new System.Windows.Forms.GroupBox();
            this.lblRealFailedNumbers = new System.Windows.Forms.Label();
            this.lblRealPassedNumbers = new System.Windows.Forms.Label();
            this.lblRealEverage = new System.Windows.Forms.Label();
            this.lblFailNumbers = new System.Windows.Forms.Label();
            this.lblPassedNumber = new System.Windows.Forms.Label();
            this.lblEvarage = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbGradesRegistrationDataSet = new StudentGrade.DbGradesRegistrationDataSet();
            this.tblClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblClassTableAdapter = new StudentGrade.DbGradesRegistrationDataSetTableAdapters.TblClassTableAdapter();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentExam1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentExam2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentExam3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mskTxtBoxNuber = new System.Windows.Forms.MaskedTextBox();
            this.grpBoxStudentAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBoxResult.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGradesRegistrationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxStudentAdd
            // 
            this.grpBoxStudentAdd.Controls.Add(this.mskTxtBoxNuber);
            this.grpBoxStudentAdd.Controls.Add(this.txBoxStudentSurname);
            this.grpBoxStudentAdd.Controls.Add(this.txBoxStudentName);
            this.grpBoxStudentAdd.Controls.Add(this.btnStudentAdd);
            this.grpBoxStudentAdd.Controls.Add(this.lblStudentSurname);
            this.grpBoxStudentAdd.Controls.Add(this.lblStudentName);
            this.grpBoxStudentAdd.Controls.Add(this.lblStudentNumber);
            this.grpBoxStudentAdd.Location = new System.Drawing.Point(12, 12);
            this.grpBoxStudentAdd.Name = "grpBoxStudentAdd";
            this.grpBoxStudentAdd.Size = new System.Drawing.Size(332, 378);
            this.grpBoxStudentAdd.TabIndex = 0;
            this.grpBoxStudentAdd.TabStop = false;
            this.grpBoxStudentAdd.Text = "Add Student";
            // 
            // txBoxStudentSurname
            // 
            this.txBoxStudentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBoxStudentSurname.Location = new System.Drawing.Point(148, 149);
            this.txBoxStudentSurname.Name = "txBoxStudentSurname";
            this.txBoxStudentSurname.Size = new System.Drawing.Size(158, 30);
            this.txBoxStudentSurname.TabIndex = 5;
            // 
            // txBoxStudentName
            // 
            this.txBoxStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBoxStudentName.Location = new System.Drawing.Point(148, 102);
            this.txBoxStudentName.Name = "txBoxStudentName";
            this.txBoxStudentName.Size = new System.Drawing.Size(158, 30);
            this.txBoxStudentName.TabIndex = 4;
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStudentAdd.Location = new System.Drawing.Point(148, 227);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(158, 54);
            this.btnStudentAdd.TabIndex = 1;
            this.btnStudentAdd.Text = "Add Student";
            this.btnStudentAdd.UseVisualStyleBackColor = true;
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click);
            // 
            // lblStudentSurname
            // 
            this.lblStudentSurname.AutoSize = true;
            this.lblStudentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentSurname.Location = new System.Drawing.Point(20, 148);
            this.lblStudentSurname.Name = "lblStudentSurname";
            this.lblStudentSurname.Size = new System.Drawing.Size(103, 25);
            this.lblStudentSurname.TabIndex = 3;
            this.lblStudentSurname.Text = "Surname: ";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentName.Location = new System.Drawing.Point(20, 99);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(75, 25);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Name :";
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentNumber.Location = new System.Drawing.Point(20, 54);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(92, 25);
            this.lblStudentNumber.TabIndex = 0;
            this.lblStudentNumber.Text = "Number :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txBoxExam3);
            this.groupBox1.Controls.Add(this.txBoxExam2);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txBoxExam1);
            this.groupBox1.Controls.Add(this.lblExam3);
            this.groupBox1.Controls.Add(this.lblExam2);
            this.groupBox1.Controls.Add(this.lblExam1);
            this.groupBox1.Location = new System.Drawing.Point(378, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 378);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exams Update";
            // 
            // txBoxExam3
            // 
            this.txBoxExam3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBoxExam3.Location = new System.Drawing.Point(137, 149);
            this.txBoxExam3.Name = "txBoxExam3";
            this.txBoxExam3.Size = new System.Drawing.Size(158, 30);
            this.txBoxExam3.TabIndex = 8;
            // 
            // txBoxExam2
            // 
            this.txBoxExam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBoxExam2.Location = new System.Drawing.Point(137, 98);
            this.txBoxExam2.Name = "txBoxExam2";
            this.txBoxExam2.Size = new System.Drawing.Size(158, 30);
            this.txBoxExam2.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(148, 227);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 54);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txBoxExam1
            // 
            this.txBoxExam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBoxExam1.Location = new System.Drawing.Point(137, 51);
            this.txBoxExam1.Name = "txBoxExam1";
            this.txBoxExam1.Size = new System.Drawing.Size(158, 30);
            this.txBoxExam1.TabIndex = 6;
            // 
            // lblExam3
            // 
            this.lblExam3.AutoSize = true;
            this.lblExam3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExam3.Location = new System.Drawing.Point(20, 148);
            this.lblExam3.Name = "lblExam3";
            this.lblExam3.Size = new System.Drawing.Size(94, 25);
            this.lblExam3.TabIndex = 3;
            this.lblExam3.Text = "Exam 3 : ";
            // 
            // lblExam2
            // 
            this.lblExam2.AutoSize = true;
            this.lblExam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExam2.Location = new System.Drawing.Point(20, 99);
            this.lblExam2.Name = "lblExam2";
            this.lblExam2.Size = new System.Drawing.Size(89, 25);
            this.lblExam2.TabIndex = 2;
            this.lblExam2.Text = "Exam 2 :";
            // 
            // lblExam1
            // 
            this.lblExam1.AutoSize = true;
            this.lblExam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExam1.Location = new System.Drawing.Point(20, 54);
            this.lblExam1.Name = "lblExam1";
            this.lblExam1.Size = new System.Drawing.Size(89, 25);
            this.lblExam1.TabIndex = 0;
            this.lblExam1.Text = "Exam 1 :";
            // 
            // grpBoxResult
            // 
            this.grpBoxResult.Controls.Add(this.lblRealFailedNumbers);
            this.grpBoxResult.Controls.Add(this.lblRealPassedNumbers);
            this.grpBoxResult.Controls.Add(this.lblRealEverage);
            this.grpBoxResult.Controls.Add(this.lblFailNumbers);
            this.grpBoxResult.Controls.Add(this.lblPassedNumber);
            this.grpBoxResult.Controls.Add(this.lblEvarage);
            this.grpBoxResult.Location = new System.Drawing.Point(726, 12);
            this.grpBoxResult.Name = "grpBoxResult";
            this.grpBoxResult.Size = new System.Drawing.Size(332, 378);
            this.grpBoxResult.TabIndex = 7;
            this.grpBoxResult.TabStop = false;
            this.grpBoxResult.Text = "Result";
            // 
            // lblRealFailedNumbers
            // 
            this.lblRealFailedNumbers.AutoSize = true;
            this.lblRealFailedNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRealFailedNumbers.Location = new System.Drawing.Point(230, 204);
            this.lblRealFailedNumbers.Name = "lblRealFailedNumbers";
            this.lblRealFailedNumbers.Size = new System.Drawing.Size(34, 25);
            this.lblRealFailedNumbers.TabIndex = 6;
            this.lblRealFailedNumbers.Text = "00";
            // 
            // lblRealPassedNumbers
            // 
            this.lblRealPassedNumbers.AutoSize = true;
            this.lblRealPassedNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRealPassedNumbers.Location = new System.Drawing.Point(230, 153);
            this.lblRealPassedNumbers.Name = "lblRealPassedNumbers";
            this.lblRealPassedNumbers.Size = new System.Drawing.Size(34, 25);
            this.lblRealPassedNumbers.TabIndex = 5;
            this.lblRealPassedNumbers.Text = "00";
            // 
            // lblRealEverage
            // 
            this.lblRealEverage.AutoSize = true;
            this.lblRealEverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRealEverage.Location = new System.Drawing.Point(163, 106);
            this.lblRealEverage.Name = "lblRealEverage";
            this.lblRealEverage.Size = new System.Drawing.Size(34, 25);
            this.lblRealEverage.TabIndex = 4;
            this.lblRealEverage.Text = "00";
            // 
            // lblFailNumbers
            // 
            this.lblFailNumbers.AutoSize = true;
            this.lblFailNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFailNumbers.Location = new System.Drawing.Point(61, 203);
            this.lblFailNumbers.Name = "lblFailNumbers";
            this.lblFailNumbers.Size = new System.Drawing.Size(155, 25);
            this.lblFailNumbers.TabIndex = 3;
            this.lblFailNumbers.Text = "Failed Number : ";
            // 
            // lblPassedNumber
            // 
            this.lblPassedNumber.AutoSize = true;
            this.lblPassedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassedNumber.Location = new System.Drawing.Point(61, 154);
            this.lblPassedNumber.Name = "lblPassedNumber";
            this.lblPassedNumber.Size = new System.Drawing.Size(163, 25);
            this.lblPassedNumber.TabIndex = 2;
            this.lblPassedNumber.Text = "Passed Number :";
            // 
            // lblEvarage
            // 
            this.lblEvarage.AutoSize = true;
            this.lblEvarage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEvarage.Location = new System.Drawing.Point(61, 109);
            this.lblEvarage.Name = "lblEvarage";
            this.lblEvarage.Size = new System.Drawing.Size(96, 25);
            this.lblEvarage.TabIndex = 0;
            this.lblEvarage.Text = "Everage :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 405);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1046, 303);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNumberDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.studentExam1DataGridViewTextBoxColumn,
            this.studentExam2DataGridViewTextBoxColumn,
            this.studentExam3DataGridViewTextBoxColumn,
            this.averageDataGridViewTextBoxColumn,
            this.stuationDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblClassBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 278);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dbGradesRegistrationDataSet
            // 
            this.dbGradesRegistrationDataSet.DataSetName = "DbGradesRegistrationDataSet";
            this.dbGradesRegistrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblClassBindingSource
            // 
            this.tblClassBindingSource.DataMember = "TblClass";
            this.tblClassBindingSource.DataSource = this.dbGradesRegistrationDataSet;
            // 
            // tblClassTableAdapter
            // 
            this.tblClassTableAdapter.ClearBeforeFill = true;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentNumberDataGridViewTextBoxColumn
            // 
            this.studentNumberDataGridViewTextBoxColumn.DataPropertyName = "StudentNumber";
            this.studentNumberDataGridViewTextBoxColumn.HeaderText = "StudentNumber";
            this.studentNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentNumberDataGridViewTextBoxColumn.Name = "studentNumberDataGridViewTextBoxColumn";
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // studentSurnameDataGridViewTextBoxColumn
            // 
            this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
            // 
            // studentExam1DataGridViewTextBoxColumn
            // 
            this.studentExam1DataGridViewTextBoxColumn.DataPropertyName = "StudentExam1";
            this.studentExam1DataGridViewTextBoxColumn.HeaderText = "StudentExam1";
            this.studentExam1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentExam1DataGridViewTextBoxColumn.Name = "studentExam1DataGridViewTextBoxColumn";
            // 
            // studentExam2DataGridViewTextBoxColumn
            // 
            this.studentExam2DataGridViewTextBoxColumn.DataPropertyName = "StudentExam2";
            this.studentExam2DataGridViewTextBoxColumn.HeaderText = "StudentExam2";
            this.studentExam2DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentExam2DataGridViewTextBoxColumn.Name = "studentExam2DataGridViewTextBoxColumn";
            // 
            // studentExam3DataGridViewTextBoxColumn
            // 
            this.studentExam3DataGridViewTextBoxColumn.DataPropertyName = "StudentExam3";
            this.studentExam3DataGridViewTextBoxColumn.HeaderText = "StudentExam3";
            this.studentExam3DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentExam3DataGridViewTextBoxColumn.Name = "studentExam3DataGridViewTextBoxColumn";
            // 
            // averageDataGridViewTextBoxColumn
            // 
            this.averageDataGridViewTextBoxColumn.DataPropertyName = "Average";
            this.averageDataGridViewTextBoxColumn.HeaderText = "Average";
            this.averageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.averageDataGridViewTextBoxColumn.Name = "averageDataGridViewTextBoxColumn";
            // 
            // stuationDataGridViewCheckBoxColumn
            // 
            this.stuationDataGridViewCheckBoxColumn.DataPropertyName = "Stuation";
            this.stuationDataGridViewCheckBoxColumn.HeaderText = "Stuation";
            this.stuationDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.stuationDataGridViewCheckBoxColumn.Name = "stuationDataGridViewCheckBoxColumn";
            // 
            // mskTxtBoxNuber
            // 
            this.mskTxtBoxNuber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTxtBoxNuber.Location = new System.Drawing.Point(148, 54);
            this.mskTxtBoxNuber.Mask = "0000";
            this.mskTxtBoxNuber.Name = "mskTxtBoxNuber";
            this.mskTxtBoxNuber.Size = new System.Drawing.Size(158, 30);
            this.mskTxtBoxNuber.TabIndex = 6;
            this.mskTxtBoxNuber.ValidatingType = typeof(int);
            // 
            // TeacherDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(1112, 720);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpBoxResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxStudentAdd);
            this.Name = "TeacherDetail";
            this.Text = "Teacher Detail";
            this.Load += new System.EventHandler(this.TeacherDetail_Load);
            this.grpBoxStudentAdd.ResumeLayout(false);
            this.grpBoxStudentAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxResult.ResumeLayout(false);
            this.grpBoxResult.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGradesRegistrationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClassBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxStudentAdd;
        private System.Windows.Forms.Button btnStudentAdd;
        private System.Windows.Forms.Label lblStudentSurname;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblExam3;
        private System.Windows.Forms.Label lblExam2;
        private System.Windows.Forms.Label lblExam1;
        private System.Windows.Forms.GroupBox grpBoxResult;
        private System.Windows.Forms.Label lblFailNumbers;
        private System.Windows.Forms.Label lblPassedNumber;
        private System.Windows.Forms.Label lblEvarage;
        private System.Windows.Forms.TextBox txBoxStudentSurname;
        private System.Windows.Forms.TextBox txBoxStudentName;
        private System.Windows.Forms.TextBox txBoxExam3;
        private System.Windows.Forms.TextBox txBoxExam2;
        private System.Windows.Forms.TextBox txBoxExam1;
        private System.Windows.Forms.Label lblRealEverage;
        private System.Windows.Forms.Label lblRealFailedNumbers;
        private System.Windows.Forms.Label lblRealPassedNumbers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbGradesRegistrationDataSet dbGradesRegistrationDataSet;
        private System.Windows.Forms.BindingSource tblClassBindingSource;
        private DbGradesRegistrationDataSetTableAdapters.TblClassTableAdapter tblClassTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentExam1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentExam2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentExam3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stuationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxNuber;
    }
}