internal class Program
{
    private static void Main(string[] args)
    {
        int numberOfWords = int.Parse(Console.ReadLine());
        Dictionary<string, List<string>> wordSynonyms = new Dictionary<string, List<string>>();

        for (int i = 0; i < numberOfWords; i++)
        {
            string word = Console.ReadLine();
            string synonym = Console.ReadLine();

            if (!wordSynonyms.ContainsKey(word))
            {
                wordSynonyms.Add(word, new List<string> { synonym });
            }
            else
            {
                wordSynonyms[word].Add(synonym);
            }
        }

        foreach (var word in wordSynonyms)
        {
            Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
        }
    }
}