using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Delivery.Interfaces
{
    /// <summary>
    /// interface describing classes in which the final cost can be calculated
    /// </summary>
    public interface ICountPrice
    {
        /// <summary>
        /// counts total price
        /// </summary>
        /// <returns>returns price</returns>
        public decimal CountPrice();
    }
}
