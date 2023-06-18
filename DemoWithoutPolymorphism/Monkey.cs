using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWithoutPolymorphism
{
    class Monkey : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Monkeys whoop.");
        }
    }
}
