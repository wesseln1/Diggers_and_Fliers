using System;
using System.Collections.Generic;

namespace Diggers_and_Fliers
{
    public class BettaFish : IAnimal, ISwim
    {
        public void clean()
        {
            Console.WriteLine("Betta fish cage all clean!");
        }

        public void Swim()
        {
            Console.WriteLine("Glub glub, Im swiming!");
        }
    }
}