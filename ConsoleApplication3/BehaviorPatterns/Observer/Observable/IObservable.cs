using DesignPatterns.BehaviorPatterns.Observer.Observer;

namespace DesignPatterns.BehaviorPatterns.Observer.Observable
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);

        void RemoveObserver(IObserver observer);

        void NotifyObservers();
    }
}