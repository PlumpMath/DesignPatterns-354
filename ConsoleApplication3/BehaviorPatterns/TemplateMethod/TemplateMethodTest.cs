using System;

namespace DesignPatterns.BehaviorPatterns.TemplateMethod
{
    public class TemplateMethodTest : PatternTest
    {
        public TemplateMethodTest() : base("TemplateMethod")
    {
    }

        public override void Run()
        {
            var school = new School();
            var university = new University();

            Console.WriteLine("---School---");
            school.Learn();
            Console.WriteLine("---University---");
            university.Learn();
        }
    }
}