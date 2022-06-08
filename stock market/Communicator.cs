using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_market
{
    public class Communicator
    {
        public string Name { get; private set; }
        public Dictionary<string, decimal> optimalPrice = new Dictionary<string, decimal>();

        public Communicator(string name)
        {
            Name = name;
        }
        public Communicator(string name, StockMarket market) : this(name)
        {
            SubscribeToMarket(market);
        }

        public void SubscribeToMarket(StockMarket stockMarket)
        {
            stockMarket.PriceChanged += PriceChangeReact;
            stockMarket.StockAdded += NewStockReact;

            optimalPrice = new Dictionary<string, decimal>();

            foreach(var stock in stockMarket.stocks)
            {
                NewStockReact(stock.Name, stock.Price);
            }
        }

        public void NewStockReact(string name, decimal currentPrice)
        {
            optimalPrice[name] = currentPrice + (decimal)new Random().Next(-50, 50);
        }

        public virtual void PriceChangeReact(string stockName, decimal newPrice)
        {
            Console.WriteLine($"{Name} notified about price changes. stock {stockName} => {newPrice}");
        }

        public void ShowOptimalPrices()
        {
            Console.WriteLine($"{Name} : ");
            foreach (var pair in optimalPrice)
            { 
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }
            Console.WriteLine();
        }
    }
}

