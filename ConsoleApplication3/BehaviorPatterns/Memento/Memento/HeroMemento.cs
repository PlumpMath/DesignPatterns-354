namespace DesignPatterns.BehaviorPatterns.Memento.Memento
{
    public class HeroMemento
    {
        public int Shoots { get; private set; }

        public int Lives { get; private set; }


        public HeroMemento(int shoots, int lives)
        {
            Shoots = shoots;
            Lives = lives;
        }
    }
}