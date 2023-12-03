using System.ComponentModel.Design;

namespace P03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" | ").ToArray();
            Dictionary<string, string> wordsMap = new Dictionary<string, string>();

            foreach (string s in input)
            {
                string[] words = s.Split(": ");
                string word = words[0];
                string definition = words[1];

                if (wordsMap.ContainsKey(word) == false)
                {
                    wordsMap[word] = definition;
                }
                else
                {
                    wordsMap[word] += $" - {definition}";
                }
            }

            string wordsToTestOn;
            List<string> wordsToCheck = new List<string>();
            while ((wordsToTestOn = Console.ReadLine()) != "Test")
            {
                if (wordsToTestOn == "Hand Over")
                {
                    foreach (KeyValuePair<string, string> kvp in wordsMap)
                    {
                        Console.Write($"{kvp.Key} ");
                    }
                    return;
                }

                wordsToCheck = wordsToTestOn.Split(" | ").ToList();
            }

            foreach (string word in wordsToCheck)
            {
                if (wordsMap.ContainsKey(word))
                {
                    Console.WriteLine($"{word}:");

                    string[] wordValues = wordsMap[word].Split(" - ").ToArray();
                    foreach (string wordValue in wordValues)
                    {
                        Console.WriteLine($"-{wordValue}");
                    }
                }
            }
        }
    }
}