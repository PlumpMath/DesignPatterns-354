using System;

namespace DesignPatterns.StructuralPattern.Flyweight.FlyweightAbstract
{
    public class PanelHouse : House
    {
        public PanelHouse()
        {
            Stages = 16;
        }


        public override void Build(double longitude, double latitude)
        {
            Console.WriteLine("Panel house has been built (lon {0}, lat {1}). Stages {2}", longitude, latitude, Stages);
        }
    }
}