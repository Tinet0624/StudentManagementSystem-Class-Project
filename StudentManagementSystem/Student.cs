using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    /// <summary>
    /// Represents an individual student
    /// Can make many instances of a student
    /// </summary>
    class Student
    {
        public Student()
        {
            // can put deafults here! :D like:
            //FullName = "J.Doe";
        }
        public Student(string studentId)
        {
            // make sure to put deafults if you have them in all constructors
            StudentId = studentId;
        }
        public Student(string studentId, string fullName)
        {
            FullName = fullName;
            StudentId = studentId;
        }
        #region Properties
        /// <summary>
        /// The 9 digit student identification number
        /// </summary>
        public string StudentId { get; set; }
        /// <summary>
        /// The full legal name of student
        /// First and Last name ex. Alexandra Haley
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Bithdate time is ignored
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Student generated email ex. haley1234@student.cptc.edu
        /// </summary>
        public string Email { get; set; }
        #endregion

        /// <summary>
        /// Get a string representation of the current student instance
        /// </summary>
        /// <param name="separator"></param>
        /// A string to separate each piece of information
        /// <returns></returns>
        public string GetDisplayText(string separator)
        {
            return $"{StudentId}{separator}{FullName}{separator}" +
                $"{DateOfBirth}{separator}{Email}";
        }

        /// <summary>
        /// Registers a student for a specific course
        /// </summary>
        /// <param name="courseCode"></param>
        /// Code for the course to register for
        public void Register(string courseCode)
        {
            throw new NotImplementedException(); // method stub
        }

        /// <summary>
        /// Overrides the ToString to display only the Full Name
        /// </summary>
        /// <returns></returns>
        public override string ToString() // only see FullName
        {
            return FullName;
        }
    }
}
