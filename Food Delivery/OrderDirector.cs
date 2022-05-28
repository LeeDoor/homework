using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using learn.Interfaces;

namespace learn
{
    public class OrderDirector
    {

        private IOrderBuilder _builder;
        public IOrderBuilder Builder
        {
            set { _builder = value; }
        }

        public void ShowCreatingMenu()
        {

        }

        public void AddEating(EatingTime eatingTime)
        {
            //_builder.BuildEating(eatingTime);
        }
    }
}
