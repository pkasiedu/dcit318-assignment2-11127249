using System;

namespace Inheritance
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    public static class AnimalSpeaker
    {
        public static void SpeakWithLabel(Animal animal)
        {
            string label = animal.GetType().Name;
            Console.Write($"{label} says: ");
            animal.MakeSound();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Inheritance and Method Overriding ===\n");

            Animal[] animals = { new Animal(), new Dog(), new Cat() };
            foreach (var animal in animals)
            {
                AnimalSpeaker.SpeakWithLabel(animal);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
