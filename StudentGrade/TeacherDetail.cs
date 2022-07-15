using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentGrade
{
    public partial class TeacherDetail : Form
    {
        public TeacherDetail()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=NB3401-0011;Initial Catalog=DbGradesRegistration;Integrated Security=True");

        private void TeacherDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbGradesRegistrationDataSet.TblClass' table. You can move, or remove it, as needed.
            this.tblClassTableAdapter.Fill(this.dbGradesRegistrationDataSet.TblClass);

        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand save = new SqlCommand("insert into TblClass (StudentNumber, StudentName, StudentSurname) values (@p1, @p2, @p3)", connection);

            save.Parameters.AddWithValue("@p1", mskTxtBoxNuber.Text);
            save.Parameters.AddWithValue("@p2", txBoxStudentName.Text);
            save.Parameters.AddWithValue("@p3", txBoxStudentSurname.Text);

            save.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("You added a new student.");
            this.tblClassTableAdapter.Fill(this.dbGradesRegistrationDataSet.TblClass);



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;

            mskTxtBoxNuber.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            txBoxStudentName.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            txBoxStudentSurname.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            txBoxExam1.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            txBoxExam2.Text = dataGridView1.Rows[chosen].Cells[5].Value.ToString();
            txBoxExam3.Text = dataGridView1.Rows[chosen].Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            double everage, ex1, ex2, ex3;

            ex1 = Convert.ToDouble(txBoxExam1.Text);
            ex2 = Convert.ToDouble(txBoxExam2.Text);
            ex3 = Convert.ToDouble(txBoxExam3.Text);

            everage = (ex1 + ex2 + ex3) / 3;
            lblRealEverage.Text = everage.ToString();

            connection.Open();

            SqlCommand update = new SqlCommand("update TblClass set (StudentExam1=@p1, StudnetExam2=@p2, StudentExam3=@p3, Average=@p4, Situation=@p5 where StudentNumber=@p6", connection);

            update.Parameters.AddWithValue("@p1", txBoxExam1.Text);
            update.Parameters.AddWithValue("@p2", txBoxExam2.Text);
            update.Parameters.AddWithValue("@p3", txBoxExam3.Text);
            update.Parameters.AddWithValue("@p4", lblRealEverage.Text);
            update.Parameters.AddWithValue("@p5", lbl.Text);
        } 
    }
}
