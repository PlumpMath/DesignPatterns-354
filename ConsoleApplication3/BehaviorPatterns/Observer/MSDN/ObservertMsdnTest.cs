using System;
using DesignPatterns.BehaviorPatterns.Observer.MSDN.Observable;
using DesignPatterns.BehaviorPatterns.Observer.MSDN.Observer;

namespace DesignPatterns.BehaviorPatterns.Observer.MSDN
{
    public class ObservertMsdnTest : PatternTest
    {
        private IDisposable _firstCancelation;


        public ObservertMsdnTest()
            : base("ObservertMsdnTest")
        {
        }


        public override void Run()
        {
            var someObservable = new SomeObservable();
            var firstObserver = new FirstObserver();
            var secondObserver = new SecondObserver();

            someObservable.DoSomeAction(800);
            Console.WriteLine("Add FirstObserver");
            _firstCancelation = someObservable.Subscribe(firstObserver);
            
            Console.WriteLine("Add SecondObserver");
            someObservable.Subscribe(secondObserver);
            
            Console.WriteLine("Do some action in Observable twice");
            someObservable.DoSomeAction(100);
            someObservable.DoSomeAction(200);

            Console.WriteLine("Unsubscribe FirstObserver and Do some action in Observable");
            _firstCancelation.Dispose();
            someObservable.DoSomeAction(300);

            Console.WriteLine("Cancel notify");
            someObservable.StopNotify();
        }
    }
}