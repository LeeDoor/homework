using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_market
{
    public delegate void StockMarkedChanged(string stockName, decimal newPrice);
    public class StockMarket
    {
        public readonly List<Stock> stocks = new ();

        public event StockMarkedChanged? PriceChanged;
        public event StockMarkedChanged? StockAdded;

        public void AddStock(int id, string name, decimal startPrice)
        {
            stocks.Add(new Stock(id, name, startPrice));
            StockAdded?.Invoke(name, startPrice);
        }

        public void ChangeStockPrice(Stock stock, decimal priceDifference)
        {
            stock.ChangePrice(priceDifference);
            PriceChanged?.Invoke(stock.Name, stock.Price);
        }

        public Stock getStockById(int id)
        {
            return stocks.Where<Stock>(n => n.Id == id).First();
        }
        public Stock getStockByName(string name)
        {
            // что будет сдесь лучше?

            return stocks.Where<Stock>(n => n.Name == name).First();

            //foreach (var stock in stocks)
            //{
            //    if (stock.Name == name) return stock;
            //}
            //throw new NullReferenceException();
        }
    }
}
