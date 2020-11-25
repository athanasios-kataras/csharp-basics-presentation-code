using System;
using System.Collections.Generic;

namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Behavioral.Observer
{
    internal class Unsubscriber<Stock> : IDisposable
    {
        private List<IObserver<Stock>> _observers;
        private IObserver<Stock> _observer;

        internal Unsubscriber(List<IObserver<Stock>> observers, IObserver<Stock> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}