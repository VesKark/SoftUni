internal class Program
{
    private static void Main(string[] args)
    {
        int numberOfCommands = int.Parse(Console.ReadLine());
        Dictionary<string, string> parking = new Dictionary<string, string>();

        for (int i = 0; i < numberOfCommands; i++)
        {
            string[] parkingInfo = Console.ReadLine().Split();
            string registerData = parkingInfo[0];
            string username = parkingInfo[1];

            if (registerData == "register")
            {
                string plateNr = parkingInfo[2];

                if (parking.ContainsKey(username))
                {
                    Console.WriteLine($"ERROR: already registered with plate number {plateNr}");
                }
                else
                {
                    parking.Add(username, plateNr);
                    Console.WriteLine($"{username} registered {plateNr} successfully");
                }
            }
            else if (registerData == "unregister")
            {
                if (!parking.ContainsKey(username))
                {
                    Console.WriteLine($"ERROR: user {username} not found");
                }
                else
                {
                    parking.Remove(username);
                    Console.WriteLine($"{username} unregistered successfully");
                }
            }
        }

        foreach (var user in parking)
        {
            Console.WriteLine($"{user.Key} => {user.Value}");
        }
    }
}