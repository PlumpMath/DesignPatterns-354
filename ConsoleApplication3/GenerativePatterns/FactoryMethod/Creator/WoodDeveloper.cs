using DesignPatterns.GenerativePatterns.FactoryMethod.Product;

namespace DesignPatterns.GenerativePatterns.FactoryMethod.Creator
{
    public class WoodDeveloper : Developer
    {
        public override House Create()
        {
            return new WoodHouse();
        }
    }
}