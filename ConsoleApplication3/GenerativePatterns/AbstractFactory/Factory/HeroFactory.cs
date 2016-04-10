using DesignPatterns.GenerativePatterns.AbstractFactory.Product;

namespace DesignPatterns.GenerativePatterns.AbstractFactory.Factory
{
    public abstract class HeroFactory // Abstract factory
    {
        public abstract Movement CreateMovement();

        public abstract Weapon CreateWeapon();
    }
}