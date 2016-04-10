using System;

namespace DesignPatterns.GenerativePatterns.AbstractFactory.Product
{
    public class Arbalet : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Arbalet in action");
        }
    }
}