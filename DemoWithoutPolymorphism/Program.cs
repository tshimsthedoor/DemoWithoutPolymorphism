using System;

namespace DemoWithoutPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Sounds of the different animals.******");
            IAnimal animal = new Tiger();
            animal.Sound();

            animal = new Dog();
            animal.Sound();

            animal = new Monkey();
            animal.Sound();
            Console.ReadLine();
        }
    }
}
