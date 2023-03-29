namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("What is your favorite Band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Here's a story about {name}. They bought a {color} car with a giant {animal} sticker plastered on the side and they took {band} for a ride in their car");
        }
    }
}
