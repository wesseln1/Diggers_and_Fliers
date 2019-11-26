using System;

namespace Diggers_and_Fliers
{
    public class Gerbil : IAnimal, IGrounder, IDiggers
    {
        public void clean()
        {
            Console.WriteLine("Gerbil cage all clean!");
        }

        public void Dig()
        {
            Console.WriteLine("Diggin out my burro!");
        }

        public void Ground()
        {
            Console.WriteLine("Just sniffing around!");
        }
    }
}