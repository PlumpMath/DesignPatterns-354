using System;

namespace DesignPatterns.GenerativePatterns.Singleton
{
    public class SingletonTest : PatternTest
    {
        public SingletonTest() : base("Singleton")
        {
            
        }

        public override void Run()
        {
            var operSyst = OperatingSystem.GetInstance("Win 7");
            operSyst = OperatingSystem.GetInstance("Win 8");
            Console.WriteLine(operSyst.OperatingSystemName);
        }
    }
}