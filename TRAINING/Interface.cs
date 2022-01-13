using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAINING
{
    interface ICalculate
    {
        void Add(int a,int b);
        void Mul(int a,int b);
        void sub(int a,int b);
        double div(double a,double b);
    }

    class NormalCalculator : ICalculate
    {
        public void Add(int a,int b)
        {
            Console.WriteLine("Addition =" + (a + b));
        }
        public void Mul(int a,int b)
        {

            Console.WriteLine("Multiplication =" + (a * b));
        }

        public void sub(int a,int b)
        {
            Console.WriteLine("Subtraction=" + (a - b));
        }
        public double div(double a,double b)
        {
            if(b!=0)
            {
                return a / b;
            }
            else
            {
                return b / a;
            }
            
        }
    }

    class ScientificCalculator:ICalculate
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Addition =" + (a + b));
        }
        public void Mul(int a, int b)
        {

            Console.WriteLine("Multiplication =" + (a * b));
        }

        public void sub(int a, int b)
        {
            Console.WriteLine("Subtraction=" + (a - b));
        }
        public double div(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                return b / a;
            }

        }
    }

    public class CalProgram
    {
        public static void Main (string[] args)
        {
            ICalculate ob = new NormalCalculator();
            ob.Add(1, 2);
            ob.Mul(3,4);
            ob = new ScientificCalculator();
            ob.sub(1, 2);
            ob.div(20,5);
            Console.ReadKey();
        }
    }

}
