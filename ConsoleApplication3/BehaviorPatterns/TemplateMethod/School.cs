using System;

namespace DesignPatterns.BehaviorPatterns.TemplateMethod
{
    public class School : Study
    {
        public override void Start()
        {
            Console.WriteLine("Start school");
        }

        public override void Finish()
        {
            Console.WriteLine("Finish school");
        }
    }
}