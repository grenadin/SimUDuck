using System;

namespace SimUDuck
{
    public class MuteQuack : IQuackable
    {
        public void quack()
        {
            Console.WriteLine("Silent");
        }
    }
}
