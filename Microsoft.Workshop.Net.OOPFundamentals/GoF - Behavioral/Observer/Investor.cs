using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Observer
{
    public class Investor : IObserver<Stock>
    {
        private List<Stock> portfolio;
        private IDisposable cancellation;

        public Investor(StockService stockService)
        {
            cancellation = stockService.Subscribe(this);
        }

        public void OnNext(Stock value)
        {
            var currentStock = portfolio.Where(_ => value.Name == _.Name).FirstOrDefault();
            if (currentStock == null)
            {
                return;
            }
            if (currentStock.Rate < value.Rate)
            {
                // Sell stock
            }
            else
            {
                currentStock.Rate = value.Rate;
            }
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            // NoImplementation
        }
    }
}