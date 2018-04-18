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
        string productName = null;

        public Machine()
        {
            products.Add(new Soda());
            products.Add(new Soda(15, "Caco-Calo"));
            products.Add(new Soda(20, "Spreti"));
            products.Add(new Chocolate());
            products.Add(new Chips());
        }

        public int BuyProduct(int money)
        {
            PrintProduct(products);

            Console.WriteLine("Write the name of your desired product");
            userInput = Console.ReadLine();

            userInput = GetFirstLetters(userInput);

            foreach (var product in products)
            {

                productName = product.Name;
                productName = GetFirstLetters(productName);

                if (userInput == productName)
                {
                    if (money >= product.Price)
                    {
                        money -= product.Price;
                        var bought = product.Buy(product.Price, product.Name);
                        boughtProducts.Add(bought);
                        Console.WriteLine("\tHere's your {0}." +
                            "\n\tYou are welcome", product.Name);
                    }
                    else
                    {
                        Console.WriteLine("\tYou do not have enough money for that {0}", product.Name);
                    }
                }
            }
            Console.ReadKey();
            return money;
        }

        private string GetFirstLetters(string change)
        {
            change = new string(change.ToLower()
                                         .Take(2)
                                         .ToArray());

            return change;
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



                Console.WriteLine("\tWrite the name of the product you want to use");
                userInput = Console.ReadLine();
                userInput = GetFirstLetters(userInput);

                foreach (var product in boughtProducts)
                {
                    productName = product.Name;
                    productName = GetFirstLetters(productName);

                    if (userInput == productName)
                    {
                        product.Use();
                        boughtProducts.Remove(product);
                        Console.ReadKey();
                        return;
                    }
                }

            }
            Console.ReadKey();
        }
    }
}

