using System;
using DesignPatterns.BehaviorPatterns.Observer.Observable;

namespace DesignPatterns.BehaviorPatterns.Observer.Observer
{
    public class Broker : IObserver
    {
        private readonly IObservable _stock;
        public Broker(IObservable stock)
        {
            _stock = stock;
            _stock.AddObserver(this);
        }

        public void Update()
        {
            Console.WriteLine("Broker detected CurrentValue changed: " + ((Stock)_stock).CurrencyValue);
        }

        public void StopObserve()
        {
            _stock.RemoveObserver(this);
        }
    }
}