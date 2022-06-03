

namespace learn
{
    public static class DishDataBase
    {
        static List<Dish> Dishes { get; }

        static DishDataBase()
        {
            Dishes = new List<Dish>();

            Dishes.Add(new Dish(0, "chicken leg", 215, 70, false));
            Dishes.Add(new Dish(1, "vegetable salad", 35, 50, false));
            Dishes.Add(new Dish(2, "orange juice", 45, 60, true));
        }

        public static void Show()
        {
            Console.WriteLine("id\tcost\tcals\tdrink\tname");
            foreach(Dish dish in Dishes)
            {
                Console.WriteLine(dish);
            }
            Console.WriteLine('\n');
        }

        public static Dish getDish(int id)
        {
            foreach(var dish in Dishes)
            {
                if (dish.id == id) return dish;
            }
            return Dishes[0];
        }
        public static Dish getDish(string name)
        {
            foreach (var dish in Dishes)
            {
                if (dish.name == name) return dish;
            }
            return Dishes[0];
        }
    }
}
