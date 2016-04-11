using System;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Product
{
    public class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Panel House created!");
        }
    }
}