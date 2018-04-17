using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    abstract class Product
    {
        protected string name = null;
        protected int price = 0;

        public virtual void Buy()
        {

        }

        public virtual void Examine()
        {

        }

        public virtual void Use()
        {

        }
    }
}
