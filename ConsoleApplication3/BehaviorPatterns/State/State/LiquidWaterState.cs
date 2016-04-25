using System;

namespace DesignPatterns.BehaviorPatterns.State.State
{
    public class LiquidWaterState : WaterState
    {
        public override void Heat(Water water)
        {
            Console.WriteLine("Вода в газ");
            water.State = new GasWaterState();
        }

        public override void Frost(Water water)
        {
            Console.WriteLine("Вода в лед");
            water.State = new SolidWaterState();
        }
    }
}