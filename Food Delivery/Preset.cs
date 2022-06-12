using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery
{
    public static class Preset
    {
        public static Dictionary<string, Eating> eatings { get; } = new()
        {
            ["пират"] =             new Eating().AddDish(DishDatabase.GetDishes("Банан", "Огурец")),
            ["школьная столовка"] = new Eating().AddDish(DishDatabase.GetDishes("каша овсянная", "йогурт", "Апельсиновый сок 0,5л")),
            ["обед"] =              new Eating().AddDish(DishDatabase.GetDishes("фасолевый суп", "каша рисовая", "молоко"))
        };

        public static Eating? GetPreset(string name)
        {
            if(eatings.ContainsKey(name)) return eatings[name];
            return null;
        }

        public static void Show()
        {
            foreach(var eating in eatings)
            {
                Console.WriteLine($"{eating.Key} =>");
                eating.Value.Show();
            }
        }
    }
}
