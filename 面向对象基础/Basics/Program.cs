using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat();
            cat.Shout();
            var dog = new Dog();
            dog.Shout();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
