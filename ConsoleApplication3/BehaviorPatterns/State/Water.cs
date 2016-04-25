using DesignPatterns.BehaviorPatterns.State.State;

namespace DesignPatterns.BehaviorPatterns.State
{
    public class Water
    {
        public WaterState State { get; set; }


        public Water(WaterState state)
        {
            State = state;
        }


        public void Heat()
        {
            State.Heat(this);
        }

        public void Frost()
        {
            State.Frost(this);
        }
    }
}