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

        public OrderBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _order = new Order(); 
        }

        public void BuildEating()
        {
            EatingDirector director = new EatingDirector();
            EatingBuilder builder = new EatingBuilder();
            director.Builder = builder;
            director.AddDish();
            //_order.
        }

    }
}
