using DesignPatterns.CreationalPatterns.AbstractFactory.Product;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Factory
{
    public abstract class HeroFactory // Abstract factory
    {
        public abstract Movement CreateMovement();

        public abstract Weapon CreateWeapon();
    }
}