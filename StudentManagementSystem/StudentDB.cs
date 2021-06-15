using System;
using System.Collections.Generic;
using System.Data.SqlClient; // for sql stuff
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    static class StudentDB
    {
        //CRUD ceate, retieve, undo, delete

        public static List<Student> GetAllStudents()
        {
            SqlConnection con1 = DbHelper.GetConnection();

            //get command set up
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Id " +
                            ",FullName " +
                            ",Email " +
                            ",DOB " +
                            "FROM Students";
            cmd.Connection = con1;

            con1.Open(); // communicate with DB
            // DB code here
            SqlDataReader rdr = cmd.ExecuteReader();
            List<Student> stuList = new List<Student>();
            while(rdr.Read()) //while there are rows to be read
            {
                Student temp = new Student
                {
                    StudentId = Convert.ToString(rdr["Id"]),
                    FullName = Convert.ToString(rdr["FullName"]),
                    Email = Convert.ToString(rdr["Email"]),
                    DateOfBirth = Convert.ToDateTime(rdr["DOB"])
                };
                stuList.Add(temp);
            }

            con1.Close(); // end connection to DB
            return stuList;
        }
        public static void Add(Student s)
        {
            SqlConnection con = DbHelper.GetConnection();

            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;
            // NO STRINGS HERE!!!! Sql injection attacks!!!
            insertCmd.CommandText = 
                "INSERT INTO Students(Id, FullName, Email, DOB) " +
                "VALUES(@StuID, @FullName, @Email, @BirthDate)";
            insertCmd.Parameters.AddWithValue("@StuID", s.StudentId);
            insertCmd.Parameters.AddWithValue("@FullName", s.FullName);
            insertCmd.Parameters.AddWithValue("@Email", s.Email);
            insertCmd.Parameters.AddWithValue("@BirthDate", s.DateOfBirth);

            con.Open();
            insertCmd.ExecuteNonQuery();
            con.Close();
        }

        public static void Update(Student s)
        {
            throw new NotImplementedException();
        }

        public static void Delete(Student s)
        {
            throw new NotImplementedException();
        }
    }
}
