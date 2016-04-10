using System;

namespace DesignPatterns.GenerativePatterns.FactoryMethod.Product
{
    public class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Panel House created!");
        }
    }
}