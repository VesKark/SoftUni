using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<string> guestListVIP = new HashSet<string>();
        HashSet<string> guestListRegular = new HashSet<string>();
        string guest = string.Empty;

        while ((guest = Console.ReadLine()) != "PARTY")
        {
            if (char.IsDigit(guest[0]))
            {
                guestListVIP.Add(guest);
            }
            else
            {
                guestListRegular.Add(guest);
            }
        }

        while ((guest = Console.ReadLine()) != "END")
        {
            if (guestListVIP.Contains(guest))
            {
                guestListVIP.Remove(guest);
            }
            else if (guestListRegular.Contains(guest))
            {
                guestListRegular.Remove(guest);
            }
        }

        Console.WriteLine(guestListVIP.Count + guestListRegular.Count);

        foreach (string missingGuest in guestListVIP)
        {
            Console.WriteLine(missingGuest);
        }
        foreach (string missingGuest in guestListRegular)
        {
            Console.WriteLine(missingGuest);
        }
    }
}