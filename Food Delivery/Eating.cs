using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    public class Eating
    {
        public List<Dish> Dishes { get; set; }
        private static readonly int MAX_DISHES = 5;

        public Eating()
        {
            Dishes = new List<Dish>();
        }

        public void AddDish(Dish dish)
        {
            if (Dishes.Count < MAX_DISHES)
            {  // если блюд меньше максимального
                if (Dishes.Where<Dish>(n => n.IsDrink == true).Count() + (dish.IsDrink ? 1 : 0) <= 1)
                { // проверка на допустимое количество напитков
                    Dishes.Add(dish);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("there is 1 drink max");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("too much dishes for one eating. max is 4 dishes and 1 drink or 5 dishes");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void RemoveDish(string name)
        {
            Dishes.Remove(Dishes.Where<Dish>(n=>n.Name == name).First());
        }

        public void Show()
        {
            Console.WriteLine();
            foreach (var dish in Dishes)
            {
                dish.Show();
            }
            Console.WriteLine();
        }

        public void Sort()
        {
            Dishes.OrderByDescending(n => n.Id);
        }
    }
}
