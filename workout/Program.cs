using System;
using System.Linq;
using System.Text;

namespace workout
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new int[] { 10, 20, 30, 40, 50 };
            var query = numbers.ElementAtOrDefault(5);
            Console.WriteLine(query);
        }
    }
}
