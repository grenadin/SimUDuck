using System;
namespace SimUDuck
{
    public class FlyRocket : IFlyable
    {
        public FlyRocket()
        {
            fly();
        }

        public void fly()
        {
            Console.WriteLine("Fly with power");
        }

      
    }
}
