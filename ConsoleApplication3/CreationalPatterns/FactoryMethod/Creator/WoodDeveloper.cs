using DesignPatterns.CreationalPatterns.FactoryMethod.Product;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Creator
{
    public class WoodDeveloper : Developer
    {
        public override House Create()
        {
            return new WoodHouse();
        }
    }
}