using System;
using System.Linq;

namespace FindTheOddInt
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please insert list of integers followed by commas, e.g 6,4,9,11");
            var input = Console.ReadLine();
            var numbers = ParseInput(input);
            if (numbers == null)
            {
                Console.WriteLine("Invalid input.");
                return;
            }
            var oddInt = new FindTheOddInt().Do(numbers);
            Console.WriteLine("The odd integer in the provided list is: {0}", oddInt);
            Console.ReadKey();
        }

        static int[] ParseInput(string input)
        {
            try
            {
                var result = input
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x.Trim()))
                    .ToArray();
                return result.Length > 0 ? result : null;
            }
            catch
            {
                return null;
            }
        }
    }
}