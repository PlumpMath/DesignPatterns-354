using System;
using DesignPatterns.StructuralPattern.Bridge.Abstraction;
using DesignPatterns.StructuralPattern.Bridge.BridgeInterface;

namespace DesignPatterns.StructuralPattern.Bridge
{
    public class BridgeTest : PatternTest
    {
        public BridgeTest() : base("Bridge")
        {
        }


        public override void Run()
        {
            var speedSensor = new SpeedSensor(new SpeedSensorImpl());
            speedSensor.DoSomeWork();
            ShowSensorResult(speedSensor);
            speedSensor.SensorInterface = new SpeedSensorImplY();
            ShowSensorResult(speedSensor);

            var weightSensor = new WeightSensor(new WeightSensorImpl());
            weightSensor.DoSomeWork();
            ShowSensorResult(weightSensor);
            weightSensor.SensorInterface = new WeightSensorImplY();
            ShowSensorResult(weightSensor);
        }

        private void ShowSensorResult(SensorDevice sensor)
        {
            Console.WriteLine(sensor.GetSensorInfo());
            Console.WriteLine(sensor.GetSensorData());
        }
    }
}