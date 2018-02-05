using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        try
        {
            var listOfPeople = new List<Person>();
            var buyers = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var nameOfBuyer = String.Empty;
            var money = 0;
            for (int i = 0; i < buyers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    nameOfBuyer = buyers[i];
                }
                else
                {
                    money = int.Parse(buyers[i]);
                    var person = new Person(nameOfBuyer, money);
                    listOfPeople.Add(person);
                }
            }

            var listOfProducts = new List<Product>();
            var products = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var productName = String.Empty;
            var cost = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (i % 2 == 0)
                {
                    productName = products[i];
                }
                else
                {
                    cost = int.Parse(products[i]);
                    var product = new Product(productName, cost);
                    listOfProducts.Add(product);
                }
            }

            var command = Console.ReadLine().Split().ToArray();
            while (command[0] != "END")
            {
                var buyer = command[0];
                var product = command[1];
                var currentBuyer = listOfPeople.Where(p => p.Name == buyer).FirstOrDefault();
                var currentProduct = listOfProducts.Where(p => p.Name == product).FirstOrDefault();

                if (currentBuyer.Money >= currentProduct.Cost)
                {
                    currentBuyer.BagOfProducts.Add(currentProduct);
                    currentBuyer.Money -= currentProduct.Cost;
                    Console.WriteLine($"{currentBuyer.Name} bought {currentProduct.Name}");
                }
                else
                {
                    Console.WriteLine($"{currentBuyer.Name} can't afford {currentProduct.Name}");
                }

                command = Console.ReadLine().Split().ToArray();
            }

            foreach (var person in listOfPeople)
            {
                if (person.BagOfProducts.Any())
                {
                    Console.WriteLine($"{person.Name} - {String.Join(", ", person.BagOfProducts.Select(x => x.Name))}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}