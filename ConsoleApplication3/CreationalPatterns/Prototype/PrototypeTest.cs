using System;

namespace DesignPatterns.CreationalPatterns.Prototype
{
    public class PrototypeTest : PatternTest
    {
        public PrototypeTest() : base("Prototype")
        {
        }

        public override void Run()
        {
            Console.WriteLine("Add rectangle 4,5");
            var rect = new Rectangle(4, 5);
            Console.WriteLine(rect.GetInfo());
            Console.WriteLine("Clone rectangle 4,5");
            var rect2 = rect.DeepCopy();
            rect.Point.X = 100;
            Console.WriteLine(rect.GetInfo());
            Console.WriteLine("After clobe rect:");
            Console.WriteLine(rect2.GetInfo());
        }
    }
}