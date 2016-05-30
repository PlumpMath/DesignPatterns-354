using System;

namespace DesignPatterns.StructuralPattern.Composite.CustomComponent
{
    public abstract class Component
    {
        protected string Name { get; private set; }


        protected Component(string name)
        {
            Name = name;
        }


        public abstract void Add(Component component);

        public abstract void Remove(Component component);


        public virtual void PrintInfo(string prefix = null)
        {
            Console.WriteLine(prefix != null ? prefix + Name : Name);
        }
    }
}