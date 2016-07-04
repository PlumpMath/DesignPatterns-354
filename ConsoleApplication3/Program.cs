using System;
using DesignPatterns.BehaviorPatterns.ChainOfResponsibility;
using DesignPatterns.BehaviorPatterns.Command.Command;
using DesignPatterns.BehaviorPatterns.Command.MacroCommand;
using DesignPatterns.BehaviorPatterns.Interpretator;
using DesignPatterns.BehaviorPatterns.Iterator;
using DesignPatterns.BehaviorPatterns.Mediator;
using DesignPatterns.BehaviorPatterns.Memento;
using DesignPatterns.BehaviorPatterns.Observer;
using DesignPatterns.BehaviorPatterns.Observer.MSDN;
using DesignPatterns.BehaviorPatterns.State;
using DesignPatterns.BehaviorPatterns.Strategy;
using DesignPatterns.BehaviorPatterns.TemplateMethod;
using DesignPatterns.BehaviorPatterns.Visitor;
using DesignPatterns.CreationalPatterns.AbstractFactory;
using DesignPatterns.CreationalPatterns.Builder;
using DesignPatterns.CreationalPatterns.FactoryMethod;
using DesignPatterns.CreationalPatterns.Prototype;
using DesignPatterns.CreationalPatterns.Singleton;
using DesignPatterns.OtherPatterns.Specification.Test;
using DesignPatterns.StructuralPattern.Adapter;
using DesignPatterns.StructuralPattern.Bridge;
using DesignPatterns.StructuralPattern.Composite;
using DesignPatterns.StructuralPattern.Decorator;
using DesignPatterns.StructuralPattern.Facade;
using DesignPatterns.StructuralPattern.Flyweight;
using DesignPatterns.StructuralPattern.Proxy;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //PatternDecorator.RunTest(new FactorMethodTest());
            //PatternDecorator.RunTest(new AbstractFactoryTest());
            //PatternDecorator.RunTest(new SingletonTest());
            //PatternDecorator.RunTest(new SpecificationTest());
            //PatternDecorator.RunTest(new PrototypeTest());
            //PatternDecorator.RunTest(new BuilderTest());

            //PatternDecorator.RunTest(new StrategyTest());
            //PatternDecorator.RunTest(new ObserverTest());
            //PatternDecorator.RunTest(new ObservertMsdnTest());
            //PatternDecorator.RunTest(new CommandTest());
            //PatternDecorator.RunTest(new MacroCommandTest());
            //PatternDecorator.RunTest(new TemplateMethodTest());
            //PatternDecorator.RunTest(new IteratorTest());
            //PatternDecorator.RunTest(new StateTest());
            //PatternDecorator.RunTest(new ChainOfResponsibilityTest());
            //PatternDecorator.RunTest(new InterpretatorTest());
            //PatternDecorator.RunTest(new MediatorTest());
            //PatternDecorator.RunTest(new MementoTest());
            //PatternDecorator.RunTest(new VisitorTest());

            //PatternDecorator.RunTest(new DecoratorTest());
            //PatternDecorator.RunTest(new AdapterTest());
            //PatternDecorator.RunTest(new FacadeTest());
            //PatternDecorator.RunTest(new CompositeTest());
            //PatternDecorator.RunTest(new ProxyTest());
            //PatternDecorator.RunTest(new BridgeTest());
            PatternDecorator.RunTest(new FlyweightTest());

            Console.Read();
        }
    }
}