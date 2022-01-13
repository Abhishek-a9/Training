using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsDemo
{
    class Program
    {
        static void myfun2()
        {
            Console.WriteLine("Running the child thread {0}", Thread.CurrentThread.Name);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Thread.Sleep(3000);
            for (int i = 11; i < 25; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Thread {0} completed", Thread.CurrentThread.Name);

        }

        static void myfun3()
        {
            Console.WriteLine("Running one more Thread in func3()");
            for (int i = 100; i < 110; i++)
            {
                Console.WriteLine(i);
            }
            Thread.Sleep(3000);
            for (int i = 111; i < 125; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Thread {0} completed", Thread.CurrentThread.Name);
            Console.WriteLine("Pls Enter your Name");
            string s1 = Console.ReadLine();
            Console.WriteLine("Welcome to Threading in CSharp {0}!!!", s1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*Current Thread Info*");
            Console.WriteLine("Thread Name is {0} ID is {1}", Thread.CurrentThread.Name, Thread.CurrentThread.ManagedThreadId);
            Thread mainthread = Thread.CurrentThread;//Thread1
            mainthread.Name = "Primary-Thread 5th Jan ";
            Console.WriteLine("Thread Name :{0}", mainthread.Name);
            Console.WriteLine("Thread Status :{0}", mainthread.IsAlive);
            Console.WriteLine("Priority :{0}", mainthread.Priority);

            Thread t2 = new Thread(myfun2);
            t2.Name = "Child Thread2";
            t2.Priority = (ThreadPriority)3;
            t2.IsBackground = true;
            t2.Start();



            Thread t3 = new Thread(myfun3);
            t3.Name = "One More Thread3";
            t3.Priority = ThreadPriority.Highest;
            t3.Start();

            Console.ReadKey();
        }
    }
}