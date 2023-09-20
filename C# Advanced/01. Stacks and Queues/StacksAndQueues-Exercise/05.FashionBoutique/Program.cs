using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
		int rackCapacity = int.Parse(Console.ReadLine());
		
		int countRacks = 1;
		int currRack = 0;
		
		while(clothes.Count > 0)
		{
			if (currRack + clothes.Peek() <= rackCapacity)
			{
				currRack += clothes.Pop();
			}
			else
			{
				countRacks += 1;
				currRack = 0;
			}
		}
		
		Console.WriteLine(countRacks);
    }
}
