using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Chips : Product
    {
        public Chips()
        {

        }

        public override Product Buy(int priceIn, string nameIn)
        {
            Chips soda = new Chips();
            return soda;
        }

        public override void Examine()
        {
            base.Examine();
        }

        public override void Use()
        {
            base.Use();
        }
    }
}
