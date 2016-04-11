using System;
using DesignPatterns.CreationalPatterns.AbstractFactory.Client;
using DesignPatterns.CreationalPatterns.AbstractFactory.Factory;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class AbstractFactoryTest : PatternTest
    {
        public AbstractFactoryTest()
            : base("AbstractFactory")
        {

        }

        public override void Run()
        {
            Console.WriteLine("Add elf factory");
            var heroFactory = GetFactory(HeroType.Elf);
            var hero = new Hero(heroFactory);
            hero.Hit();
            hero.Move();

            Console.WriteLine("Add voin factory");
            heroFactory = GetFactory(HeroType.Voin);
            hero = new Hero(heroFactory);
            hero.Hit();
            hero.Move();
        }

        private HeroFactory GetFactory(HeroType heroType)
        {
            switch (heroType)
            {
                case HeroType.Elf:
                    return new ElfFactory();
                case HeroType.Voin:
                    return new VoinFactory();
                default:
                    throw new ArgumentOutOfRangeException("heroType");
            }
        }
    }

    public enum HeroType
    {
        Elf,
        Voin
    }
}