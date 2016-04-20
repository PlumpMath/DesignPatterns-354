using System;

namespace DesignPatterns.BehaviorPatterns.Observer.MSDN.Observer
{
    public class SecondObserver : IObserver<SomeBusinessData>
    {
        public void OnNext(SomeBusinessData value)
        {
            Console.WriteLine("SecondObserver");
            Console.WriteLine(value.ToString());
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            Console.WriteLine("SecondObserver compeletd tracking");
        }
    }
}