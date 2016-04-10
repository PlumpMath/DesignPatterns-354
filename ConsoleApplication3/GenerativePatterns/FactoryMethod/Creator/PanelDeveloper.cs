using DesignPatterns.GenerativePatterns.FactoryMethod.Product;

namespace DesignPatterns.GenerativePatterns.FactoryMethod.Creator
{
    public class PanelDeveloper : Developer
    {
        public override House Create()
        {
            return new PanelHouse();
        }
    }
}