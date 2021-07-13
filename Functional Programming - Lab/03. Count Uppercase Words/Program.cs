using System;
using System.Linq;
namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> toUpperLetter = word => word[0] == word.ToUpper()[0];

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(word => toUpperLetter(word))
                .ToList()
                .ForEach(word => Console.WriteLine(word));
                
                
        }
    }
}
