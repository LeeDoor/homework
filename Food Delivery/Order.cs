using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food_Delivery.Interfaces;

namespace Food_Delivery
{
    /// <summary>
    /// complete order with a list of meals
    /// </summary>
    public class Order : ICountCalories, ICountPrice
    {
        /// <summary>
        /// order duration in days
        /// </summary>
        public int Duration { get; set; } = 1;

        /// <summary>
        /// KEY - name of meal
        /// VALUE - eating
        /// </summary>
        public Dictionary<EatingTime, Eating> Eatings { get; private set; }

        /// <summary>
        /// standart constructor
        /// </summary>
        public Order()
        {
            Eatings = new();
        }

        /// <summary>
        /// adds eating to dictionary
        /// </summary>
        /// <param name="eatingTime">name of eating time</param>
        /// <param name="eating">link on eating</param>
        public void AddEating(EatingTime eatingTime, Eating eating)
        {
            Eatings.Add(eatingTime, eating);
        }

        /// <summary>
        /// prints info about eatings
        /// </summary>
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
