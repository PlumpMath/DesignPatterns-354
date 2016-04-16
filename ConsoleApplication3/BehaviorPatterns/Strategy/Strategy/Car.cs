namespace DesignPatterns.BehaviorPatterns.Strategy.Strategy
{
    public class Car
    {
        private readonly string _name;
        public IMovable Movable { get; set; }


        public Car(string name, IMovable move)
        {
            _name = name;
            Movable = move;
        }


        public void Move()
        {
            Movable.Move();
        }
    }
}