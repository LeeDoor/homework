using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery
{
    /// <summary>
    /// a class describing a specific dish 
    /// </summary>
    public class Dish
    {
        /// <summary>
        /// id of dish
        /// </summary>
        public int Id { get; }
        /// <summary>
        /// name of dish
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// price of dish
        /// </summary>
        public decimal Price { get; }
        /// <summary>
        /// amount of calories of dish
        /// </summary>
        public int Calories { get; }
        /// <summary>
        /// is this dish a drink
        /// </summary>
        public bool IsDrink { get; }

        /// <summary>
        /// parametric constructor
        /// </summary>
        public Dish(int id, string name, decimal price, int calories, bool isDrink)
        {
            Name = name;
            Price = price;
            IsDrink = isDrink;
            Id = id;
            Calories = calories;
        }

        /// <summary>
        /// function prints info about dish in console
        /// </summary>
        public void Show()
        {
            (int left, int top) = Console.GetCursorPosition();

            Console.SetCursorPosition(0, top);
            Console.Write(Id+"\t");

            int drink_name_max_length = 20;
            if(Name.Length > drink_name_max_length)
            {
                for(int i = 0; i < drink_name_max_length; i++)
                {
                    Console.Write(Name[i]);
                }
                Console.Write("...   ");
            }
            else
            {
                Console.Write(Name);
                for(int i = 0; i < drink_name_max_length +6 - Name.Length; i++)
                {
                    Console.Write(" ");
                }
            }
            //cursor position 26
            Console.SetCursorPosition(30, top);
            Console.Write($"{Price}rub");

            Console.SetCursorPosition(40, top);
            Console.Write($"{Calories}cal");

            Console.SetCursorPosition(50, top);
            Console.Write($"{(IsDrink?"is a":"not a")} drink\n");
        }
    }
}
