﻿using System;
using System.Collections.Generic;

namespace DesignPatterns.BehaviorPatterns.Observer.MSDN.Observable
{
    public class Unsubscriber<T> : IDisposable
    {
        private readonly List<IObserver<T>> _observers;
        private readonly IObserver<T> _observer;

        public Unsubscriber(List<IObserver<T>> observers, IObserver<T> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observers != null)
            {
                _observers.Remove(_observer);
            }
        }
    }
}