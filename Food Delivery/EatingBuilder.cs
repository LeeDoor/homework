using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    public class EatingBuilder : IEatingBuilder
    {
        public Eating _product = new Eating();



        public void BuildDishes()
        {
            bool flag = true;
            string? choiceS;
            char choiceC;


            while (flag)
            {
                Console.WriteLine("do you want to add another dish here? y/n");

                choiceS = Console.ReadLine();
                if (string.IsNullOrEmpty(choiceS)) continue;
                choiceC = choiceS[0];


                switch (choiceC)
                {
                    case 'y':
                    case 'Y':
                        DishDatabase.Show();
                        Console.WriteLine("what do you want to add?\nenter Id:");

                        choiceS = Console.ReadLine();
                        if (string.IsNullOrEmpty(choiceS)) continue;

                        choiceC = choiceS[0];

                        if (Int32.TryParse(choiceC.ToString(), out int c))
                        {
                            Dish? buff = DishDatabase.GetDish(c);
                            if (buff != null) 
                            {
                                _product.AddDish(buff);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("wrong data");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("wrong data");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;

                    case 'n':
                    case 'N':
                        flag = false;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("wrong data");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
            
            _product.Sort();
        }
    }
}
