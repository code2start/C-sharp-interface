using System;
using System.Collections.Generic;
using System.Text;

namespace my_interface
{
    class Fish : IAnimable
    {
        public void eat()
        {
            Console.WriteLine("Eating herbs or small fish");
        }

        public void Walk()
        {
            Console.WriteLine("Walking by swimming....");
        }
    }
}
