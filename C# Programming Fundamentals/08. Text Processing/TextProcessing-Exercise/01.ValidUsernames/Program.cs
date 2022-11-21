internal class Program
{
    private static void Main(string[] args)
    {
        string[] usernames = Console.ReadLine().Split(", ").Where(x => x.Length >= 3 && x.Length <= 16).ToArray();

        foreach (string username in usernames)
        {
            bool validUsername = true;

            foreach (char currChar in username)
            {
                if (!Char.IsLetterOrDigit(currChar) && currChar != 45 && currChar != 95)
                {
                    validUsername = false;
                    break;
                }
            }

            if (validUsername)
            {
                Console.WriteLine(username);
            }
        }
    }
}