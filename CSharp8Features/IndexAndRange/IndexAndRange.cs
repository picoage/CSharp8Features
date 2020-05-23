using System;
using System.Collections.Generic;

namespace CSharp8Features.IndexAndRange
{
    internal class IndexAndRange
    {
        static string[] ingredients = new[]
        {
            "Flour", "Egg", "Sugar", "Butter"
        };

        static List<int> numbers = new List<int> { 1, 2, 3, 5 };

        internal static void Index()
        {
            Console.WriteLine(ingredients[^2]);
            Console.WriteLine(numbers[^2]);
        }

        internal static void Range()
        {
            string[] q = ingredients[^3..^1];

            foreach(var v in q)
            {
                Console.WriteLine($"Subrange value:{v}"); 
            }
        }
    }
}
