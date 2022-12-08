internal class Program
{
    private static void Main(string[] args)
    {
        string activationKey = Console.ReadLine();
        string input = string.Empty;

        while ((input = Console.ReadLine()) != "Generate")
        {
            string[] instructions = input.Split(">>>", StringSplitOptions.None);
            string action = instructions[0];

            if (action == "Contains")
            {
                string substring = instructions[1];

                if (activationKey.Contains(substring))
                {
                    Console.WriteLine($"{activationKey} contains {substring}");
                }
                else
                {
                    Console.WriteLine("Substring not found!");
                }
            }
            else if (action == "Flip")
            {
                string letterCase = instructions[1];
                int startIndex = int.Parse(instructions[2]);
                int endIndex = int.Parse(instructions[3]);

                string outtake = activationKey.Substring(startIndex, endIndex - startIndex);
                string changeCase = string.Empty;

                if (letterCase == "Upper")
                {
                    changeCase = outtake.ToUpper();                    
                }
                else if (letterCase == "Lower")
                {
                    changeCase = outtake.ToLower();
                }

                activationKey = activationKey.Replace(outtake, changeCase);
                Console.WriteLine(activationKey);
            }
            else if (action == "Slice")
            {
                int startIndex = int.Parse(instructions[1]);
                int endIndex = int.Parse(instructions[2]);

                activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                Console.WriteLine(activationKey);
            }
        }

        Console.WriteLine($"Your activation key is: {activationKey}");
    }
}