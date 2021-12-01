using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarketObserverPattern.Interfaces
{
    public interface IObservable
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
