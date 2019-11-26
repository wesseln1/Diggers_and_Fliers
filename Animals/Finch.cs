using System;
using System.Collections.Generic;

namespace Diggers_and_Fliers
{
    public class Finch : IAnimal, IFly
    {
        public void clean()
        {
            Console.WriteLine("Finch cage all clean!");
        }

        public void Fly()
        {
            Console.WriteLine("Being a finch thats flying all around");
        }
    }
}