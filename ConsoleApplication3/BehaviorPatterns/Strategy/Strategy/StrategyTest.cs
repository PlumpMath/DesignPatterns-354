namespace DesignPatterns.BehaviorPatterns.Strategy.Strategy
{
    public class StrategyTest : PatternTest
    {
        public StrategyTest() : base("Strategy")
        {

        }


        public override void Run()
        {
            var car = new Car("MB", new PetrolMovable());
            car.Move();

            car.Movable = new ElecticMovable();
            car.Move();
        }
    }
}
