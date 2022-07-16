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


        void failAndPassUpdate()
        {
            connection.Open();

            SqlCommand fail = new SqlCommand("select count(stuation) from TblClass where stuation='false'", connection);

            SqlDataReader read = fail.ExecuteReader();
         

            while (read.Read())
            {
                lblRealFailedNumbers.Text = read[0].ToString();
                
            }

            connection.Close();

            connection.Open();

            SqlCommand pass = new SqlCommand("select count(stuation) from TblClass where stuation='true'", connection);

            SqlDataReader read2 = pass.ExecuteReader();

            while(read2.Read())
            {
                lblRealPassedNumbers.Text = read2[0].ToString();
            }

            connection.Close();
        }

        void classAverage()
        {
            connection.Open();

            SqlCommand classAverage = new SqlCommand("select sum(average) from TblClass", connection);

            SqlDataReader read3 = classAverage.ExecuteReader();

            while(read3.Read())
            {
                lblRealClassEverage.Text = (decimal.Round(((decimal)read3[0])/(decimal.Parse(lblRealPassedNumbers.Text)+decimal.Parse(lblRealFailedNumbers.Text)),2)).ToString();
            }

            connection.Close();
        }


        SqlConnection connection = new SqlConnection(@"Data Source=NB3401-0011;Initial Catalog=DbGradesRegistration;Integrated Security=True");


        private void TeacherDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbGradesRegistrationDataSet.TblClass' table. You can move, or remove it, as needed.
            this.tblClassTableAdapter.Fill(this.dbGradesRegistrationDataSet.TblClass);

            failAndPassUpdate();

            classAverage();
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
            txBoxStudentAverage.Text = dataGridView1.Rows[chosen].Cells[7].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            double everage, ex1, ex2, ex3;
            string stuation;

          

            ex1 = Convert.ToDouble(txBoxExam1.Text);
            ex2 = Convert.ToDouble(txBoxExam2.Text);
            ex3 = Convert.ToDouble(txBoxExam3.Text);

            everage = Math.Round(((ex1 + ex2 + ex3) / 3), 2);

            txBoxStudentAverage.Text = everage.ToString();

            if (everage >= 50)
                stuation = "true";
            else
                stuation = "false";


            connection.Open();

            SqlCommand update = new SqlCommand("update TblClass set StudentExam1=@p1, StudentExam2=@p2, StudentExam3=@p3, Average=@p4, Stuation=@p5 where StudentNumber=@p6", connection);

            update.Parameters.AddWithValue("@p1", txBoxExam1.Text);
            update.Parameters.AddWithValue("@p2", txBoxExam2.Text);
            update.Parameters.AddWithValue("@p3", txBoxExam3.Text);
            update.Parameters.AddWithValue("@p4", decimal.Parse(txBoxStudentAverage.Text));
            update.Parameters.AddWithValue("@p5", stuation);
            update.Parameters.AddWithValue("@p6", mskTxtBoxNuber.Text);
            update.ExecuteNonQuery();
            connection.Close();

            failAndPassUpdate();
            classAverage();

            MessageBox.Show("Update is succesfull.");

            this.tblClassTableAdapter.Fill(this.dbGradesRegistrationDataSet.TblClass);


        } 
    }
}
