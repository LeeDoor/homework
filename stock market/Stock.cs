using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_market
{
	public class Stock
    {
        public int Id { get; private set; }

        /// <summary>
        /// name of this stock
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// price of stock
        /// </summary>
        public decimal Price { get; private set; }

        /// <summary>
        /// construct
        /// </summary>
        public Stock(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        /// <summary>
        /// changes current price of stock
        /// </summary>
        /// <param name="costDifference">the difference in cost</param>
        public void ChangePrice(decimal costDifference)
        {
            Price += costDifference;
        }
    }
}
