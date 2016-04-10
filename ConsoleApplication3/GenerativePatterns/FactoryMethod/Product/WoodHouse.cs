using System;

namespace DesignPatterns.GenerativePatterns.FactoryMethod.Product
{
    public class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Wood House created!");
        }
    }
}