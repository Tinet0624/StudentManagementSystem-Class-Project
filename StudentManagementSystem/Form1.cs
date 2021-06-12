using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StudentManagementSystem.Validator; //Validator.IsPresent(); = IsPresent();

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Notes
            ////Validator.IsPresent(); to call the stuff in the class
            //// default created by complier
            ////when using the arg constuctor can pass in this case ID or full name into the ()'s
            //Student s = new Student("658462513");
            ////s.StudentId = "658462513";
            //s.FullName = "Sorta Maybe";
            //s.DateOfBirth = new DateTime(1983, 6, 1);
            //s.Email = "maybe1234@student.cptc.edu";

            //string display = s.GetDisplayText("\n");
            //MessageBox.Show(display);

            //// object initialzation syntax version 2 on how to do! :D
            //Student stu2 = new Student("2")
            //{
            //    StudentId = "8468546",
            //    DateOfBirth = new DateTime(1985, 1, 1),
            //    Email = "beasley1234@student.cptc.edu",
            //    FullName = "Pamela Beasly"
            //};
            //string display2 = stu2.GetDisplayText("\n");
            //MessageBox.Show(display2);
            #endregion
            // Load all students from DB
            List<Student> allStudents = StudentDB.GetAllStudents();

            // populate listbox
            PopulateStudentList(allStudents);

        }

        private void PopulateStudentList(List<Student> students)
        {
            foreach (Student s in students)
            {
                listBoxStudents.Items.Add(s);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //ToDo:
            //Create a form to add student to DB
            //after student is added place in listbox
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            //ToDo:
            //Esure user has selected a student in the list box
            //open a form with that students data populated
            //once student is update refresh listbox
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            //ToDo:
            //Esure user has selected a student in the listbox
            //Ask user if they are sure if they want to delete student
            //if yes remove them from database and listbox
        }
    }
}
