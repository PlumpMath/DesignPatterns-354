using System;

namespace DesignPatterns.StructuralPattern.Flyweight.FlyweightAbstract
{
    public class BrickHouse : House
    {
        public BrickHouse()
        {
            Stages = 5;
        }


        public override void Build(double longitude, double latitude)
        {
            Console.WriteLine("Brick house has been built (lon {0}, lat {1}). Stages {2}", longitude, latitude, Stages);
        }
    }
}