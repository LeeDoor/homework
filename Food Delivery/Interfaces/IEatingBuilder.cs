using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn.Interfaces
{
    public interface IEatingBuilder
    {
        public void AddDish(int id);
        public void AddDish(string name);
    }
}
