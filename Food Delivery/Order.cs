using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    public class Order
    {
        public int Duration { get; set; }
        public Dictionary<EatingTime, Eating> Eatings { get; private set; }

        public Order()
        {
            Eatings = new();
        }

        public void AddEating(EatingTime eatingTime, Eating eating)
        {
            Eatings.Add(eatingTime, eating);
        }

        public void Show()
        {
            foreach(var pair in Eatings)
            {
                switch (pair.Key)
                {
                    case EatingTime.Breakfast:
                        Console.WriteLine("breakfast:");
                        break;
                    case EatingTime.MorSnack:
                        Console.WriteLine("morning snack:");
                        break;
                    case EatingTime.Lunch:
                        Console.WriteLine("lunch:");
                        break;
                    case EatingTime.EveSnack:
                        Console.WriteLine("evening snack:");
                        break;
                    case EatingTime.Dinner:
                        Console.WriteLine("dinner:");
                        break;
                }

                pair.Value.Show();
            }
        }
    }
}
