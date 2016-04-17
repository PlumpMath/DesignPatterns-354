using System;
using System.Collections.Generic;
using DesignPatterns.BehaviorPatterns.Observer.Observer;

namespace DesignPatterns.BehaviorPatterns.Observer.Observable
{
    public class Stock : IObservable
    {
        private readonly List<IObserver> _observers;
        public int CurrencyValue { get; private set; }


        public Stock()
        {
            _observers = new List<IObserver>();
        }


        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

        public void Market()
        {
            var r = new Random();
            CurrencyValue = r.Next(20, 100);
            NotifyObservers();
        }
    }
}