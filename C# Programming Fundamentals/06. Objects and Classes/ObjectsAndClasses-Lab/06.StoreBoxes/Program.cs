using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _06.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> allBoxes = new List<Box>();

            while (input != "end")
            {
                string[] itemData = input.Split();
                string serialNumber = itemData[0];
                string itemName = itemData[1];
                int itemQty = int.Parse(itemData[2]);
                double itemPrice = double.Parse(itemData[3]);
                double boxPrice = itemQty * itemPrice;

                Box currBox = new Box();
                currBox.SerialNumber = serialNumber;
                currBox.Item.ItemName = itemName;
                currBox.Item.ItemPrice = itemPrice;
                currBox.ItemQuantity = itemQty;
                currBox.BoxPrice = boxPrice;

                allBoxes.Add(currBox);

                input = Console.ReadLine();
            }

            allBoxes = allBoxes.OrderByDescending(x => x.BoxPrice).ToList();

            foreach (Box box in allBoxes)
            {
                Console.WriteLine(box);
            }
        }
    }

    class Item
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
    }

    class Box   
    {       
        public Box()
        {
            Item = new Item();
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double BoxPrice { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{SerialNumber}");
            sb.AppendLine($"-- {Item.ItemName} - ${Item.ItemPrice:F2}: {ItemQuantity}");
            sb.AppendLine($"-- ${BoxPrice:F2}");
            return sb.ToString().TrimEnd();
        }
    }
}
