using Lab06_BuiltaZoo.Classes;

namespace Lab06_BuiltaZoo
{
    internal class Program
    {
        static void Main()
        {
            // Instantiate different animals
            Cat cat = new Cat("Whiskers", 4, "Orange");
            Snake snake = new Snake("Slither", 0, true);
            Dog dog = new Dog("Buddy", 4);
            Chicken chicken = new Chicken("Clucky", false);

            // Display information about each animal
            Console.WriteLine($"Cat name: {cat.name}");
            Console.WriteLine($"Cat fur color: {cat.furColor}");
            Console.WriteLine($"Number of legs: {cat.numberOfLegs}");
            cat.Eat();
            cat.Sleep();
            Console.WriteLine($"Cat sound: {cat.Sound()}");
            cat.WarmBlooded();
            Console.WriteLine();

            Console.WriteLine($"Snake name: {snake.name}");
            Console.WriteLine($"Venomous: {snake.venomous}");
            Console.WriteLine($"Number of legs: {snake.numberOfLegs}");
            snake.Eat();
            snake.Sleep();
            Console.WriteLine($"Snake sound: {snake.Sound()}");
            snake.ColdBlooded();
            Console.WriteLine();

            Console.WriteLine($"Dog name: {dog.name}");
            Console.WriteLine($"Number of legs: {dog.numberOfLegs}");
            dog.Eat();
            dog.Sleep();
            Console.WriteLine($"Dog sound: {dog.Sound()}");
            dog.WarmBlooded();
            Console.WriteLine();

            Console.WriteLine($"Chicken name: {chicken.name}");
            Console.WriteLine($"Can fly: {chicken.canFly}");
            chicken.Eat();
            chicken.Sleep();
            Console.WriteLine($"Chicken sound: {chicken.Sound()}");
            Console.WriteLine($"Lays eggs? {chicken.LaysEggs()}");
        }
    }
}