using System;
using DesignPatterns.BehaviorPatterns.Memento.Caretaker;
using DesignPatterns.BehaviorPatterns.Memento.Memento;

namespace DesignPatterns.BehaviorPatterns.Memento.Originator
{
    public class Hero
    {
        private int _shoots;
        private int _lives;


        public Hero()
        {
            _shoots = 10;
            _lives = 3;
            ShowStatistic();
        }


        public void Shoot()
        {
            Console.WriteLine("Shoot");
            _shoots--;
            ShowStatistic();
        }

        public HeroMemento SaveState()
        {
            Console.WriteLine("Saving memento");
            ShowStatistic();
            var mem = new HeroMemento(_shoots, _lives);
            return mem;
        }

        public void RecoverMemento(HeroMemento memento)
        {
            Console.WriteLine("Restore memento");
            _shoots = memento.Shoots;
            _lives = memento.Lives;
            ShowStatistic();
        }


        private void ShowStatistic()
        {
            Console.WriteLine("Shoots: {0}, Lives: {1}", _shoots, _lives);
        }
    }
}