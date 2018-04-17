using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 0;
            int[] valueDenomination = { 5, 10, 20, 50, 100, 200, 500, 1000 };

            Menu(money, valueDenomination);
        }

        private static void Menu(int money, int[] valueDenomination)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\tMoney: {0:N0}sek" +
                                "\n\t1: Add money" +
                                "\n\t2: Buy something" +
                                "\n\t3: Leave", money);

                var input = Console.ReadKey();

                switch (input.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        money = AddMoney(money, valueDenomination);

                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        money = DumpMoney(money, valueDenomination);
                        return;
                    default:
                        break;
                }
            }
        }

        private static int DumpMoney(int money, int[] valueDenomination)
        {
            int i = valueDenomination.Count() - 1;
            string type = "Bill";
            while (money > 0)
            {
                if (money >= valueDenomination[i])
                {
                    money -= valueDenomination[i];
                    Console.WriteLine("\t{0}sek {1}", valueDenomination[i], type);
                }
                if (money < valueDenomination[i])
                {
                    i--;
                    if (i == 1)
                    {
                        type = "Coin";
                    }
                }
            }
            Console.ReadKey();
            return money;
        }

        private static int AddMoney(int money, int[] valueDenomination)
        {
            int choice = 0;
            int i = valueDenomination.Count() - 1;

            Console.WriteLine(String.Format("\t\tPlease add money to the machine" +
                                            "\n\t\tYou can add any valid Swedish currency except 1sek coins"));

            int.TryParse(Console.ReadLine(), out choice);

            while (choice >= valueDenomination[0])
            {
                if (choice >= valueDenomination[i])
                {
                    money += valueDenomination[i];
                    choice -= valueDenomination[i];
                }
                if (choice < valueDenomination[i])
                {
                    i--;
                }
            }
            if (choice > 0)
            {
                Console.WriteLine("Here is your change back: {0}sek", choice);
                Console.ReadKey();
            }
            return money;
        }
    }
}
