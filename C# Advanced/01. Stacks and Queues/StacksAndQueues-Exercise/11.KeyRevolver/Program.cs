using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {        
        // input:
        int bulletPrice = int.Parse(Console.ReadLine());
        int sizeGunBarrel = int.Parse(Console.ReadLine());
        int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int intelligencePrice = int.Parse(Console.ReadLine());

        Stack<int> allBullets = new Stack<int>(bullets);
        Queue<int> allLocks = new Queue<int>(locks);

        // shoot the locks front-to-back, while going through the bullets back-to-front:
        int barrel = sizeGunBarrel;

        while (allBullets.Count > 0 && allLocks.Count > 0)
        {
            if (allBullets.Pop() <= allLocks.Peek())
            {
                Console.WriteLine("Bang!");
                allLocks.Dequeue();
            }
            else
            {
                Console.WriteLine("Ping!");
            }

            barrel--;

            if (barrel == 0 && allBullets.Count > 0)
            {
                Console.WriteLine("Reloading!");
                barrel = sizeGunBarrel;
            }
        }

        // output:        
        if (allLocks.Count == 0)
        {
            int bulletsTotalPrice = bulletPrice * (bullets.Length - allBullets.Count);
            int moneyEarned = intelligencePrice - bulletsTotalPrice;
            Console.WriteLine($"{allBullets.Count} bullets left. Earned ${moneyEarned}");
        }
        else if (allBullets.Count == 0)
        {
            Console.WriteLine($"Couldn't get through. Locks left: {allLocks.Count}");
        }
    }
}