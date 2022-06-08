using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_market
{
    /// <summary>
    /// a class describing the broker. the broker's task is to buy assets at a favorable price.
    /// </summary>
    public class Broker : Communicator
    {
        public Broker(string name) : base(name)
        {
        }

        public Broker(string name, StockMarket market) : base(name, market)
        {
        }
        public override void PriceChangeReact(string stockName, decimal newPrice)
        {
            if (ValidatePrice(stockName, newPrice))
            {
                Console.WriteLine($"communicator decided to buy {stockName}");
            }
            else
            {
                Console.WriteLine($"communicator decided to not buy {stockName}");
            }
        }

        protected override bool ValidatePrice(string name, decimal price)
        {
            if (optimalPrice[name] >= price)
            {
                return true;
            }
            return false;
        }
    }
}
