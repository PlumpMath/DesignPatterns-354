using System;
using System.Collections.Generic;

namespace DesignPatterns.StructuralPattern.Composite.CustomComponent
{
    public class Directory : Component
    {
        private const string DefaultPrefix = "--";
        private readonly List<Component> _list;


        public Directory(string name)
            : base(name)
        {
            _list = new List<Component>();
        }


        public override void Add(Component component)
        {
            _list.Add(component);
        }

        public override void Remove(Component component)
        {
            _list.Remove(component);
        }

        public override void PrintInfo(string prefix = null)
        {
            prefix = prefix ?? "";
            Console.WriteLine(prefix + "Root: " + Name);
            Console.WriteLine(prefix + "Substructure:");
            foreach (var component in _list)
            {
                component.PrintInfo(prefix + DefaultPrefix);
            }
        }
    }
}