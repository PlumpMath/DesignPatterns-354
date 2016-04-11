using DesignPatterns.CreationalPatterns.AbstractFactory.Product;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Factory
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