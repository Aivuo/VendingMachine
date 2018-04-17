﻿using System;
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

        public override Product Buy()
        {
            Soda soda = new Soda();
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
