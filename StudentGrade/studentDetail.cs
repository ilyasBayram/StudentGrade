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
    public partial class studentDetail : Form
    {
        public studentDetail()
        {
            InitializeComponent();
        }

        public string number;

        SqlConnection connection = new SqlConnection(@"Data Source=NB3401-0011;Initial Catalog=DbGradesRegistration;Integrated Security=True");

        private void studentDetail_Load(object sender, EventArgs e)
        {
            lblStudentRealNumber.Text = number;

            connection.Open();
            SqlCommand command = new SqlCommand("select * from TblClass where StudentNumber=@p1",connection);
            command.Parameters.AddWithValue("@p1", number);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read()) 
            {
                lblStudentRealName.Text = read[2].ToString()+" "+read[3].ToString();
                lblStudentGrade1.Text = read[4].ToString();
                lblStudentGrade2.Text = read[5].ToString();
                lblStudentGrade3.Text = read[6].ToString();
                lblStudentRealAvarage.Text = read[7].ToString();
                lblStudentRealStuation.Text = read[8].ToString() == "True"? "Passed":"Failed";
            }

            connection.Close();
        }
    }
}
