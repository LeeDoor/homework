using stock_market;

public static class Program {
    public static void Main()
    {
        StockMarket market = new();


        Communicator[] communicators = new Communicator[]
        {
            new Bank("Sbebrank", market),
            new Bank("Sovkombank", market),
            new Broker("MasterBroker", market),
            new Broker("MegaBroker", market)
        };

        market.AddStock(0, "Dollar", 70);
        market.AddStock(1, "Euro", 100);

        market.StartOnlineChanges();
    }
}
