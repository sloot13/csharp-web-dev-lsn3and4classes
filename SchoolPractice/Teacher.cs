using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Subject { get; set; }
        public double YearsTeaching { get; set; }

        public Teacher(string firstName, string lastName, int subject, double yearsTeaching)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
            YearsTeaching = yearsTeaching;
        }

        public Teacher()
        {
        }

        
    }
}
