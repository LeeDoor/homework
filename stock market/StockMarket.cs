using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_market
{
    /// <summary>
    /// delegate used for stock price change events and adding new ones
    /// </summary>
    /// <param name="stockName">name of changed stock</param>
    /// <param name="newPrice">new price of changed stock</param>
    public delegate void StockMarkedChanged(string stockName, decimal newPrice);

    public class StockMarket
    {
        /// <summary>
        /// list of stocks on current stock market
        /// </summary>
        public readonly List<Stock> stocks = new ();

        /// <summary>
        /// when the price changes, this event is called
        /// </summary>
        public event StockMarkedChanged? PriceChanged;

        /// <summary>
        /// when the new stock adds, this event is called
        /// </summary>
        public event StockMarkedChanged? StockAdded;

        /// <summary>
        /// function to add new stock
        /// </summary>
        /// <param name="id">id of stock</param>
        /// <param name="name">name of stock</param>
        /// <param name="startPrice">start price of stock</param>
        public void AddStock(int id, string name, decimal startPrice)
        {
            stocks.Add(new Stock(id, name, startPrice));

            Console.WriteLine($"added new stock {name}. start price is {startPrice}\n");

            StockAdded?.Invoke(name, startPrice);
        }

        /// <summary>
        /// function to change price of stock
        /// </summary>
        /// <param name="stock">link on needed stock. use functions GetStockById/GetStockByName</param>
        /// <param name="priceDifference">by what quantity has the price been changed</param>
        public void ChangeStockPrice(Stock stock, decimal priceDifference)
        {
            stock.ChangePrice(priceDifference);

            Console.WriteLine($"{stock.Name} price changed. current price is {stock.Price}\n");

            PriceChanged?.Invoke(stock.Name, stock.Price);
        }

        /// <summary>
        /// get stock using its id
        /// </summary>
        /// <param name="id">id of stock</param>
        /// <returns>link on needed stock</returns>
        public Stock GetStockById(int id)
        {
            return stocks.Where<Stock>(n => n.Id == id).First();
        }

        /// <summary>
        /// get stock using its name
        /// </summary>
        /// <param name="name">name of stock</param>
        /// <returns>link on needed stock</returns>
        public Stock GetStockByName(string name)
        {
            // что будет сдесь лучше?

            return stocks.Where<Stock>(n => n.Name == name).First();

            //foreach (var stock in stocks)
            //{
            //    if (stock.Name == name) return stock;
            //}
            //throw new Exeption();
        }

        public Stock GetStockRandom()
        {
            return stocks[new Random().Next(0, stocks.Count)];
        }

        public void showPrices()
        {
            Console.WriteLine("costs:\n");
            foreach (var stock in stocks)
            {
                Console.WriteLine(stock.ToString());
            }
            Console.WriteLine();
        }

        public void StartOnlineChanges()
        {
            while (true)
            {
                showPrices();
                ChangeStockPrice(GetStockRandom(), new Random().Next(-10,10));
                Console.Read();
                Console.Clear();
            }
        }
    }
}
