using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Interfaces;

namespace Delivery
{
    public class Eating : ICountCalories, ICountPrice
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
            Dishes = Dishes.OrderBy(n => n.Id).ToList();
        }

        public int CountCalories()
        {
            int buff = 0;
            foreach(var dish in Dishes)
            {
                buff += dish.Calories;
            }
            return buff;
        }

        public decimal CountPrice()
        {
            decimal buff = 0;
            foreach (var dish in Dishes)
            {
                buff += dish.Price;
            }
            return buff;
        }

        public DangerLevel IsAmountNormal(int calories)
        {
            if (400 <= calories && calories <= 600) return DangerLevel.Safe;
            else if (calories < 400) return DangerLevel.Little;
            else return DangerLevel.Alot;
        }
    }
}
