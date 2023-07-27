using Lab06_BuiltaZoo.Classes;

namespace Lab06_BuiltaZoo
{
    internal class Program
    {
        static void Main()
        {
            // Create instances of different animals
            Cat cat = new Cat("Tiffany", "Orange");
            Dog dog = new Dog("Shoney", "Brown");
            Chicken chicken = new Chicken("Henry", false);
            Duck duck = new Duck("Donald", true);
            Snake snake = new Snake("Steven", true);
            Iguana iguana = new Iguana("Patagonia", true);

            // Demonstrate behaviors and properties of each animal
            cat.Eat();
            cat.Sleep();
            cat.WarmBlooded();
            Console.WriteLine($"Cat sound: {cat.Sound()}");
            Console.WriteLine($"Cat fur color: {cat.FurColor}");
            Console.WriteLine($"Cat family: {cat.Family}");
            Console.WriteLine($"Cat habitat: {cat.Habitat}");
            Console.WriteLine();

            dog.Eat();
            dog.Sleep();
            dog.Swim();
            dog.WarmBlooded();
            Console.WriteLine($"Dog sound: {dog.Sound()}");
            Console.WriteLine($"Dog fur color: {dog.FurColor}");
            Console.WriteLine($"Dog family: {dog.Family}");
            Console.WriteLine($"Dog habitat: {dog.Habitat}");
            Console.WriteLine();

            chicken.Eat();
            chicken.Sleep();
            chicken.WarmBlooded();
            chicken.LayingEggs();
            Console.WriteLine($"Chicken sound: {chicken.Sound()}");
            Console.WriteLine($"Chicken can fly: {chicken.canFly}");
            Console.WriteLine($"Chicken family: {chicken.Family}");
            Console.WriteLine($"Chicken habitat: {chicken.Habitat}");
            Console.WriteLine();

            duck.Eat();
            duck.Sleep();
            duck.Swim();
            duck.WarmBlooded();
            duck.LayingEggs();
            Console.WriteLine($"Duck sound: {duck.Sound()}");
            Console.WriteLine($"Duck can fly: {duck.canFly}");
            Console.WriteLine($"Duck family: {duck.Family}");
            Console.WriteLine($"Duck habitat: {duck.Habitat}");
            Console.WriteLine();

            snake.Eat();
            snake.Sleep();
            snake.Swim();
            snake.ColdBlooded();
            snake.LayingEggs();
            Console.WriteLine($"Snake sound: {snake.Sound()}");
            Console.WriteLine($"Snake has scales: {snake.HasScales}");
            Console.WriteLine($"Snake family: {snake.Family}");
            Console.WriteLine($"Snake habitat: {snake.Habitat}");
            Console.WriteLine();

            iguana.Eat();
            iguana.Sleep();
            iguana.ColdBlooded();
            iguana.LayingEggs();
            Console.WriteLine($"Iguana sound: {iguana.Sound()}");
            Console.WriteLine($"Iguana has scales: {iguana.HasScales}");
            Console.WriteLine($"Iguana family: {iguana.Family}");
            Console.WriteLine($"Iguana habitat: {iguana.Habitat}");
            Console.WriteLine();
        }
    }
}