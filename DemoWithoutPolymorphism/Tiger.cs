﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWithoutPolymorphism
{
    class Tiger : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Tigers roar.");
        }
    }
}
