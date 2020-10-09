using System.Media;
using System;

namespace SimUDuck
{
    public class Quack : IQuackable
    {
        public Quack()
        {

        }
        public void quack()
        {
            Console.WriteLine("เป็ดร้อง");
            SoundPlayer soundDuck = new SoundPlayer("C:/Users/harir/source/repos/SimUDuck/SimUDuck/Media/quack.wav");
            soundDuck.PlaySync();
        }
    }
}
