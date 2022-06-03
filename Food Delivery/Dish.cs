using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn
{
    public class Dish
    {
        public int id;
        public string name;
        public int calories;
        public decimal price;
        public bool isDrink;

        public Dish(int id, string name, int calories, decimal price, bool isDrink)
        {
            this.id = id;
            this.name = name;
            this.calories = calories;
            this.price = price;
            this.isDrink = isDrink;
        }

        public override string ToString()
        {
            return id.ToString() + "\t" + price.ToString() + "\t" + calories.ToString() + '\t' + isDrink.ToString() + '\t' + name;
        }
    }
}
