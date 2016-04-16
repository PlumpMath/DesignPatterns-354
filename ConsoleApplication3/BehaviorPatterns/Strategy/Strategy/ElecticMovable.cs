using System;

namespace DesignPatterns.BehaviorPatterns.Strategy.Strategy
{
    public class ElecticMovable : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Electric movable");
        }
    }
}