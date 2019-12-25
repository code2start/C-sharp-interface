using System;

namespace my_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimable a = new Lion();
            a.eat();
            a = new Fish();
            a.eat();
        }
    }
}
