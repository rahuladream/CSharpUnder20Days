using System;
using System.Text.RegularExpressions;

namespace RegExApplication
{
    class Program
    {
        private static void showMatch(string text, string expr)
        {
            Console.WriteLine("The expression : " + expr);
            MatchCollection mc = Regex.Matches(text, expr);

            foreach(Match m in mc)
            {
                Console.WriteLine(m);
            }
        }
        static void Main(string[] args)
        {
            string str = "A thousands Spices Sorrounded by Sound";
            Console.WriteLine("Matches words that start with 'S' :");
            showMatch(str, @"\bS\S*");
            Console.ReadKey();
        }
    }
}
