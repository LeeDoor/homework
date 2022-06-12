using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food_Delivery.Interfaces;

namespace Food_Delivery
{
    /// <summary>
    /// a class describing a single meal, such as breakfast, lunch, dinner
    /// </summary>
    public class Eating : ICountCalories, ICountPrice
    {
        /// <summary>
        /// list of dishes in this single meal
        /// </summary>
        public List<Dish> Dishes { get; set; }

        /// <summary>
        /// max accessable dishes in one single meal
        /// </summary>
        private static readonly int MAX_DISHES = 5;

        /// <summary>
        /// standart constructor
        /// </summary>
        public Eating()
        {
            Dishes = new List<Dish>();
        }

        /// <summary>
        /// adds dish in list with its link
        /// </summary>
        /// <param name="dish">link on your dish</param>
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

        /// <summary>
        /// removes dish from list with its name
        /// </summary>
        /// <param name="name">name of the dish you want to remove</param>
        public void RemoveDish(string name)
        {
            Dishes.Remove(Dishes.Where<Dish>(n=>n.Name == name).First());
        }

        /// <summary>
        /// prints info about dishes in your single meal
        /// </summary>
        public void Show()
        {
            Console.WriteLine();
            foreach (var dish in Dishes)
            {
                dish.Show();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// sorts list of dishes
        /// </summary>
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
