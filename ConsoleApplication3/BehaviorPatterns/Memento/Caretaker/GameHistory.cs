using System.Collections.Generic;
using DesignPatterns.BehaviorPatterns.Memento.Memento;
using MyMemento = DesignPatterns.BehaviorPatterns.Memento.Memento.HeroMemento;

namespace DesignPatterns.BehaviorPatterns.Memento.Caretaker
{
    public class GameHistory
    {
        public Stack<HeroMemento> HeroMemento { get; private set; }


        public GameHistory()
        {
            HeroMemento = new Stack<MyMemento>();
        }
    }
}