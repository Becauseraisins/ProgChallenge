using System;
using System.Collections.Generic;
using System.Linq;
namespace progchallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> rolls = new List<int>();
            Console.Write("Want to Roll the dice? y/n: ");
            string yes = Console.ReadLine();
            int letmeout = 0;
            if (yes == "n")
            {
                letmeout++;
            }
            else if (yes != "y")
            {
                Console.WriteLine("Invalid Input, closing");
                yes = "n";
                letmeout = 2;
            }
            while (letmeout == 0)
            {
                int randomNumber = rand.Next(1, 7);
                Console.WriteLine("You Rolled {0}", randomNumber);
                rolls.Add(randomNumber);
                Console.Write("Roll again? y/n: ");
                string yesno = Console.ReadLine();

                if (yesno == "n")
                {
                    letmeout++;
                }
                else if (yesno != "y")
                {
                    Console.WriteLine("Invalid Input, rolling anyway");
                }
            }
            if (letmeout == 1)
            {
                Console.WriteLine("Your Stats:");
                Console.Write("rolls: ");
                foreach (int num in rolls) Console.Write(num + " ");
                Console.WriteLine("");
                Console.WriteLine("Which rolls do you want to examine?");
                Console.Write("First roll: ");
                int first = int.Parse(Console.ReadLine());
                Console.Write("First roll to: ");
                int second = (int.Parse(Console.ReadLine()))-first;
                first--;
                int[] rollarray = rolls
                .Skip(first)
                .Take(second)
                .ToArray();
                Console.Write("Rolls being examined: ");
                foreach (int num in rollarray) Console.Write(num + " ");
                Console.WriteLine("");
                Console.WriteLine("The total is {0}", rollarray.Sum());
                Console.WriteLine("The average is {0}", rollarray.Average());
            }
            if (yes == "n")
            {
                Console.WriteLine("Goodbye");
            }



        }
    }
}
