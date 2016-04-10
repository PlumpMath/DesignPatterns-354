using System;

namespace DesignPatterns.GenerativePatterns.AbstractFactory.Product
{
    public class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Sword in action");
        }
    }
}