using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using learn.Interfaces;

namespace learn
{
    public class OrderBuilder:IOrderBuilder
    {
        private Order _order = new Order();
        public Order Order { get { return _order; } }
        public OrderBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _order = new Order(); 
        }

        public void BuildEating(EatingTime eatingTime)
        {
            EatingDirector director = new EatingDirector();
            EatingBuilder builder = new EatingBuilder(eatingTime);
            director.Builder = builder;
            director.AddDish();
            //_order.
        }

    }
}
