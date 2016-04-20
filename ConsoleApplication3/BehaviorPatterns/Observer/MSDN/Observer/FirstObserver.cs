using System;

namespace DesignPatterns.BehaviorPatterns.Observer.MSDN.Observer
{
    public class FirstObserver : IObserver<SomeBusinessData>
    {
        public void OnNext(SomeBusinessData value)
        {
            Console.WriteLine("FirstObserver");
            Console.WriteLine(value.ToString());
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            Console.WriteLine("FirstObserver compeletd tracking");
        }
    }
}