using System;

namespace DesignPatterns.StructuralPattern.Adapter.Adaptee
{
    public class Camel : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Верблюд идет по пустыне");
        }
    }
}