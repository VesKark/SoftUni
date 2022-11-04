using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input username:
            string username = Console.ReadLine();

            // Generating password:
            string password = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            // Checking password from user:
            string inputPassword = Console.ReadLine();
            int countWrongInput = 0;

            while (inputPassword != password)
            {                
                countWrongInput++;
                if (countWrongInput == 4)
                {
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                inputPassword = Console.ReadLine();
            }

            // Final output:
            if (countWrongInput == 4)
            {
                Console.WriteLine($"User {username} blocked!");
            }
            else
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
