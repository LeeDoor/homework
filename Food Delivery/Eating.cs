using learn.Interfaces;

namespace learn
{
    public class Eating : ICalories, ICost
    {
        public EatingTime eatingTime { get; }
        private List<Dish> dishes;

        public Eating() {
            eatingTime = EatingTime.Breakfast;
            dishes = new List<Dish>();
        }
        public Eating(EatingTime eatingTime) : this()
        {
            this.eatingTime = eatingTime;
        }

        public void addDish(int id)
        {
            dishes.Add(DishDataBase.getDish(id));
        }
        public void addDish(string name)
        {
            dishes.Add(DishDataBase.getDish(name));
        }

        public int countCalories()
        {
            throw new NotImplementedException();
        }

        public float countCost()
        {
            throw new NotImplementedException();
        }

        public string getDangerLevelCalories()
        {
            throw new NotImplementedException();
        }
    }
}
