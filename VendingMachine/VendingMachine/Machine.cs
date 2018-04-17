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
                if (product.Name.ToLower()
                                .First() == userInput.ToLower()
                                                     .First())
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
            Console.ReadKey();
                return money;
        }

        private void PrintProduct(List<Product> productsIn)
        {
            if (productsIn.Any())
            {
                foreach (var product in productsIn)
                {
                    product.Examine();
                }
            }
            else
            {
                Console.WriteLine("Oops... There was nothing here!");
            }
        }

        internal void CheckPockets()
        {
            if (boughtProducts.Any())
            {
                foreach (var product in boughtProducts)
                {
                    product.Examine();
                } 
            }
            Console.ReadKey();
        }
    }
}
