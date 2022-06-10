using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Interfaces
{
    public interface ICountCalories
    {
        public int CountCalories();
        public DangerLevel IsAmountNormal(int calories);
    }
}
