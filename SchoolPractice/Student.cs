using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        private readonly int studentId;
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int sId, int numberOfCredits, double gpa)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int sId)
        {
            Name = name;
            studentId = sId;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public Student(string name)
        {
            Name = name;
            studentId = nextStudentId;
            nextStudentId++;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public string StudentInfo()
        {
            return (Name + " has a GPA of: " + Gpa);
        }

        public void AddGrade(int courseCredits, double grade)
        {
            int tempCourseCredits = courseCredits + NumberOfCredits;
            Gpa = ((Gpa * NumberOfCredits) + (grade * courseCredits)) / tempCourseCredits;
            NumberOfCredits = tempCourseCredits;
        }

        public string GetGradeLevel()
        {
            string year = "Freshman";

            if( NumberOfCredits >= 90) { year = "Senior"; }
            else if( NumberOfCredits >= 60) { year = "Junior"; }
            else if (NumberOfCredits >= 30) { year = "Sophmore"; }

            return year;
        }

        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }

        public override bool Equals(object toBeCompared)
        {

            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            if (toBeCompared == null)
            {
                return false;
            }

            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            Student s = toBeCompared as Student;
            return s.studentId == studentId;
        }
    }
}
