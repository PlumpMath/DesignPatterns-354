using System;

namespace DesignPatterns.GenerativePatterns.AbstractFactory.Product
{
    public class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Flying");
        }
    }
}