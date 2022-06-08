using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_market
{
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
