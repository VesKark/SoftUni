using System;

namespace _04.CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int voucherValue = int.Parse(Console.ReadLine());
            string chosenProduct = Console.ReadLine();

            // Estimating total number of products/tickets:
            int countTickets = 0;
            int countProducts = 0;
            int productPrice = 0;

            while (chosenProduct != "End")
            {
                if (chosenProduct.Length > 8)
                {
                    productPrice = (char)chosenProduct[0] + (char)chosenProduct[1];
                    if (productPrice > voucherValue)
                    {
                        break;
                    }
                    else
                    {
                        voucherValue -= productPrice;
                        countTickets++;
                    }
                }
                else
                {                    
                    productPrice = (char)chosenProduct[0];
                    if (productPrice > voucherValue)
                    {
                        break;
                    }
                    else
                    {
                        voucherValue -= productPrice;
                        countProducts++;
                    }
                }                                

                chosenProduct = Console.ReadLine();
            }

            // Output:
            Console.WriteLine(countTickets);
            Console.WriteLine(countProducts);
        }
    }
}
