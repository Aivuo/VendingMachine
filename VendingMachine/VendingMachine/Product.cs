using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    abstract class Product
    {
        string name = null;
        int price = 0;

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }

        public virtual Product Buy(int PriceIn, string name)
        {
            return this;
        }

        public virtual void Examine()
        {

        }

        public virtual void Use()
        {

        }
    }
}
