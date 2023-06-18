using System;

namespace DemoWithoutPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Sounds of the different animals.******");
            Tiger tiger = new Tiger();
            tiger.Sound();

            Dog dog = new Dog();
            dog.Sound();

            Monkey monkey = new Monkey();
            monkey.Sound();
            Console.ReadLine();
        }
    }
}
