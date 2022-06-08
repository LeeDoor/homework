using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using learn.Interfaces;

namespace learn
{
    public class EatingBuilder : IEatingBuilder
    {
        private Eating _eating = new Eating();
        public Eating Eating { get { return _eating; } }
        
        public EatingBuilder(EatingTime eatingTime)
        {
            Reset(eatingTime);
        }

        public void Reset(EatingTime eatingTime)
        {
            _eating = new Eating(eatingTime);
        }

        

        public void AddDish(int id)
        {
            _eating.addDish(id);
        }
        public void AddDish(string name)
        {
            _eating.addDish(name);
        }
    }
}
