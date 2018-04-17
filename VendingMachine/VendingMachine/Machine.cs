using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Machine
    {
        List<Product> products = new List<Product>();
        List<Product> boughtProducts = new List<Product>();

        string userInput = null;

        public Machine()
        {
            products.Add(new Soda());
            products.Add(new Chocolate());
        }

        public int BuyProduct(int money)
        {
            PrintProduct(products);

            Console.WriteLine("Write the name of your desired product");
            userInput = Console.ReadLine();

            foreach (var product in products)
            {
                if (product.Name.ToLower() == userInput.ToLower())
                {
                    if (money >= product.Price)
                    {
                        money -= product.Price;
                        var bought = product.Buy();
                        boughtProducts.Add(bought);
                        Console.WriteLine("\tHere's your {0}." +
                            "\n\tYou are welcome",product.Name);
                    }
                    else
                    {
                        Console.WriteLine("\tYou do not have enough money for that {0}",product.Name);
                    }
                }
            }
                return money;
        }

        private void PrintProduct(List<Product> productsIn)
        {
            if (productsIn.Any())
            {
                foreach (var product in productsIn)
                {
                    Console.WriteLine("\n\t\t{0}" +
                                        "\n\t\t\t{1}sek",product.Name, product.Price);
                }
            }
            else
            {
                Console.WriteLine("Oops... There was nothing here!");
            }
        }

        internal void CheckPockets()
        {
            PrintProduct(boughtProducts);
            Console.ReadKey();
        }
    }
}
