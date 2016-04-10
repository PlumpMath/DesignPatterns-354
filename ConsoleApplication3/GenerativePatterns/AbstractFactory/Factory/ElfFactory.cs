using DesignPatterns.GenerativePatterns.AbstractFactory.Product;

namespace DesignPatterns.GenerativePatterns.AbstractFactory.Factory
{
    public class ElfFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Arbalet();
        }
    }
}