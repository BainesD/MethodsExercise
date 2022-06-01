using System;

namespace MethodExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What is your name?"); // greeting
            var name = Console.ReadLine(); // user input 1
            Console.WriteLine($"Hello, {name}, I will tell you a story if you give me some infromation." +
                "\nWhat is your favorite color?");
            var favColor = Console.ReadLine(); // user fav color
            Console.WriteLine($"Thanks, {name}, what about your favorite animal?");
            var favAnimal = Console.ReadLine();
            Console.WriteLine("Lastly, what's your favorite band?");
            var favBand = Console.ReadLine();
            Console.WriteLine($"Great! here it goes!\nA long time ago a brave hero, named {name}, appeared in a " +
                $"troubled, mystical land.\nOn a quest to save the land, {name} met a {favColor} {favAnimal}.\nTogether" +
                $" they saved the world, and all the citizens of the land threw an amazing party " +
                $"with live music performed by,\nyou guessed it, {favBand}!\nThe End!");


        }
    }
}
