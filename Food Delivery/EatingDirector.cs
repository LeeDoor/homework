using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using learn.Interfaces;

namespace learn
{
    public class EatingDirector
    {
        private IEatingBuilder _builder;
        public IEatingBuilder Builder
        {
            set { _builder = value; }
        }

        public void AddDish()
        {
            if (_builder == null) throw new NullReferenceException();
            Console.WriteLine("\nwhich dish do you want to add?\nenter id");
            DishDataBase.Show();
            string? choice = Console.ReadLine();
            if(Int32.TryParse(choice, out int res))
                _builder.AddDish(res);
        }
    }
}
