internal class Program
{
    private static void Main(string[] args)
    {
        string[] elements = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();
        Dictionary<string, int> countElements = new Dictionary<string, int>();

        for (int i = 0; i < elements.Length; i++)
        {
            string currElement = elements[i];

            if (!countElements.ContainsKey(currElement))
            {
                countElements.Add(currElement, 0);
            }

            countElements[currElement] += 1;
        }

        List<string> oddCountElements = countElements.Where(x => x.Value % 2 != 0).Select(x => x.Key).ToList();

        Console.WriteLine(String.Join(" ", oddCountElements));
    }
}