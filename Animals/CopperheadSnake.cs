using System;

namespace Diggers_and_Fliers
{
    public class CopperheadSnake : IAnimal, IGrounder
    {
        public void clean()
        {
            Console.WriteLine("Copperhead cage all clean!");
        }

        public void Ground()
        {
            Console.WriteLine("Just slithering around!");
        }
    }
}