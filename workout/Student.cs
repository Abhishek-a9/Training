using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workout
{
    class Student
    {
        public string StudentName { get; private set; }

        static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Steve";
        }

        static void Main(string[] args)
        {
            Student std1 = new Student();
            std1.StudentName = "Bill";

            ChangeReferenceType(std1);

            Console.WriteLine(std1.StudentName);
        }
    }
}
