using System;

namespace DesignPatterns.BehaviorPatterns.Strategy.Strategy
{
    public class PetrolMovable : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Petrol movable");
        }
    }
}