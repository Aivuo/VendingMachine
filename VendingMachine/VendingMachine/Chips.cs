using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Chips : Product
    {
        int weight = 0;

        public Chips()
        {
            Name = "Crisps";
            Price = 15;
            weight = 180;
        }

        public override Product Buy(int priceIn, string nameIn)
        {
            Chips soda = new Chips();
            return soda;
        }

        public override void Examine()
        {
            Console.WriteLine("\n\t\t{0}" +
                    "\n\t\t\t{1}g" +
                    "\n\t\t\t{2}sek", Name, weight, Price);
        }

        public override void Use()
        {
            Console.WriteLine("\tNom the {0}", Name);
        }
    }
}
