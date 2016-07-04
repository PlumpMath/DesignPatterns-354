using System.Collections;

namespace DesignPatterns.StructuralPattern.Flyweight.FlyweightAbstract
{
    public class HouseFactory
    {
        private readonly Hashtable _table = new Hashtable();


        public HouseFactory()
        {
            _table.Add("Panel", new PanelHouse());
            _table.Add("Brick", new BrickHouse());
        }


        public House GetHouse(string key)
        {
            return _table[key] as House;
        }
    }
}