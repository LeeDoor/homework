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

        public EatingBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _eating = new Eating();
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
