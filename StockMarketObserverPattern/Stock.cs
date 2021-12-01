using StockMarketObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarketObserverPattern
{
    public class Stock : IObservable
    {
        private StockInfo _stockInfo;
        List<IObserver> Observers;

        public Stock()
        {
            Observers = new List<IObserver>();
            _stockInfo = new StockInfo();
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in Observers)
                o.Update(_stockInfo);
        }

        public void RegisterObserver(IObserver o)
        {
            Observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            Observers.Remove(o);
        }

        public void Market()
        {
            Random rnd = new Random();
            _stockInfo.USD = rnd.Next(20, 50);
            _stockInfo.EUR = rnd.Next(20, 50);
            NotifyObservers();
        }
    }
}
