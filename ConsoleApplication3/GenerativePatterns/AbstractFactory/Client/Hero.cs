using DesignPatterns.GenerativePatterns.AbstractFactory.Factory;
using DesignPatterns.GenerativePatterns.AbstractFactory.Product;

namespace DesignPatterns.GenerativePatterns.AbstractFactory.Client
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