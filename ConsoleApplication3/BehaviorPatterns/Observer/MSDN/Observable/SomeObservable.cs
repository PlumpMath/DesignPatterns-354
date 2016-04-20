using System;
using System.Collections.Generic;

namespace DesignPatterns.BehaviorPatterns.Observer.MSDN.Observable
{
    public class SomeObservable : IObservable<SomeBusinessData>
    {
        private readonly List<IObserver<SomeBusinessData>> _observers;


        public SomeObservable()
        {
            _observers = new List<IObserver<SomeBusinessData>>();
        }


        public IDisposable Subscribe(IObserver<SomeBusinessData> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }

            return new Unsubscriber<SomeBusinessData>(_observers, observer);
        }

        public void DoSomeAction(int num)
        {
            var random = new Random();
            var val = random.Next(num, 1000);
            var someBusinessData = new SomeBusinessData(val.ToString("G"), val);

            NotifyObservers(someBusinessData);
        }

        public void StopNotify()
        {
            foreach (var observer in _observers)
            {
                observer.OnCompleted();
            }

            _observers.Clear();
        }

        private void NotifyObservers(SomeBusinessData someBusinessData)
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(someBusinessData);
            }
        }
    }
}