using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAINING
{
     class Animal
    {
        public virtual void Move()
        {
            Console.WriteLine("All animals move");
        }

        public void Sleep()
        {
            Console.WriteLine("ZZZZZZZZZZZZZZZZ");

        }
        public void Eat()
        {
            Console.WriteLine("much much");
        }
    }

}
