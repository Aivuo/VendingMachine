using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Soda : Product
    {
        int cl = 0;

        public Soda()
        {
            Name = "Soda";
            Price = 10;
            cl = 33;
        }

        public Soda( int priceIn, string nameIn)
        {
            Name = nameIn;
            Price = priceIn;
            if (priceIn == 16)
            {
                cl = 50;
            }
            else if (priceIn == 20)
            {
                cl = 100;
            }
        }

        public override Product Buy(int priceIn,string nameIn)
        {
            Soda soda = new Soda(priceIn, nameIn);
            return soda;
        }

        public override void Examine()
        {
            Console.WriteLine("\n\t\t{0}" +
                    "\n\t\t\t{1}cl" +
                    "\n\t\t\t{2}sek", Name, cl, Price);
        }

        public override void Use()
        {
            base.Use();
        }
    }
}
