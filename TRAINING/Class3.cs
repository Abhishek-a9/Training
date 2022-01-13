using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadsDemo
{
    class Background
    {
        public static void Main()
        {
            ThreadStart count = new ThreadStart(CountMethod);
            Thread t1 = new Thread(count);
            t1.IsBackground = true;
            t1.Start();

            // Thread.Sleep(2000);
            GameEg ge = new GameEg();
            ge.StartGame();

            Console.WriteLine("Press Any Key to stop");
            Console.ReadKey();
        }
        public static void CountMethod()
        {
            for (int i = 1; i < 25000; i++)
            {
                // Console.WriteLine("Count :{0}",i);
                Console.Write((25000 - i).ToString(), 0, 0);
                Thread.Sleep(500);
            }
        }

    }
}
