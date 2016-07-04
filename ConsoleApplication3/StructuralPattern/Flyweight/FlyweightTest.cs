using DesignPatterns.StructuralPattern.Flyweight.FlyweightAbstract;

namespace DesignPatterns.StructuralPattern.Flyweight
{
    public class FlyweightTest : PatternTest
    {
        public FlyweightTest() : base("Flyweight")
        {
        }


        public override void Run()
        {
            var houseFactory = new HouseFactory();
            double lon = 50, lat = 40;

            for (int i = 0; i < 200000; i++)
            {
                var panelHouse = houseFactory.GetHouse("Panel");
                panelHouse.Build(lon, lat);
                lon += 1;
                lat += 1;
            }

            for (int i = 0; i < 200000; i++)
            {
                var panelHouse = houseFactory.GetHouse("Brick");
                panelHouse.Build(lon, lat);
                lon += 1;
                lat += 1;
            }
        }
    }
}