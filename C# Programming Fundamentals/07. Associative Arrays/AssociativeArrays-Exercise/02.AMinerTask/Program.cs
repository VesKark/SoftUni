internal class Program
{
    private static void Main(string[] args)
    {
        string resource = string.Empty;
        Dictionary<string, int> mineResources = new Dictionary<string, int>();

        while ((resource = Console.ReadLine()) != "stop")
        {
            int quantity = int.Parse(Console.ReadLine());

            if (!mineResources.ContainsKey(resource))
            {
                mineResources.Add(resource, quantity);
            }
            else
            {
                mineResources[resource] += quantity;
            }
        }

        foreach (var currResource in mineResources)
        {
            Console.WriteLine($"{currResource.Key} -> {currResource.Value}");
        }
    }
}