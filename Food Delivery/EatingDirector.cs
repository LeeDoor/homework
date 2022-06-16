using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery
{
    /// <summary>
    /// class needed to communicate with user
    /// </summary>
    public class EatingDirector
    {
        public EatingBuilder? Builder { get; set; }
        
        public void BuildEating()
        {
            if (Builder == null)
            {
                Console.WriteLine("firstly set the builder");
                return;
            }

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
                            Builder.BuildDish(c);
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
                        Builder.BuildPreset(choiceS);
                        break;

                    case '3':
                        Builder._product.Show();
                        Console.WriteLine("which dish do you want to remove?\nenter dish Id:");

                        choiceS = Console.ReadLine();
                        if (string.IsNullOrEmpty(choiceS)) continue;

                        if (Int32.TryParse(choiceS.ToString(), out int choiceint))
                        {
                            Builder.RemoveDish(choiceint);
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

            Builder._product.Sort();
        }
    }
}
