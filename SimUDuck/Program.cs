using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System;
namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();
            Console.WriteLine("----------");

            Duck modelDuck = new ModelDuck();
            modelDuck.PerformFly();
            modelDuck.setFly(new FlyRocket());
            modelDuck.PerformQuack();

        }
    }
}
