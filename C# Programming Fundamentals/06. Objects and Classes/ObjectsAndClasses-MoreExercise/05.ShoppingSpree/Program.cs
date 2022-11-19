using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            // list of people:
            string[] inputPeople = Console.ReadLine().Split(';');
            List<Person> allPeople = new List<Person>();

            for (int i = 0; i < inputPeople.Length; i++)
            {
                string[] currPerson = inputPeople[i].Split('=');
                string name = currPerson[0];
                double money = double.Parse(currPerson[1]);

                Person thisPerson = new Person(name, money);
                allPeople.Add(thisPerson);
            }

            // list of products:
            string[] inputProducts = Console.ReadLine().Split(';');
            List<Product> allProducts = new List<Product>();

            for (int i = 0; i < inputProducts.Length; i++)
            {
                string[] currProduct = inputProducts[i].Split('=');
                string name = currProduct[0];
                double price = double.Parse(currProduct[1]);

                Product thisProduct = new Product(name, price);
                allProducts.Add(thisProduct);
            }

            // shopping time:
            string letsBuy = string.Empty;

            while ((letsBuy = Console.ReadLine()) != "END")
            {
                string[] shopping = letsBuy.Split();
                string currPerson = shopping[0];
                string currProduct = shopping[1];

                double personMoney = allPeople.Where(n => n.Name == currPerson).Select(p => p.Money).FirstOrDefault();
                double productPrice = allProducts.Where(n => n.Name == currProduct).Select(p => p.Price).FirstOrDefault();
                
                if (personMoney < productPrice)
                {
                    Console.WriteLine($"{currPerson} can't afford {currProduct}");
                }
                else
                {
                    foreach (Person person in allPeople)
                    {
                        if (person.Name == currPerson)
                        {
                            person.Money -= productPrice;
                            Console.WriteLine("{0} bought {1}", currPerson, currProduct);
                            person.BagOfProducts.Add(currProduct);
                            break;
                        }
                    }

                }
            }

            // print products per persons bag:
            foreach (Person person in allPeople)
            {
                if (person.BagOfProducts.Count() == 0)
                {
                    person.BagOfProducts.Add("Nothing bought");
                }

                Console.WriteLine("{0} - {1}", person.Name, string.Join(", ", person.BagOfProducts));
            }
        }
    }

    class Person
    {
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            BagOfProducts = new List<string>();
        }
        public string Name { get; set; }
        public double Money { get; set; }
        public List<string> BagOfProducts { get; set; }

        public void AddProductToBag(string product)
        {
            BagOfProducts.Add(product);
        }
    }

    class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
    }
}
