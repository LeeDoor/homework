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
            Console.WriteLine("\nwhich dish do you want to add?\nenter the number of your choice:\n");
            DishDataBase.Show();

            string? choice;
            int intChoice;
            choice = Console.ReadLine();
            if (choice == null) throw new NullReferenceException();
            if(int.TryParse(choice, out intChoice))
            {
                _builder.AddDish(intChoice);
            }
            else
            {
                _builder.AddDish(choice);
            }
            
        }
    }
}
