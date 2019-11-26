using System;
using System.Collections.Generic;

namespace Diggers_and_Fliers
{
    class Program
    {
        static void Main(string[] args)
        {
            var allan = new Ant();
            var bill = new BettaFish();
            var cole = new CopperheadSnake();
            var ethan = new Earthworm();
            var fish = new Finch();
            var george = new Gerbil();
            var minnie = new Mice();
            var paul = new Parakeet();
            var terry = new Terrapins();
            var tim = new TimberRattleSnake();

            List<IAnimal> allAnimals = new List<IAnimal>()
            {
                allan,
                bill,
                cole,
                ethan,
                fish,
                george,
                minnie,
                paul,
                tim
            };

            List<ISwim> swimmingAnimalContainer = new List<ISwim>()
            {
                terry,
                bill
            };

            List<IGrounder> groundAnimalContainer = new List<IGrounder>()
            {
                cole,
                george,
                minnie,
                tim
            };

            List<IFly> flyingAnimalContainer = new List<IFly>()
            {
                fish,
                paul
            };

            List<IDiggers> diggingAnimalContainer = new List<IDiggers>()
            {
                ethan,
                allan
            };

            foreach (var bird in flyingAnimalContainer)
            {
                bird.Fly();
            }
            foreach (var digger in diggingAnimalContainer)
            {
                digger.Dig();
            }
            foreach (var animal in groundAnimalContainer)
            {
                animal.Ground();
            }
            foreach (var swimmer in swimmingAnimalContainer)
            {
                swimmer.Swim();
            }
            foreach (var animal in allAnimals)
            {
                animal.clean();
            }

        }
    }
}