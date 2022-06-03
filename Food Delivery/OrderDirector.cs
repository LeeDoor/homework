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
            Console.WriteLine("for what time do you want to add a meal?\n" +
                "1 - Breakfast\n" +
                "2 - Elevenses\n" +
                "3 - Lunch\n" +
                "4 - Supper\n" +
                "5 - Dinner\n");
            char choice = (char)Console.Read();
            switch (choice)
            {
                case '1':
                    AddEating(EatingTime.Breakfast);
                    break;
                case '2':
                    AddEating(EatingTime.Elevenses);
                    break;
                case '3':
                    AddEating(EatingTime.Lunch);
                    break;
                case '4':
                    AddEating(EatingTime.Supper);
                    break;
                case '5':
                    AddEating(EatingTime.Dinner);
                    break;
            }
        }

        public void AddEating(EatingTime eatingTime)
        {
            _builder.BuildEating(eatingTime);
        }
    }
}
