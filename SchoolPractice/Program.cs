using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {

            Student moe = new Student("Moe", 1, 1, 4.0);
            Student kevin = new Student("Kevin", 1, 1, 4.0);
            Course test = new Course();
            Course test1 = new Course();

            Console.WriteLine(moe.ToString());

            

            Console.WriteLine(kevin.ToString());

            Console.WriteLine(kevin.Equals(moe));
            Console.WriteLine(kevin.GetGradeLevel());
            kevin.AddGrade(3, 2.0);
            Console.WriteLine(kevin.ToString());
            Console.WriteLine(test.ToString());
            Console.WriteLine(test.Equals(test1));



        }
    }
}
