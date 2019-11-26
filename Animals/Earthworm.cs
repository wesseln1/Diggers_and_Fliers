using System;

namespace Diggers_and_Fliers
{
    public class Earthworm : IAnimal, IGrounder, IDiggers
    {
        public void clean()
        {
            Console.WriteLine("Worm cage all clean!");
        }

        public void Dig()
        {
            Console.WriteLine("Digging through this earth!");
        }

        public void Ground()
        {
            Console.WriteLine("Just worming around in the rain!");
        }
    }
}