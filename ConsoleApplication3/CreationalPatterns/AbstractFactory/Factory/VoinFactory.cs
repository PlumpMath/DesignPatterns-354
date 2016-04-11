using DesignPatterns.CreationalPatterns.AbstractFactory.Product;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Factory
{
    public class VoinFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}