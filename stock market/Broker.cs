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
            Console.WriteLine($"{Name} broker notified about price changes. stock {stockName} => {newPrice}");
        }
    }
}
