using System;
using DesignPatterns.BehaviorPatterns.Observer.Observable;

namespace DesignPatterns.BehaviorPatterns.Observer.Observer
{
    public class Bank : IObserver
    {
        private readonly IObservable _stock;

        public Bank(IObservable stock)
        {
            _stock = stock;
            _stock.AddObserver(this);
        }

        public void Update()
        {
            Console.WriteLine("Bank detected: " + ((Stock)_stock).CurrencyValue);
        }
    }
}