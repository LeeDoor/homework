using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    public class Dish
    {
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }
        public int Calories { get; }
        public bool IsDrink { get; }

        public Dish(int id, string name, decimal price, int calories, bool isDrink)
        {
            Name = name;
            Price = price;
            IsDrink = isDrink;
            Id = id;
            Calories = calories;
        }

        public override string ToString()
        {
            return $"{Id} \t {Name} \t {Price}rub \t {Calories}cal \t {IsDrink} drink";
        }

        public void Show()
        {
            (int left, int top) = Console.GetCursorPosition();

            Console.SetCursorPosition(0, top);
            Console.Write(Id+"\t");

            int drink_name_max_length = 20;
            if(Name.Length > 10)
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
            Console.Write($"{Price}rub\t{Calories}cal\t{IsDrink} drink\n");
        }
    }
}
