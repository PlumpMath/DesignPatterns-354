using DesignPatterns.CreationalPatterns.FactoryMethod.Product;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Creator
{
    public abstract class Developer
    {
        // Factory method
        public abstract House Create();
    }
}