using System;

namespace DesignPatterns.BehaviorPatterns.TemplateMethod
{
    public abstract class Study
    {
        public void Learn()
        {
            Start();
            PassExam();
            Finish();
        }

        public virtual void Start()
        {
            
        }

        public virtual void PassExam()
        {
            Console.WriteLine("Pass exam");
        }

        public virtual void Finish()
        {
            
        }
    }
}