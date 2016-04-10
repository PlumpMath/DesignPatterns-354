using DesignPatterns.GenerativePatterns.AbstractFactory.Product;

namespace DesignPatterns.GenerativePatterns.AbstractFactory.Factory
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