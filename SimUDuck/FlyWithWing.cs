using System;

namespace SimUDuck
{
    public class FlyWithWing : IFlyable
    {
        public void fly()
        {
            Console.WriteLine("I can fly");
        }
    }
}
