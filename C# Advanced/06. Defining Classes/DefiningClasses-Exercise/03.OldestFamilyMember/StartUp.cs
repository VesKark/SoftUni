using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family familyMembers = new Family();
            int countOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfPeople; i++)
            {
                string[] currPerson = Console.ReadLine().Split();
                string name = currPerson[0];
                int age = int.Parse(currPerson[1]);

                familyMembers.AddMember(new Person(name, age));
            }

            Person oldestMember = familyMembers.GetOldestMember();
            Console.WriteLine(oldestMember.Name + " " + oldestMember.Age);
        }
    }
}
