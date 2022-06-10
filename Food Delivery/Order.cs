using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Interfaces;

namespace Delivery
{
    public class Order : ICountCalories, ICountPrice
    {
        public int Duration { get; set; } = 1;
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


        public decimal CountPrice()
        {
            decimal buff = 0;
            foreach (var pair in Eatings)
            {
                buff += pair.Value.CountPrice();
            }
            return buff * Duration;
        }
        public int CountCalories()
        {
            int buff = 0;
            foreach (var pair in Eatings)
            {
                buff += pair.Value.CountCalories();
            }
            return buff * Duration;
        }

        public DangerLevel IsAmountNormal(int calories)
        {
            if (2500 <= calories && calories <= 2800) return DangerLevel.Safe;
            else if (calories < 2500) return DangerLevel.Little;
            else  return DangerLevel.Alot;
        }
        
    }
}
