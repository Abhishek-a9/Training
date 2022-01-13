using System;

namespace TRAINING
{public class ObjectCount
    {
        public static int count;//static 
        public string name;//non static
        public int age;//non static
        
        public ObjectCount()//constructor is a method which automatically invoked when an object is of the class is created.

        {
            count++;//increment   
        }

#pragma warning disable IDE1006 // Naming Styles
        public void Display()
#pragma warning restore IDE1006 // Naming Styles
        {
            Console.WriteLine("name is {0} and age is {1}", name, age);
        }

        public static int print()
        { 
            return count;
        }
    }

    

    public class Program
    {
        public static void Main(string[] args) //main method starts
        {
            ObjectCount obj1 = new ObjectCount();//crratinf an object will invoke constructor
            Console.WriteLine(ObjectCount.print());// in this case the count is incremented 

            ObjectCount obj2 = new ObjectCount();
            Console.WriteLine(ObjectCount.print());
            ObjectCount obj3 = new ObjectCount();
            Console.WriteLine(ObjectCount.print());
            ObjectCount.count++;//STATIC VARUIABLE CAN BE accessed using class name and can be changed static variable is like a shared copy. Only a single copy
            obj3.age = 25;
            obj3.name = "Kavin";
            ObjectCount.print();//obj1.print() WILL THROW ERROR we cannot call a static method with an object we can only call with the class  name directly
            obj3.Display();//non static method

            Console.WriteLine("Number of objects created are {0}", ObjectCount.print());
            Console.ReadLine();
           


        }
    }
}