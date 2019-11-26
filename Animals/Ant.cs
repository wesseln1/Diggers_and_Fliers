using System;
using System.Collections.Generic;

namespace Diggers_and_Fliers
{
    public class Ant : IAnimal, IDiggers, IGrounder
    {
        public void clean()
        {
            Console.WriteLine("Ant cage all clean!");
        }

        public void Dig()
        {
            Console.WriteLine("Im dig dig digging!");
        }

        public void Ground()
        {
            Console.WriteLine("Im moving above the ground!");
        }
    }
}