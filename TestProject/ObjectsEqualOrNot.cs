using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Student
    {
        public int rollNo { get; set; }
        public string name { get; set; } = null;
        public int age { get; set; }
        public bool isMale { get; set; }
        public bool isFemale { get; set; }
    }
    class ObjectsEqualOrNot
    {
        public Student student_1 = new Student();
        public Student student_2 = new Student();
        public Student student_3 = new Student();

        public void button1Clicked()
        {
            Console.WriteLine("Hello World!.");

            student_1.rollNo = 2401;
            student_2.rollNo = 2402;
            student_3.rollNo = 2403;

            student_1.name = "Vishnu";
            student_2.name = "Divya";
            student_3.name = "Vishnu";

            student_1.age = 19;
            student_2.age = 12;
            student_3.age = 19;

            student_1.isMale = true;
            student_2.isMale = false;
            student_3.isMale = true;

            student_1.isFemale = false;
            student_2.isFemale = true;
            student_3.isFemale = false;

            if (student_1.Equals(student_2))
            {
                Console.WriteLine("student_1 and student_2 are equal.");
            }
            else
            {
                Console.WriteLine("student_1 and student_2 are not equal.");
            }

            if (student_1.Equals(student_3))
            {
                Console.WriteLine("student_1 and student_3 are equal.");
            }
            else
            {
                Console.WriteLine("student_1 and student_3 are not equal.");
            }

            if (student_2.Equals(student_3))
            {
                Console.WriteLine("student_2 and student_3 are equal.");
            }
            else
            {
                Console.WriteLine("student_2 and student_3 are not equal.");
            }
            Console.WriteLine("Completed...");
        }
    }
}
