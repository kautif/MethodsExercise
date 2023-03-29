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

            var sum = Add(1, 2, 3, 4, 5);

            Console.WriteLine(sum);

            var multiples = Multiply(1, 2, 3, 4, 5);
            Console.WriteLine(multiples);

        }

        public static int Add(params int[] numbers)
        {
            int sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
            }

            Console.WriteLine("Sum: ", sum);
            return sum;
        }

        public static int Multiply(params int[] numbers)
        {
            int product = 1;

            foreach (int n in numbers)
            {
                product *= n;
            }

            Console.WriteLine("Product: ", product);
            return product;
        }
    }
}
