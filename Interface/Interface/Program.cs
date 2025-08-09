using System;

namespace Interface
{
    public interface IMovable
    {
        void Move();
    }

    public class Car : IMovable
    {
        public void Move() => Console.WriteLine("Car is moving");
    }

    public class Bicycle : IMovable
    {
        public void Move() => Console.WriteLine("Bicycle is moving");
    }

    internal static class MovementDemo
    {
        public static void Show(IMovable movable)
        {
            Console.WriteLine($"{movable.GetType().Name} demonstration:");
            movable.Move();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Interfaces ===\n");

            MovementDemo.Show(new Car());
            MovementDemo.Show(new Bicycle());

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
