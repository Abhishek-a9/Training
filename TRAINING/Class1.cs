using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAINING
{
    abstract class Course

    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Type { get; set; }
        public double CollegeFees { get; set; }
        public abstract double CalculateFee();

    }

    class DegreeCourse : Course
    {
        double Fees;
        public bool Placement { get; set; }
        public bool Hostel { get; set; }
        public bool ExamFess { get; set; }

        public override double CalculateFee()
        {
            
            if (Placement && Hostel)
            {
                Fees =  CollegeFees + 480000;
            }
            return Fees;
        }

    }

    class DiplomaCourse : Course
    {
        public double OnlineFees { get; set; }

        public override double CalculateFee()
        {
            return CollegeFees + OnlineFees;
        }
    }

    class collegeApp
    {
        public void AcceptCourse()
        {
            Course course;
            Console.WriteLine("Enter the course you want to join");
            Console.WriteLine("1.Degree\t.Diploma");
            int ch = int.Parse(Console.ReadLine());
            if(ch==1)
            {
                course = new DegreeCourse();
            }
            else if(ch==2)
            {

                course = new DiplomaCourse();

            }
            course.CalculateFee();


        }
        public static void Main()
        {
            collegeApp app = new collegeApp();
            app.AcceptCourse();
        }

        

            

    }
}