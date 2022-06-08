using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_market
{
    /// <summary>
    /// base class for banks and brokers interacting with the exchange
    /// </summary>
    public class Communicator
    {
        /// <summary>
        /// title of company
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// dictionary of optimal prices on stocks. set randomly
        /// 
        /// key - name of stock
        /// value - optimal price for this stock
        /// </summary>
        public Dictionary<string, decimal> optimalPrice = new Dictionary<string, decimal>();


        /// <summary>
        /// constructor with name
        /// </summary>
        /// <param name="name">name of communicator</param>
        public Communicator(string name)
        {
            Name = name;
        }

        /// <summary>
        /// constructor with name and market for auto subscribe to it
        /// </summary>
        /// <param name="name">name of new communicator</param>
        /// <param name="market">stock market we need to subscribe</param>
        public Communicator(string name, StockMarket market) : this(name)
        {
            SubscribeToMarket(market);
        }

        /// <summary>
        /// function for subscribing to the exchange
        /// </summary>
        /// <param name="stockMarket">name of exchange</param>
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

        /// <summary>
        /// the function of reaction to the appearance of a new asset on the exchange
        /// </summary>
        /// <param name="name">name of new stock</param>
        /// <param name="currentPrice">its start price</param>
        public void NewStockReact(string name, decimal currentPrice)
        {
            optimalPrice[name] = currentPrice + (decimal)new Random().Next(-50, 50);
        }

        /// <summary>
        /// функция реакции на изменение стоимости существующего актива
        /// </summary>
        /// <param name="stockName">name of new stock</param>
        /// <param name="newPrice">its start price</param>
        public virtual void PriceChangeReact(string stockName, decimal newPrice)
        {
            Console.WriteLine($"{Name} notified about price changes. stock {stockName} => {newPrice}");
        }

        /// <summary>
        /// debugging function to show the preferences of this communicator
        /// </summary>
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

