using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    { 
        // input:
		int stations = int.Parse(Console.ReadLine());
		
		Queue<int> literPerStation = new Queue<int>();
		Queue<int> distanceToStation = new Queue<int>();
		
		for (int i = 0; i < stations; i++)
		{
			int[] parameter = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int liter = parameter[0];
			int distance = parameter[1];
			
			literPerStation.Enqueue(liter);
			distanceToStation.Enqueue(distance);
		}
		
		// find smallest index of the petrol pump from which we can start the tour:		
		int countStations = 0;
		
		for (int i = 0; i < stations; i++)
		{
			int sumLiter = 0;
			int sumDinstance = 0;
			int index = 0;
			bool findStation = false;
			
			while (sumLiter >= sumDinstance)
			{
				sumLiter += literPerStation.Peek();
				sumDinstance += distanceToStation.Peek();
				countStations++;
				index++;
				
				literPerStation.Enqueue(literPerStation.Dequeue());
				distanceToStation.Enqueue(distanceToStation.Dequeue());
				
				if (index == stations)
				{
					findStation = true;
					break;
				}
			}
			
			if (findStation)
			{
				Console.WriteLine(countStations - stations);
				break;
			}
		}		
    }
}
