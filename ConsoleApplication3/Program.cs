using System;
using DesignPatterns.BehaviorPatterns.Observer;
using DesignPatterns.BehaviorPatterns.Observer.MSDN;
using DesignPatterns.BehaviorPatterns.Strategy;
using DesignPatterns.CreationalPatterns.AbstractFactory;
using DesignPatterns.CreationalPatterns.Builder;
using DesignPatterns.CreationalPatterns.FactoryMethod;
using DesignPatterns.CreationalPatterns.Prototype;
using DesignPatterns.CreationalPatterns.Singleton;
using DesignPatterns.OtherPatterns.Specification.Test;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            PatternDecorator.RunTest(new FactorMethodTest());
            PatternDecorator.RunTest(new AbstractFactoryTest());
            PatternDecorator.RunTest(new SingletonTest());
            PatternDecorator.RunTest(new SpecificationTest());
            PatternDecorator.RunTest(new PrototypeTest());
            PatternDecorator.RunTest(new BuilderTest());
            PatternDecorator.RunTest(new StrategyTest());
            PatternDecorator.RunTest(new ObserverTest());
            PatternDecorator.RunTest(new ObservertMsdnTest());

            Console.Read();
        }
    }
}