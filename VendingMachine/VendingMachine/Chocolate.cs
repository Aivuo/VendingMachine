using System;
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

        public override Product Buy()
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
            base.Use();
        }
    }
}
