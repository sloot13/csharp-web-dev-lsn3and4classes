using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {

        public string Topic { get; set; }
        public List<Student> Students { get; set; }
        public Teacher Instructor { get; set; }

        public Course()
        {
            Topic = "Math";
            Students = new List<Student>();
            Instructor = new Teacher("Hello", "World", 4050, 7.4);
        }

        public override string ToString()
        {
            return Topic + " has " + Students.Count  + " students in the course and is being taught by " + Instructor.FirstName + " " + Instructor.LastName;
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

            Course s = toBeCompared as Course;
            return s.Topic == Topic;
        }




    }
}
