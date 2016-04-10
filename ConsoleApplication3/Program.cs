using System;
using DesignPatterns.GenerativePatterns.AbstractFactory;
using DesignPatterns.GenerativePatterns.FactoryMethod;
using DesignPatterns.GenerativePatterns.Singleton;
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

            Console.Read();
        }
    }
}