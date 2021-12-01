using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarketObserverPattern.Interfaces
{
    public interface IObserver
    {
        void Update(Object ob);
    }
}
