using DesignPatterns.CreationalPatterns.FactoryMethod.Product;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Creator
{
    public class PanelDeveloper : Developer
    {
        public override House Create()
        {
            return new PanelHouse();
        }
    }
}