using System;
using System.Collections.Generic;
using System.Text;

namespace my_interface
{
    class Lion : IAnimable
    {
        public void eat()
        {
            Console.WriteLine("Eating meat....");
        }

        public void Walk()
        {
            Console.WriteLine("Walking by 4 legs");
        }
    }
}
