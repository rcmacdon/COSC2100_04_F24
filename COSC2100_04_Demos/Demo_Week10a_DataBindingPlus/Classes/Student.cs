using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Week10a_DataBindingPlus.Classes
{
    public class Student
    {
        #region Global Variables and Constants
        public static List<Student> students = new List<Student>();
        public static int studentID = 0;
        #endregion

        #region Properties
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        #endregion

        #region Constructors
        public Student()
        {
            this.StudentID = ++studentID;
        }
        public Student(string firstName, string lastName, int age)
        {
            this.StudentID = ++studentID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        #endregion

        #region Instance Methods
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " (" + this.Age + ")";
        }

        public string FullName
        {
            get { return this.FirstName + " " + this.LastName; }
        }
        #endregion

        #region Static Methods
        public static void PopulateStudents()
        {
            students.Add(new Student("John", "Doe", 21));
            students.Add(new Student("Jane", "Smith", 22));
            students.Add(new Student("Jim", "Brown", 23));
            students.Add(new Student("Jill", "White", 24));
            students.Add(new Student("Jack", "Black", 25));
            students.Add(new Student("Jenny", "Green", 26));
            students.Add(new Student("Jerry", "Blue", 27));
            students.Add(new Student("Jared", "Red", 28));
        }

        public static Student FindStudent(int studentID)
        {
            foreach (Student student in students)
            {
                if (student.StudentID == studentID) return student;
            }
            return null;
        }
        #endregion
    }
}
