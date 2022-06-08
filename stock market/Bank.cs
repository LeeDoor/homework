using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_market
{
    public class Bank: Communicator
    {
        public Bank(string name) : base(name)
        {
        }

        public Bank(string name, StockMarket market) : base(name, market)
        {
        }

        public override void PriceChangeReact(string stockName, decimal newPrice)
        {
            Console.WriteLine($"{Name} bank notified about price changes. stock {stockName} => {newPrice}") ; 
        }
    }
}
