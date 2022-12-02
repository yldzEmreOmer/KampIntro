using Methods;

class Program
{
    static void Main(string[] args)
    {
       Product product1= new Product();
        product1.Name = "Apple";
        product1.Price = 10;
        product1.Description = "Amasya Apple";

       Product product2= new Product();
        product2.Name = "Watermelon";
        product2.Price = 100;
        product2.Description = "Karpuz";

        Product[] products= new Product[] { product1, product2 };

        foreach (var product in products )
        {
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Price);
            Console.WriteLine(product.Description); 
            Console.WriteLine("----------------------------");
        }

        BasketManager basketManager= new BasketManager();
        basketManager.Add(product1);
    }
}

