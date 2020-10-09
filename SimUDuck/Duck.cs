using System;
using System.Collections.Generic;
using System.Text;


namespace SimUDuck
{
    public abstract class Duck
    {
        public IFlyable flyable;
        public IQuackable quackable;


        public Duck()
        {
        }

        public abstract void Display();
        public void PerformFly()
        {
            flyable.fly();
        }

        public void PerformQuack()
        {
            quackable.quack();
        }

        public void swim()
        {
            Console.WriteLine("Float on the water");
        }

        public void setFly(IFlyable fb)
        {
            flyable = fb;
        }
       
    }
}
