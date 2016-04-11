using System;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Product
{
    public class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Flying");
        }
    }
}