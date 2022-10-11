using System;

namespace Threeuple
{
    class Startup
    {
        static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] drinkTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] bankAccTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Threeuple<string, string, string> person = new Threeuple<string, string, string>
            {
                Item1 = $"{personTokens[0]} {personTokens[1]}",
                Item2 = $"{personTokens[2]}",
                Item3 = $"{personTokens[3]}",
            };

            Threeuple<string, int, bool> drink = new Threeuple<string, int, bool>
            {
                Item1 = $"{drinkTokens[0]}",
                Item2 = int.Parse(drinkTokens[1]),
                Item3 = drinkTokens[2] == "drunk",
            };
            Threeuple<string, double , string> bankAccount = new Threeuple<string, double, string>
            {
                Item1 = bankAccTokens[0],
                Item2 = double.Parse(bankAccTokens[1]),
                Item3 = (bankAccTokens[2]),
            };
            Console.WriteLine(person);
            Console.WriteLine(drink);
            Console.WriteLine(bankAccount);
        }
    }
}
