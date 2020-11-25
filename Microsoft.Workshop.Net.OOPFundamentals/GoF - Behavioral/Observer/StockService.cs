using System;
using System.Collections.Generic;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Observer
{
    public class StockService : IObservable<Stock>
    {
        private List<IObserver<Stock>> observers = new List<IObserver<Stock>>();
        private static readonly List<Stock> stocks = new List<Stock>();

        public IDisposable Subscribe(IObserver<Stock> observer)
        {
            // Check whether observer is already registered. If not, add it
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                // Provide observer with existing data.
                foreach (var item in stocks)
                    observer.OnNext(item);
            }
            return new Unsubscriber<Stock>(observers, observer);
        }

        public bool AddStock(Stock stock) {
            stocks.Add(stock);
            foreach(var observer in observers) {
                observer.OnNext(stock);
            }
            return true;
        }
    }
}