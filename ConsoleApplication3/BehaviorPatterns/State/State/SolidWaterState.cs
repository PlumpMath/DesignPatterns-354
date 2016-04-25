using System;

namespace DesignPatterns.BehaviorPatterns.State.State
{
    public class SolidWaterState : WaterState
    {
        public override void Heat(Water water)
        {
            Console.WriteLine("Лед в жидкость");
            water.State = new LiquidWaterState();
        }

        public override void Frost(Water water)
        {
            Console.WriteLine("Суперзаморозка");
        }
    }
}