using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery
{
    /// <summary>
    /// the static class contains all kinds of dishes in the database, as well as methods for obtaining these dishes via id and name
    /// </summary>
    public static class DishDatabase
    {
        /// <summary>
        /// list of dishes
        /// </summary>
        public static List<Dish> Dishes { get; private set; } = new()
        {
            new Dish(0, "Банан", 15, 25, false),
            new Dish(1, "Огурец", 12, 31,  false),
            new Dish(2, "брынза", 266, 262,  false),
            new Dish(3, "йогурт", 60, 57,  false),
            new Dish(4, "кефир", 70, 40,  true),
            new Dish(5, "молоко", 100, 45,  true),
            new Dish(6, "сметана", 64, 119,  false),
            new Dish(7, "каша овсянная", 30, 333,  false),
            new Dish(8, "каша рисовая", 32, 333,  false),
            new Dish(9, "фасолевый суп", 200, 54,  false),
            new Dish(10, "Апельсиновый сок 0,5л", 70, 200, true)
        };

        /// <summary>
        /// function created to get dish with its name
        /// </summary>
        /// <param name="name">name of dish</param>
        /// <returns>link on your dish or null, if your name is uncorrect</returns>
        public static Dish? GetDish(string name) 
        {
            return Dishes.Where<Dish>(n => n.Name == name).FirstOrDefault();
        }

        /// <summary>
        /// function created to get dish with its id
        /// </summary>
        /// <param name="id">id of your dish</param>
        /// <returns>link on your dish or null, if your id is uncorrect</returns>
        public static Dish? GetDish(int id)
        {
            return Dishes.Where<Dish>(n => n.Id == id).FirstOrDefault();
        }

        public static Dish[] GetDishes(params string[] names)
        {
            Dish[] dishes = new Dish[names.Length];
            for(int i = 0; i < names.Length; i++)
            {
                Dish? buff = GetDish(names[i]);
                if (buff == null) 
                    throw new ArgumentException();
                else 
                    dishes[i] = buff;
                
            }
            return dishes;
        }

        /// <summary>
        /// prints info about all dishes in database
        /// </summary>
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
