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

        private static IAnimal GetAnimal()
        {
            IAnimal animal;
            Random random = new Random();
            // Get a number between 0 and 3(exclusive)
            int temp = random.Next(0, 3);
            if (temp == 0)
            {
                animal = new Tiger();
            }
            else if (temp == 1)
            {
                animal = new Dog();
            }
            else
            {
                animal = new Monkey();
            }
            return animal;
        }
    }
}
