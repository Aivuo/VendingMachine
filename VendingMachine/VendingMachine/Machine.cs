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
            products.Add(new Soda(16, "Caco-Calo"));
            products.Add(new Soda(20, "Spreti"));
            products.Add(new Chocolate());
        }

        public int BuyProduct(int money)
        {
            PrintProduct(products);

            Console.WriteLine("Write the name of your desired product");
            userInput = Console.ReadLine();

            foreach (var product in products)
            {

                string productName = product.Name;
                productName = productName.Take(2)
                                         .ToString()
                                         .ToLower();            //Fel fortfarande men felet är att den inte sätter ihop Take2 till en string av Char utan tar hela skiten
                userInput = userInput.Take(2).                   //Så variabelnamn och kallelser Allt. Något som kanske kan funka är en flatten! Kolla upp
                                     .ToString()
                                     .ToLower();

                if (productName == userInput)
                {
                    if (money >= product.Price)
                    {
                        money -= product.Price;
                        var bought = product.Buy(product.Price, product.Name);
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
