using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    public static class DeliveryApp
    {
        public static Order CreateOrder()
        {

            //for (int i = 0; i < 256; i++) { Console.WriteLine(i.ToString() + " : " +(char)i); }

            Order order = new Order();

            bool flag = true;
            while (flag)
            {
                string? choiceS;
                char choiceC;

                Console.WriteLine($"\norder creating menu"); 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nDuration => {order.Duration}");
                Console.ForegroundColor = ConsoleColor.White;
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
                        Console.WriteLine("enter duration (in days):");

                        choiceS = Console.ReadLine();
                        if (string.IsNullOrEmpty(choiceS)) throw new Exception();
                        choiceS = choiceS[0].ToString();

                        if (Int32.TryParse(choiceS, out int duration))
                        {
                            order.Duration = duration;
                        }
                        else
                        {
                            Console.WriteLine("wrong data");
                        }
                        break;
                    case '2':
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
                            if (string.IsNullOrEmpty(choiceS)) throw new Exception();
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
                        if (!order.Eatings.ContainsKey(eatingTime))
                        {
                            EatingBuilder builder = new EatingBuilder();
                            builder.BuildDishes();
                            order.AddEating(eatingTime, builder._product);
                        }
                        else
                        {
                            EatingBuilder builder = new EatingBuilder();
                            builder._product = order.Eatings[eatingTime];
                            builder.BuildDishes();
                        }
                        break;

                    case '3':
                        order.Show();
                        break;
                }
                Console.WriteLine("press any key...");
                Console.ReadKey();
                Console.Clear();
            }
            return order;
        }
    }
}
