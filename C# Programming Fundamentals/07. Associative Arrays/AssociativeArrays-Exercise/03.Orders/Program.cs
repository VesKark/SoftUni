internal class Program
{
    private static void Main(string[] args)
    {
        string input = string.Empty;
        Dictionary<string, ProductData> productCatalog = new Dictionary<string, ProductData>();

        while ((input = Console.ReadLine()) != "buy")
        {
            string[] inputProduct = input.Split();
            string productName = inputProduct[0];
            double productPrice = double.Parse(inputProduct[1]);
            int productQty = int.Parse(inputProduct[2]);

            ProductData productData = new ProductData(productPrice, productQty);

            if (!productCatalog.ContainsKey(productName))
            {
                productCatalog.Add(productName, productData);
            }
            else 
            {
                if (productCatalog[productName].Price != productPrice)
                {
                    productCatalog[productName].Price = productPrice;
                }

                productCatalog[productName].Quantity += productQty;
            }
        }

        foreach (var product in productCatalog)
        {
            double totalPrice = product.Value.Price * product.Value.Quantity;
            Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
        }
    }
}

class ProductData
{
    public ProductData(double price, int quantity)
    {
        Price = price;
        Quantity = quantity;
    }

    public double Price { get; set; }
    public int Quantity { get; set; }
}