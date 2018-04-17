using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Soda : Product
    {
        public Soda()
        {
            Name = "Soda";
            Price = 10;
        }

        public override Product Buy()
        {
            Soda soda = new Soda();
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
