using System;
using System.Collections.Generic;

namespace Diggers_and_Fliers
{
    public class Terrapins : IAnimal, ISwim
    {
        public void clean()
        {
            Console.WriteLine("Terrapins cage all clean!");
        }

        public void Swim()
        {
            Console.WriteLine("Glub glub, Im swiming!");
        }
    }
}