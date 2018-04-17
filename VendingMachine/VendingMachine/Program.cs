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

            Menu(money);
        }

        private static void Menu(int money)
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
                        money = AddMoney(money);

                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        return;
                    default:
                        break;
                }
            }
        }

        private static int AddMoney(int money)
        {
            int[] valueDenomination = { 5, 10, 20, 50, 100, 200, 500, 1000 };
            int choice = 0;
            int i = valueDenomination.Count() - 1;

            Console.WriteLine(String.Format("\t\tPlease add money to the machine" +
                                            "\n\t\tYou can add any valid Swedish currency except 1Sek coins"));

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
                Console.WriteLine(money + " " + i);
            }
            Console.WriteLine("Here is your change back: {0}sek", choice);
            Console.ReadKey();
            return money;



        }
    }
}
