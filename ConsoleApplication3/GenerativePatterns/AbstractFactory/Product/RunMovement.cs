using System;

namespace DesignPatterns.GenerativePatterns.AbstractFactory.Product
{
    public class RunMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Running");
        }
    }
}