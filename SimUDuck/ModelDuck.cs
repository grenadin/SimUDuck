using System;

namespace SimUDuck
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            Console.WriteLine("I'm rubber duck");
            flyable = new FlyNoWay();
            quackable = new Quack();
        }
        public override void Display()
        {
            throw new NotImplementedException();
        }
    }
}
