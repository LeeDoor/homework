using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    public static class DishDatabase
    {
        public static List<Dish> Dishes { get; private set; } = new()
        {
            new Dish(0, "Банан", 15, 25, false),
            new Dish(1, "Огурец", 12, 31,  false),
            new Dish(2, "Апельсиновый сок 0,5л", 70, 200, true)
        };

        public static Dish GetDish(string name) 
        {
            return Dishes.Where<Dish>(n => n.Name == name).First();
        }

        public static Dish GetDish(int id)
        {
            return Dishes.Where<Dish>(n => n.Id == id).First();
        }

        public static void Show()
        {
            foreach(var dish in Dishes)
            {
                dish.Show();
                Console.WriteLine();
            }
        }
    }
}
