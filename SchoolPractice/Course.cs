using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course
    {
        public string Name { get; set; }
        public List<Student> students { get; set; }
        public Teacher teacher { get; set; }

    }
}
