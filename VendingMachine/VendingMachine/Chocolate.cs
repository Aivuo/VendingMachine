﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Chocolate : Product
    {
        int weight = 0;

        public Chocolate()
        {
            Name = "Chocolate";
            Price = 20;
            weight = 200;
        }

        public Chocolate(int weightIn, int priceIn, string nameIn)
        {
            Name = nameIn;
            Price = priceIn;
            weight = weightIn;
        }

        public override Product Buy(int priceIn, string nameIn)
        {
            Chocolate chocolate = new Chocolate();
            return chocolate;
        }

        public override void Examine()
        {
            Console.WriteLine("\n\t\t{0}" +
                                "\n\t\t\t{1}g" +
                                "\n\t\t\t{2}sek", Name, weight, Price);
        }

        public override void Use()
        {
            Console.WriteLine("\tEat the {0}", Name);
        }
    }
}
