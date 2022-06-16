using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food_Delivery.Interfaces;

namespace Food_Delivery
{
    /// <summary>
    /// class builds eating
    /// </summary>
    public class EatingBuilder
    {
        /// <summary>
        /// total eating we are creating
        /// </summary>
        public Eating _product = new Eating();

        /// <summary>
        /// adds any dish from db
        /// </summary>
        /// <param name="id">id of chosen dish</param>
        public void BuildDish(int id)        {
            Dish? buff = DishDatabase.GetDish(id);
            if (buff != null)
            {
                _product.AddDish(buff);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("wrong data");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        /// <summary>
        /// sets list of dishes using preset
        /// </summary>
        /// <param name="choiceS">name of preset</param>
        public void BuildPreset(string choiceS)
        {
            Eating? eatingPreset = Preset.GetPreset(choiceS);
            if (eatingPreset == null)
            {
                Console.WriteLine("no preset with this name");
                return;
            }
            _product = eatingPreset;
        }

        /// <summary>
        /// removes dish from list
        /// </summary>
        /// <param name="choiceint">id of chosen dish</param>
        public void RemoveDish(int choiceint)
        {
            Dish? dishBuff = DishDatabase.GetDish(choiceint);
            if (dishBuff == null)
            {
                Console.WriteLine("you have no dish with its id");
                return;
            }
            if (_product.Dishes.Contains(dishBuff))
            {
                _product.Dishes.Remove(dishBuff);
            }
        }
    }
}
