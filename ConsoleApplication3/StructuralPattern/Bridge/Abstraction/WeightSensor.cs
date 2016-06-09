using System;
using DesignPatterns.StructuralPattern.Bridge.BridgeInterface;

namespace DesignPatterns.StructuralPattern.Bridge.Abstraction
{
    public class WeightSensor : SensorDevice
    {
        public WeightSensor(ISensorInterface sensorInterface) : base(sensorInterface)
        {
        }


        public override string GetSensorInfo()
        {
            return "Weight Sensor";
        }

        public override void DoSomeWork()
        {
            Console.WriteLine("Weight Sensor working");
        }
    }
}