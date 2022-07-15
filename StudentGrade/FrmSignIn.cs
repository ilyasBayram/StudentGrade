using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGrade
{
    public partial class FrmSignIn : Form
    {
        public FrmSignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            studentDetail frm = new studentDetail();
            frm.number = mskTxBoxStudentNumber.Text;
            frm.Show();
        }

        private void mskTxBoxStudentNumber_TextChanged(object sender, EventArgs e)
        {
            if(mskTxBoxStudentNumber.Text == "1111")
            {
                TeacherDetail frm = new TeacherDetail();
                frm.Show();
            }
        }
    }
}
