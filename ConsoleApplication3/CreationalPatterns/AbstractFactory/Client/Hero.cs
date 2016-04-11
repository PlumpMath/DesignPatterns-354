using DesignPatterns.CreationalPatterns.AbstractFactory.Factory;
using DesignPatterns.CreationalPatterns.AbstractFactory.Product;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.Client
{
    public class Hero
    {
        private readonly Movement _movement;
        private readonly Weapon _weapon;


        public Hero(HeroFactory heroFactory)
        {
            _weapon = heroFactory.CreateWeapon();
            _movement = heroFactory.CreateMovement();
        }


        public void Hit()
        {
            _weapon.Hit();
        }

        public void Move()
        {
            _movement.Move();
        }
    }
}