using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery
{
    /// <summary>
    /// the class contains a set of presets with power sets
    /// </summary>
    public static class Preset
    {
        /// <summary>
        /// data base
        /// key - name of preset
        /// value - the preset
        /// </summary>
        public static Dictionary<string, Eating> eatings { get; } = new()
        {
            ["пират"] =             new Eating().AddDish(DishDatabase.GetDishes("Банан", "Огурец")),
            ["школьная столовка"] = new Eating().AddDish(DishDatabase.GetDishes("каша овсянная", "йогурт", "Апельсиновый сок 0,5л")),
            ["обед"] =              new Eating().AddDish(DishDatabase.GetDishes("фасолевый суп", "каша рисовая", "молоко"))
        };

        /// <summary>
        /// function to get preset with its name
        /// </summary>
        /// <param name="name">name of preset</param>
        /// <returns>link of preset</returns>
        public static Eating? GetPreset(string name)
        {
            if(eatings.ContainsKey(name)) return eatings[name];
            return null;
        }

        /// <summary>
        /// prints information about available presets 
        /// </summary>
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
