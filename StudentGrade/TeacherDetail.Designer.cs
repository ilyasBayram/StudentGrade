
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpBoxStudentAdd = new System.Windows.Forms.GroupBox();
            this.mskTxtBoxNuber = new System.Windows.Forms.MaskedTextBox();
            this.txBoxStudentSurname = new System.Windows.Forms.TextBox();
            this.txBoxStudentName = new System.Windows.Forms.TextBox();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.lblStudentSurname = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txBoxStudentAverage = new System.Windows.Forms.TextBox();
            this.lblStudentAverage = new System.Windows.Forms.Label();
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
            this.lblRealClassEverage = new System.Windows.Forms.Label();
            this.lblFailNumbers = new System.Windows.Forms.Label();
            this.lblPassedNumber = new System.Windows.Forms.Label();
            this.lblEvarage = new System.Windows.Forms.Label();
            this.grpBoxStudentList = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentExam1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentExam2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentExam3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbGradesRegistrationDataSet = new StudentGrade.DbGradesRegistrationDataSet();
            this.tblClassTableAdapter = new StudentGrade.DbGradesRegistrationDataSetTableAdapters.TblClassTableAdapter();
            this.lblRealTotalNumber = new System.Windows.Forms.Label();
            this.lblTotalNumber = new System.Windows.Forms.Label();
            this.grpBoxStudentAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBoxResult.SuspendLayout();
            this.grpBoxStudentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGradesRegistrationDataSet)).BeginInit();
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
            this.groupBox1.Controls.Add(this.txBoxStudentAverage);
            this.groupBox1.Controls.Add(this.lblStudentAverage);
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
            // txBoxStudentAverage
            // 
            this.txBoxStudentAverage.Enabled = false;
            this.txBoxStudentAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txBoxStudentAverage.Location = new System.Drawing.Point(137, 201);
            this.txBoxStudentAverage.Name = "txBoxStudentAverage";
            this.txBoxStudentAverage.Size = new System.Drawing.Size(158, 30);
            this.txBoxStudentAverage.TabIndex = 10;
            // 
            // lblStudentAverage
            // 
            this.lblStudentAverage.AutoSize = true;
            this.lblStudentAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentAverage.Location = new System.Drawing.Point(20, 200);
            this.lblStudentAverage.Name = "lblStudentAverage";
            this.lblStudentAverage.Size = new System.Drawing.Size(102, 25);
            this.lblStudentAverage.TabIndex = 9;
            this.lblStudentAverage.Text = "Average : ";
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
            this.btnUpdate.Location = new System.Drawing.Point(137, 277);
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
            this.grpBoxResult.Controls.Add(this.lblRealTotalNumber);
            this.grpBoxResult.Controls.Add(this.lblTotalNumber);
            this.grpBoxResult.Controls.Add(this.lblRealFailedNumbers);
            this.grpBoxResult.Controls.Add(this.lblRealPassedNumbers);
            this.grpBoxResult.Controls.Add(this.lblRealClassEverage);
            this.grpBoxResult.Controls.Add(this.lblFailNumbers);
            this.grpBoxResult.Controls.Add(this.lblPassedNumber);
            this.grpBoxResult.Controls.Add(this.lblEvarage);
            this.grpBoxResult.Location = new System.Drawing.Point(726, 12);
            this.grpBoxResult.Name = "grpBoxResult";
            this.grpBoxResult.Size = new System.Drawing.Size(332, 378);
            this.grpBoxResult.TabIndex = 7;
            this.grpBoxResult.TabStop = false;
            this.grpBoxResult.Text = "Class Result";
            // 
            // lblRealFailedNumbers
            // 
            this.lblRealFailedNumbers.AutoSize = true;
            this.lblRealFailedNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRealFailedNumbers.Location = new System.Drawing.Point(185, 197);
            this.lblRealFailedNumbers.Name = "lblRealFailedNumbers";
            this.lblRealFailedNumbers.Size = new System.Drawing.Size(34, 25);
            this.lblRealFailedNumbers.TabIndex = 6;
            this.lblRealFailedNumbers.Text = "00";
            // 
            // lblRealPassedNumbers
            // 
            this.lblRealPassedNumbers.AutoSize = true;
            this.lblRealPassedNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRealPassedNumbers.Location = new System.Drawing.Point(185, 148);
            this.lblRealPassedNumbers.Name = "lblRealPassedNumbers";
            this.lblRealPassedNumbers.Size = new System.Drawing.Size(34, 25);
            this.lblRealPassedNumbers.TabIndex = 5;
            this.lblRealPassedNumbers.Text = "00";
            // 
            // lblRealClassEverage
            // 
            this.lblRealClassEverage.AutoSize = true;
            this.lblRealClassEverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRealClassEverage.Location = new System.Drawing.Point(185, 235);
            this.lblRealClassEverage.Name = "lblRealClassEverage";
            this.lblRealClassEverage.Size = new System.Drawing.Size(34, 25);
            this.lblRealClassEverage.TabIndex = 4;
            this.lblRealClassEverage.Text = "00";
            // 
            // lblFailNumbers
            // 
            this.lblFailNumbers.AutoSize = true;
            this.lblFailNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFailNumbers.Location = new System.Drawing.Point(16, 193);
            this.lblFailNumbers.Name = "lblFailNumbers";
            this.lblFailNumbers.Size = new System.Drawing.Size(155, 25);
            this.lblFailNumbers.TabIndex = 3;
            this.lblFailNumbers.Text = "Failed Number : ";
            // 
            // lblPassedNumber
            // 
            this.lblPassedNumber.AutoSize = true;
            this.lblPassedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassedNumber.Location = new System.Drawing.Point(16, 148);
            this.lblPassedNumber.Name = "lblPassedNumber";
            this.lblPassedNumber.Size = new System.Drawing.Size(163, 25);
            this.lblPassedNumber.TabIndex = 2;
            this.lblPassedNumber.Text = "Passed Number :";
            // 
            // lblEvarage
            // 
            this.lblEvarage.AutoSize = true;
            this.lblEvarage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEvarage.Location = new System.Drawing.Point(16, 235);
            this.lblEvarage.Name = "lblEvarage";
            this.lblEvarage.Size = new System.Drawing.Size(151, 25);
            this.lblEvarage.TabIndex = 0;
            this.lblEvarage.Text = "Class Everage :";
            this.lblEvarage.Click += new System.EventHandler(this.lblEvarage_Click);
            // 
            // grpBoxStudentList
            // 
            this.grpBoxStudentList.Controls.Add(this.dataGridView1);
            this.grpBoxStudentList.Location = new System.Drawing.Point(12, 405);
            this.grpBoxStudentList.Name = "grpBoxStudentList";
            this.grpBoxStudentList.Size = new System.Drawing.Size(1046, 303);
            this.grpBoxStudentList.TabIndex = 8;
            this.grpBoxStudentList.TabStop = false;
            this.grpBoxStudentList.Text = "Student List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 278);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.studentNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentSurnameDataGridViewTextBoxColumn
            // 
            this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
            this.studentSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentExam1DataGridViewTextBoxColumn
            // 
            this.studentExam1DataGridViewTextBoxColumn.DataPropertyName = "StudentExam1";
            this.studentExam1DataGridViewTextBoxColumn.HeaderText = "StudentExam1";
            this.studentExam1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentExam1DataGridViewTextBoxColumn.Name = "studentExam1DataGridViewTextBoxColumn";
            this.studentExam1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentExam2DataGridViewTextBoxColumn
            // 
            this.studentExam2DataGridViewTextBoxColumn.DataPropertyName = "StudentExam2";
            this.studentExam2DataGridViewTextBoxColumn.HeaderText = "StudentExam2";
            this.studentExam2DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentExam2DataGridViewTextBoxColumn.Name = "studentExam2DataGridViewTextBoxColumn";
            this.studentExam2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentExam3DataGridViewTextBoxColumn
            // 
            this.studentExam3DataGridViewTextBoxColumn.DataPropertyName = "StudentExam3";
            this.studentExam3DataGridViewTextBoxColumn.HeaderText = "StudentExam3";
            this.studentExam3DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentExam3DataGridViewTextBoxColumn.Name = "studentExam3DataGridViewTextBoxColumn";
            this.studentExam3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // averageDataGridViewTextBoxColumn
            // 
            this.averageDataGridViewTextBoxColumn.DataPropertyName = "Average";
            this.averageDataGridViewTextBoxColumn.HeaderText = "Average";
            this.averageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.averageDataGridViewTextBoxColumn.Name = "averageDataGridViewTextBoxColumn";
            this.averageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stuationDataGridViewCheckBoxColumn
            // 
            this.stuationDataGridViewCheckBoxColumn.DataPropertyName = "Stuation";
            this.stuationDataGridViewCheckBoxColumn.HeaderText = "Stuation";
            this.stuationDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.stuationDataGridViewCheckBoxColumn.Name = "stuationDataGridViewCheckBoxColumn";
            this.stuationDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // tblClassBindingSource
            // 
            this.tblClassBindingSource.DataMember = "TblClass";
            this.tblClassBindingSource.DataSource = this.dbGradesRegistrationDataSet;
            // 
            // dbGradesRegistrationDataSet
            // 
            this.dbGradesRegistrationDataSet.DataSetName = "DbGradesRegistrationDataSet";
            this.dbGradesRegistrationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblClassTableAdapter
            // 
            this.tblClassTableAdapter.ClearBeforeFill = true;
            // 
            // lblRealTotalNumber
            // 
            this.lblRealTotalNumber.AutoSize = true;
            this.lblRealTotalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRealTotalNumber.Location = new System.Drawing.Point(234, 106);
            this.lblRealTotalNumber.Name = "lblRealTotalNumber";
            this.lblRealTotalNumber.Size = new System.Drawing.Size(34, 25);
            this.lblRealTotalNumber.TabIndex = 8;
            this.lblRealTotalNumber.Text = "00";
            // 
            // lblTotalNumber
            // 
            this.lblTotalNumber.AutoSize = true;
            this.lblTotalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalNumber.Location = new System.Drawing.Point(16, 106);
            this.lblTotalNumber.Name = "lblTotalNumber";
            this.lblTotalNumber.Size = new System.Drawing.Size(219, 25);
            this.lblTotalNumber.TabIndex = 7;
            this.lblTotalNumber.Text = "Total  Student Number :";
            // 
            // TeacherDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(1075, 739);
            this.Controls.Add(this.grpBoxStudentList);
            this.Controls.Add(this.grpBoxResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxStudentAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherDetail";
            this.Text = "Teacher Detail";
            this.Load += new System.EventHandler(this.TeacherDetail_Load);
            this.grpBoxStudentAdd.ResumeLayout(false);
            this.grpBoxStudentAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxResult.ResumeLayout(false);
            this.grpBoxResult.PerformLayout();
            this.grpBoxStudentList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGradesRegistrationDataSet)).EndInit();
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
        private System.Windows.Forms.Label lblRealClassEverage;
        private System.Windows.Forms.Label lblRealFailedNumbers;
        private System.Windows.Forms.Label lblRealPassedNumbers;
        private System.Windows.Forms.GroupBox grpBoxStudentList;
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
        private System.Windows.Forms.TextBox txBoxStudentAverage;
        private System.Windows.Forms.Label lblStudentAverage;
        private System.Windows.Forms.Label lblRealTotalNumber;
        private System.Windows.Forms.Label lblTotalNumber;
    }
}