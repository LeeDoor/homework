using stock_market;

public static class Program {
    public static void Main()
    {
        StockMarket market = new();

        Bank bank1 = new Bank("Sbebrank", market);
        Bank bank2 = new Bank("Sovkombank", market);

        Broker broker1 = new Broker("MasterBroker", market);
        Broker broker2 = new Broker("MegaBroker", market);

        market.AddStock(0, "Dollar", 70);
        market.AddStock(1, "Euro", 100);
        market.AddStock(2, "Vk", 15);
        market.AddStock(3, "MTS", 150);
        market.AddStock(4, "Yandex", 200);

        bank1.ShowOptimalPrices();
        bank2.ShowOptimalPrices();

        /*todo
         * сделать валидацию новых цен
         * красивое отображение текущих цен и реакций коммуникаторов
         * комментарии и сумари
         * сделать режим изменения цен в реальном времени ( раз в несколько секунд акция меняет стоимость на несколько рублей)
         */
    }
}
