using DesignPatterns.BehaviorPatterns.Memento.Caretaker;
using DesignPatterns.BehaviorPatterns.Memento.Originator;

namespace DesignPatterns.BehaviorPatterns.Memento
{
    public class MementoTest : PatternTest
    {
        public MementoTest() : base("Memento")
        {
        }


        public override void Run()
        {
            var hero = new Hero();

            hero.Shoot();
            hero.Shoot();
            hero.Shoot();

            var gameHistory = new GameHistory();

            var memento = hero.SaveState();
            gameHistory.HeroMemento.Push(memento);

            hero.Shoot();
            hero.Shoot();
            hero.Shoot();

            hero.RecoverMemento(gameHistory.HeroMemento.Pop());

            hero.Shoot();
            hero.Shoot();
            hero.Shoot();
        }
    }
}