using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    class MallardDuck : Duck
    {

        public MallardDuck()
        {
            Console.WriteLine("I'm mallard duck");
            quackable = new Quack();
            flyable = new FlyWithWing();
        }
        public override void Display()
        {
            Console.WriteLine("Real mallard duck");
        }
    }
}
