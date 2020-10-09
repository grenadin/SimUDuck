using System.Media;


namespace SimUDuck
{
    public class Squeak : IQuackable
    {
        public void quack()
        {
            SoundPlayer soundDuck = new SoundPlayer("C:/Users/harir/source/repos/SimUDuck/SimUDuck/Media/quack.wav");
            soundDuck.PlaySync();
        }
    }
}
