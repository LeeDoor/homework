using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    public class OrderBuilder
    {
        public Order _product = new();

        public Order BuildOrder()
        {
            _product = new Order();

            bool flag = true;
            while (flag)
            {
                string? choiceS;
                char choiceC;

                Console.WriteLine($"\norder creating menu");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nDuration => {_product.Duration}");
                Console.ForegroundColor = ConsoleColor.White;

                switch (_product.IsAmountNormal(_product.CountCalories()))
                {
                    case DangerLevel.Little:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"{_product.CountCalories()} cal\nwarning: not enough for a day!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                    case DangerLevel.Safe:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{_product.CountCalories()} cal");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                    case DangerLevel.Alot:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{_product.CountCalories()} cal\nwarning: too much calories, my fatty boy!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }


                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine($"{_product.CountPrice()} rub");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;

                Console.WriteLine(
                    $"\n1 - set duration (days)" +
                    $"\n2 - add eating (прием пищи)" +
                    $"\n3 - show current order");

                choiceS = Console.ReadLine();
                if (string.IsNullOrEmpty(choiceS)) continue;
                choiceC = choiceS[0];

                switch (choiceC)
                {
                    case '1':
                        BuildDuration();
                        break;
                    case '2':
                        BuildEating();
                        break;

                    case '3':
                        _product.Show();
                        break;
                }
                Console.WriteLine("press any key...");
                Console.ReadKey();
                Console.Clear();
            }
            return _product;
        }

        private void BuildDuration()
        {
            string? choiceS;
            Console.WriteLine("enter duration (in days):");

            choiceS = Console.ReadLine();
            if (string.IsNullOrEmpty(choiceS)) return;
            choiceS = choiceS[0].ToString();

            if (Int32.TryParse(choiceS, out int duration))
            {
                _product.Duration = duration;
            }
            else
            {
                Console.WriteLine("wrong data");
            }
        }
        private void BuildEating()
        {
            string? choiceS;
            char choiceC;
            EatingTime eatingTime = EatingTime.Null;
            while (eatingTime == EatingTime.Null)
            {
                Console.WriteLine("enter day time for your eating" +
                    "\n1 - breakfast" +
                    "\n2 - morning snack" +
                    "\n3 - lunch" +
                    "\n4 - evening snack" +
                    "\n5 - dinner");

                choiceS = Console.ReadLine();
                if (string.IsNullOrEmpty(choiceS)) continue;
                choiceC = choiceS[0];

                switch (choiceC)
                {
                    case '1':
                        eatingTime = EatingTime.Breakfast;
                        break;
                    case '2':
                        eatingTime = EatingTime.MorSnack;
                        break;
                    case '3':
                        eatingTime = EatingTime.Lunch;
                        break;
                    case '4':
                        eatingTime = EatingTime.EveSnack;
                        break;
                    case '5':
                        eatingTime = EatingTime.Dinner;
                        break;
                    default:
                        Console.WriteLine("wrong data. try again");
                        break;
                }
            }
            if (!_product.Eatings.ContainsKey(eatingTime))
            {
                EatingBuilder builder = new EatingBuilder();
                builder.BuildDishes();
                _product.AddEating(eatingTime, builder._product);
            }
            else
            {
                EatingBuilder builder = new EatingBuilder();
                builder._product = _product.Eatings[eatingTime];
                builder.BuildDishes();
            }
        }
    }
}
