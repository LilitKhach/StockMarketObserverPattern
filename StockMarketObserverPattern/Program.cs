using System;

namespace StockMarketObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            Bank bank = new Bank("AmeriaBank", stock);
            Investor broker = new Investor("Henrik Mkhitaryan", stock);
            // Stok market process imitation
            stock.Market();
            // broker stop tracking market process
            broker.StopTrading();
            // Stok market process imitation
            stock.Market();

            Console.Read();
        }
    }
}
