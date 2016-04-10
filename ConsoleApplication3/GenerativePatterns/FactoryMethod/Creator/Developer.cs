using DesignPatterns.GenerativePatterns.FactoryMethod.Product;

namespace DesignPatterns.GenerativePatterns.FactoryMethod.Creator
{
    public abstract class Developer
    {
        // Factory method
        public abstract House Create();
    }
}