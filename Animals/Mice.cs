using System;

namespace Diggers_and_Fliers
{
    public class Mice : IAnimal, IGrounder, IDiggers
    {
        public void clean()
        {
            Console.WriteLine("Mice cage all clean!");
        }

        public void Dig()
        {
            Console.WriteLine("Dig Dig Dig!");
        }

        public void Ground()
        {
            Console.WriteLine("Just running all around!");
        }
    }
}