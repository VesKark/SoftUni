internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        SortedDictionary<int, int> numbersWithCount = new SortedDictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            int currNumber = numbers[i];

            if (!numbersWithCount.ContainsKey(currNumber))
            {
                numbersWithCount.Add(currNumber, 0);
            }

            numbersWithCount[currNumber] += 1;
        }

        foreach (var number in numbersWithCount)
        {
            Console.WriteLine($"{number.Key} -> {number.Value}");
        }
    }
}