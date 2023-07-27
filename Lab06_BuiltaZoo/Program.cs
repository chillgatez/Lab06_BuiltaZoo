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
            Console.WriteLine($"Cat can swim: {cat.CanSwim}");
            Console.WriteLine($"Cat is nocturnal: {cat.IsNocturnal}");
            Console.WriteLine();

            dog.Eat();
            dog.Sleep();
            dog.WarmBlooded();
            Console.WriteLine($"Dog sound: {dog.Sound()}");
            Console.WriteLine($"Dog fur color: {dog.FurColor}");
            Console.WriteLine($"Dog family: {dog.Family}");
            Console.WriteLine($"Dog habitat: {dog.Habitat}");
            Console.WriteLine($"Dog can swim: {dog.CanSwim}");
            Console.WriteLine($"Dog is nocturnal: {dog.IsNocturnal}");
            Console.WriteLine();

            chicken.Eat();
            chicken.Sleep();
            chicken.WarmBlooded();
            Console.WriteLine($"Chicken sound: {chicken.Sound()}");
            Console.WriteLine($"Chicken can fly: {chicken.canFly}");
            Console.WriteLine($"Chicken family: {chicken.Family}");
            Console.WriteLine($"Chicken habitat: {chicken.Habitat}");
            Console.WriteLine($"Chicken can swim: {chicken.CanSwim}");
            Console.WriteLine($"Chicken is nocturnal: {chicken.IsNocturnal}");
            Console.WriteLine();

            duck.Eat();
            duck.Sleep();
            duck.WarmBlooded();
            duck.Swim();
            Console.WriteLine($"Duck sound: {duck.Sound()}");
            Console.WriteLine($"Duck can fly: {duck.canFly}");
            Console.WriteLine($"Duck family: {duck.Family}");
            Console.WriteLine($"Duck habitat: {duck.Habitat}");
            Console.WriteLine($"Duck can swim: {duck.CanSwim}");
            Console.WriteLine($"Duck is nocturnal: {duck.IsNocturnal}");
            Console.WriteLine();

            snake.Eat();
            snake.Sleep();
            snake.ColdBlooded();
            Console.WriteLine($"Snake sound: {snake.Sound()}");
            Console.WriteLine($"Snake has scales: {snake.HasScales}");
            Console.WriteLine($"Snake family: {snake.Family}");
            Console.WriteLine($"Snake habitat: {snake.Habitat}");
            Console.WriteLine($"Snake can swim: {snake.CanSwim}");
            Console.WriteLine($"Snake is nocturnal: {snake.IsNocturnal}");
            Console.WriteLine();

            iguana.Eat();
            iguana.Sleep();
            iguana.ColdBlooded();
            Console.WriteLine($"Iguana sound: {iguana.Sound()}");
            Console.WriteLine($"Iguana has scales: {iguana.HasScales}");
            Console.WriteLine($"Iguana family: {iguana.Family}");
            Console.WriteLine($"Iguana habitat: {iguana.Habitat}");
            Console.WriteLine($"Iguana can swim: {iguana.CanSwim}");
            Console.WriteLine($"Iguana is nocturnal: {iguana.IsNocturnal}");
            Console.WriteLine();
        }
    }
}