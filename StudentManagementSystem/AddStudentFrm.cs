using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class AddStudentFrm : Form
    {
        public AddStudentFrm()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //validate input *skipping
            //assume input is valid

            //create object
            Student s = new Student
            {
                StudentId = txtStudentId.Text,
                FullName = txtFullName.Text,
                Email = txtEmail.Text,
                DateOfBirth = dtpDOB.Value
            };

            //add to DB
            StudentDB.Add(s);
            //close form
            Close();
        }
    }
}
