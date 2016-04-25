using DesignPatterns.BehaviorPatterns.State.State;

namespace DesignPatterns.BehaviorPatterns.State
{
    public class StateTest : PatternTest
    {
        public StateTest() : base("State")
        {
        }


        public override void Run()
        {
            var water = new Water(new SolidWaterState());
            water.Heat();
            water.Frost();
            water.Frost();
            water.Heat();
            water.Heat();
            water.Heat();
            water.Frost();
        }
    }
}