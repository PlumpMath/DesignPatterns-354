namespace DesignPatterns.BehaviorPatterns.State.State
{
    public abstract class WaterState
    {
        public abstract void Heat(Water water);

        public abstract void Frost(Water water);
    }
}