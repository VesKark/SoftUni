using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, int> allPresents = new Dictionary<string, int>();
        SortedDictionary<string, int> goodChildren = new SortedDictionary<string, int>();
        string childWish = string.Empty;

        while ((childWish = Console.ReadLine()) != "END")
        {
            string[] currChild = childWish.Split("->");

            // remove not good children from goodChildren-List:
            if (currChild[0] == "Remove")
            {
                if (goodChildren.ContainsKey(currChild[1]))
                {
                    goodChildren.Remove(currChild[1]);
                }
                continue;
            }

            string childName = currChild[0];
            string presentType = currChild[1];
            int presentCount = int.Parse(currChild[2]);

            // add present to allPresents-List:
            if (!allPresents.ContainsKey(presentType))
            {
                allPresents[presentType] = presentCount;
            }
            else
            {
                allPresents[presentType] += presentCount;
            }

            // add child to goodChildren-List:
            if (!goodChildren.ContainsKey(childName))
            {
                goodChildren[childName] = presentCount;
            }
            else
            {
                goodChildren[childName] += presentCount;
            }
        }

        // output children and present lists:
        Console.WriteLine("Children:");
        foreach (var child in goodChildren.OrderByDescending(x => x.Value))
        {
            Console.WriteLine("{0} -> {1}", child.Key, child.Value);
        }

        Console.WriteLine("Presents:");
        foreach (var present in allPresents)
        {
            Console.WriteLine("{0} -> {1}", present.Key, present.Value);
        }
    }
}