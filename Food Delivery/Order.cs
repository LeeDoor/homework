using learn.Interfaces;

namespace learn
{
    public class Order : ICalories, ICost
    {
        public List<Eating> Eatings { get; }
        private int duration;

        public Order()
        {
            Eatings = new List<Eating>();
        }


        public int countCalories()
        {
            int calories = 0;
            foreach(var eating in Eatings)
            {
                calories += eating.countCalories();
            }
            return calories;
        }

        public float countCost()
        {
            float sum = 0f;
            foreach (var eating in Eatings)
            {
                sum += eating.countCost();
            }
            return sum;
        }

        public string getDangerLevelCalories()
        {
            int calories = countCalories();
            int normalMin = 2600 / 7 * Eatings.Count;
            int normalMax = 3200 / 7 * Eatings.Count;

            if(calories < normalMin)
            {
                return "Not enough";
            }
            else if(normalMin <= calories && calories <= normalMax)
            {
                return "Perfect";
            }
            return "too much";
        }
    }
}
