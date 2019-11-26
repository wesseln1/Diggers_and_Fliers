using System;
using System.Collections.Generic;

namespace Diggers_and_Fliers
{
    public class Parakeet : IAnimal, IFly
    {
        public void clean()
        {
            Console.WriteLine("Parakeets cage all clean!");
        }

        public void Fly()
        {
            Console.WriteLine("Just soaring through the sky!");
        }
    }
}