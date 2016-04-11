using System;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Product
{
    public class RunMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Running");
        }
    }
}