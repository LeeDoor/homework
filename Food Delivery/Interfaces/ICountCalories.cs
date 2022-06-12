using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery.Interfaces
{
    /// <summary>
    /// interface describing classes in which you can calculate the total number of calories
    /// </summary>
    public interface ICountCalories
    {
        public int CountCalories();

        /// <summary>
        /// the function considers whether the number of calories contained here is dangerous
        /// </summary>
        /// <param name="calories">amount of calories</param>
        /// <returns>danger level</returns>
        public DangerLevel IsAmountNormal(int calories);
    }
}
