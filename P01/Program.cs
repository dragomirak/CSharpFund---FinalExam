namespace P01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Finish")
            {
                string[] instructions = input.Split(" ");
                string command = instructions[0];

                if (command == "Replace")
                {
                    string textToReplace = instructions[1];
                    string newText = instructions[2];
                    message = message.Replace(textToReplace, newText);
                    Console.WriteLine(message);
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(instructions[1]);
                    int endIndex = int.Parse(instructions[2]);
                    int count = endIndex - startIndex + 1;

                    if (startIndex < 0 || endIndex > message.Length - 1)
                    {
                        Console.WriteLine("Invalid indices!");
                        continue;
                    }

                    message = message.Remove(startIndex, count);
                    Console.WriteLine(message);
                }
                else if (command == "Make")
                {
                    string type = instructions[1];

                    if (type == "Upper")
                    {
                        message = message.ToUpper();
                    }
                    else if (type == "Lower")
                    {
                        message = message.ToLower();
                    }

                    Console.WriteLine(message);
                }
                else if (command == "Check")
                {
                    string text = instructions[1];

                    if (message.Contains(text))
                    {
                        Console.WriteLine($"Message contains {text}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {text}");
                    }
                }
                else if (command == "Sum")
                {
                    int startIndex = int.Parse(instructions[1]);
                    int endIndex = int.Parse(instructions[2]);
                    int count = endIndex - startIndex + 1;

                    if (startIndex < 0 || endIndex > message.Length - 1)
                    {
                        Console.WriteLine("Invalid indices!");
                        continue;
                    }

                    string text = message.Substring(startIndex, count);
                    char[] charArray = text.ToCharArray();
                    int sum = charArray.Sum(x => x);
                    Console.WriteLine(sum);
                }

            }
        }
    }
}