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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(_order.ToString());
                Console.WriteLine("do you want to add another dish? (y/n)");;
                string? choice = Console.ReadLine();
                if (choice == null || choice == "") throw new NullReferenceException();
                switch (choice[0])
                {
                    case 'y':
                    case 'Y':
                        director.AddDish();
                        break;

                    case 'n':
                    case 'N':
                        flag = false;
                        break;
                }
                _order.Eatings.Add(builder.Eating);
            }

        }

    }
}
