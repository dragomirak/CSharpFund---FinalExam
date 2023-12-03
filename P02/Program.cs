using System.Text.RegularExpressions;

namespace P02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(@|#{1,})(?<color>[a-z]{3,})(@|#{1,})([^a-zA-Z0-9]*)(\/{1,})(?<number>[0-9]+)(\/{1,})";

            foreach (Match match in Regex.Matches(text, pattern))
            {
                Console.WriteLine($"You found {match.Groups["number"].Value} {match.Groups["color"].Value} eggs!");
            }
        }
    }
}