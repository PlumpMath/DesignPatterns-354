using System;

namespace DesignPatterns.BehaviorPatterns.TemplateMethod
{
    public class University : Study
    {
        public override void Start()
        {
            Console.WriteLine("Enter university");
        }

        public override void PassExam()
        {
            Console.WriteLine("Pass practice");
            base.PassExam();
        }

        public override void Finish()
        {
            Console.WriteLine("Graduate from university");
        }
    }
}