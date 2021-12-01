using StockMarketObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarketObserverPattern
{
    public class Bank : IObserver
    {
        public string Name { get; set; }
        IObservable stock;

        public Bank (string name, IObservable obs)
        {
            Name = name;
            stock = obs;
            stock.RegisterObserver(this);
        }

        public void Update(object ob)
        {
            StockInfo stockInfo = (StockInfo)ob;

            if (stockInfo.USD > 40)
                Console.WriteLine($"Bank {Name} is selling stocks. USD price is {stockInfo.USD}");
            else
                Console.WriteLine($"Bank {Name} is buying stocks. USD price is {stockInfo.USD}");
        }

        public void StopTrading()
        {
            stock.RemoveObserver(this);
            stock = null;
        }
    }
}

