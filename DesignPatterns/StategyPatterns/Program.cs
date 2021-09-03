using System;

namespace StategyPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            =======================================================
            Strategy pattern
            =======================================================
            The strategy pattern(also known as the policy pattern) is a behavioral software design pattern 
            that enables selecting an algorithm at runtime. Instead of implementing a single algorithm directly, 
            code receives run - time instructions as to which in a family of algorithms to use.
            */

            Animal dog = new Dog();
            Animal bird = new Bird();

            dog.setName("Doggy");
            bird.setName("Tweety");

            Console.WriteLine($"Dog: \nName={dog.getName()} \nSound={dog.getSound()} \nFlying Ability= {dog.tryToFly()} \n\n");
            Console.WriteLine($"Bird: \nName={bird.getName()} \nSound={bird.getSound()} \nFlying Ability= {bird.tryToFly()} \n\n");

            dog.setFlyingAbility(new ItFlys());
            bird.setFlyingAbility(new CantFly());

            Console.WriteLine($"Dog: Now {dog.tryToFly()} :)");
            Console.WriteLine($"Bird: Now {bird.tryToFly()} :)");

            Console.ReadLine();

        }
    }
}
