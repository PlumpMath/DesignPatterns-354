using System;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Product
{
    public class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Wood House created!");
        }
    }
}