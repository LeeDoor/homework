using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food_Delivery.Interfaces;

namespace Food_Delivery
{
    /// <summary>
    /// class builds eating
    /// </summary>
    public class EatingBuilder : IEatingBuilder
    {
        /// <summary>
        /// total eating we are creating
        /// </summary>
        public Eating _product = new Eating();

        /// <summary>
        /// function adds dishes in list
        /// </summary>
        public void BuildDishes()
        {
            bool flag = true;
            string? choiceS;
            char choiceC;


            while (flag)
            {
                Console.WriteLine("do you want to do?\n" +
                    "1 - add any dish\n" +
                    "2 - set any preset\n" +
                    "3 - remove dish\n" +
                    "4 - quit");

                choiceS = Console.ReadLine();
                if (string.IsNullOrEmpty(choiceS)) continue;
                choiceC = choiceS[0];


                switch (choiceC)
                {
                    case '1':
                        DishDatabase.Show();
                        Console.WriteLine("what do you want to add?\nenter Id:");

                        choiceS = Console.ReadLine();
                        if (string.IsNullOrEmpty(choiceS)) continue;

                        if (Int32.TryParse(choiceS.ToString(), out int c))
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

                    case '2':
                        Preset.Show();
                        Console.WriteLine("which preset do you want to set?\nenter preset name:");

                        choiceS = Console.ReadLine();
                        if (string.IsNullOrEmpty(choiceS)) continue;

                        Eating? eatingPreset = Preset.GetPreset(choiceS);
                        if (eatingPreset == null) continue;

                        _product = eatingPreset;
                        break;

                    case '3':
                        _product.Show();
                        Console.WriteLine("which dish do you want to remove?\nenter dish Id:");

                        choiceS = Console.ReadLine();
                        if (string.IsNullOrEmpty(choiceS)) continue;

                        if (Int32.TryParse(choiceS.ToString(), out int choiceint))
                        {
                            Dish? dishBuff = DishDatabase.GetDish(choiceint);
                            if (dishBuff == null) continue;
                            if (_product.Dishes.Contains(dishBuff))
                            {
                                _product.Dishes.Remove(dishBuff);
                            }
                        }
                        break;

                    case '4':
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
