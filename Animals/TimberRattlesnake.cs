using System;
using System.Collections.Generic;

namespace Diggers_and_Fliers
{
    public class TimberRattleSnake : IAnimal, IGrounder
    {
        public void clean()
        {
            Console.WriteLine("Rattlesnake cage all clean!");
        }

        public void Ground()
        {
            Console.WriteLine("Just slithering around!");
        }
    }
}