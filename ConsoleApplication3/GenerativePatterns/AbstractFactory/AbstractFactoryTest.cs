using System;
using DesignPatterns.GenerativePatterns.AbstractFactory.Client;
using DesignPatterns.GenerativePatterns.AbstractFactory.Factory;

namespace DesignPatterns.GenerativePatterns.AbstractFactory
{
    public class AbstractFactoryTest : PatternTest
    {
        public AbstractFactoryTest() : base("AbstractFactory")
        {

        }

        public override void Run()
        {
            Console.WriteLine("Add elf factory");
            Hero hero = new Hero(new ElfFactory());
            hero.Hit();
            hero.Move();

            Console.WriteLine("Add voin factory");

            hero = new Hero(new VoinFactory());
            hero.Hit();
            hero.Move();
        }
    }
}