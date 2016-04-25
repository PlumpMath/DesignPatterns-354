using System;

namespace DesignPatterns.BehaviorPatterns.State.State
{
    public class GasWaterState : WaterState
    {
        public override void Heat(Water water)
        {
            Console.WriteLine("Очень горячий газ");
        }

        public override void Frost(Water water)
        {
            Console.WriteLine("Газ в жидкость");
            water.State = new SolidWaterState();
        }
    }
}